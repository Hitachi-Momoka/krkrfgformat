using Li.Drawing;
using Li.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace Li.krkrfgformat
{
    public class DataFormat
    {
        private class Infos
        {
            public PictureInfo PicInfo
            {
                get;
                set;
            }

            public Bitmap Pic
            {
                get;
                set;
            }

            public Infos(string filename)
            {
                if (Path.GetExtension(filename).ToLower() == ".png")
                {
                    Pic = new Bitmap(filename);
                }
                else
                {
                    try
                    {
                        Pic = DataFormat.TlgFormat(filename);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("读取tlg文件失败，缺少必要的组件（dll）或者文件格式错误。", "警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Pic = new Bitmap(1, 1);
                    }
                }
                if (usingSizeOnly)
                {
                    PicInfo = GetPicInfoFromSize(Pic.Size);
                }
                else
                {
                    PicInfo = (GetPicInfoFromText(GetIDFromFilePatch(filename)) ?? GetPicInfoFromSize(Pic.Size));
                }
            }
        }
        /// <summary>
        /// 是否只用图片大小寻找规则
        /// </summary>
		public static bool usingSizeOnly;

        /// <summary>
        /// 文件路径
        /// </summary>
		public static string FilePatch
        {
            get;
            set;
        }
        /// <summary>
        /// 生成的新图片
        /// </summary>
		public static Bitmap NewPicture
        {
            get;
            set;
        }
        /// <summary>
        /// 文本坐标信息
        /// </summary>
		public static TextFile TextDatas
        {
            get;
            set;
        }
        /// <summary>
        /// listbox顺序存入的图片以及代号
        /// </summary>
		public static Dictionary<int, string> Pictures
        {
            get;
            set;
        }
        /// <summary>
        /// 存储的文件名字
        /// </summary>
		public static string SaveFileName
        {
            get;
            set;
        }

        public DataFormat()
        {
            SaveFileName = string.Empty;
            FilePatch = string.Empty;
            NewPicture = null;
            TextDatas = new TextFile();
            Pictures = new Dictionary<int, string>();
        }
        /// <summary>
        /// 用ID从数据里面寻找坐标数据
        /// </summary>
        /// <param name="id">图片ID</param>
        /// <returns></returns>
		private static PictureInfo GetPicInfoFromText(int id)
        {
            return TextDatas.TextData.Find((PictureInfo tmp) => tmp.LayerId == id);
        }
        /// <summary>
        /// 用图片大小寻找坐标数据
        /// </summary>
        /// <param name="size">需要寻找的图片大小</param>
        /// <returns></returns>
		private static PictureInfo GetPicInfoFromSize(Size size)
        {
            return TextDatas.TextData.Find((PictureInfo tmp) => tmp.Width == size.Width && tmp.Height == size.Height);
        }
        /// <summary>
        /// 获取给定文件路径文件的ID
        /// </summary>
        /// <param name="p">完整路径</param>
        /// <returns></returns>
		private static int GetIDFromFilePatch(string p)
        {
            string[] array = Path.GetFileNameWithoutExtension(p).Split('_');
            return Convert.ToInt32(array[array.Length - 1]);
        }
        /// <summary>
        /// 往工作类添加规则文件
        /// </summary>
        /// <param name="filePatch">规则文件全路径</param>
		public static void AddText(string filePatch)
        {
            try
            {
                TextDatas = new TextFile(filePatch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// 往工作类里面添加图片以及代号
        /// </summary>
        /// <param name="key">代号，默认为每个listbox的代号</param>
        /// <param name="filePath">完整的图片路径</param>
		public static void AddPicture(int key, string filePath)
        {
            Pictures.Remove(key);
            Pictures.Add(key, filePath);
        }
        /// <summary>
        /// 重新按照key排序词典
        /// </summary>
        /// <param name="origin">原始词典</param>
        /// <returns></returns>
		private static Dictionary<int, string> ReSortDictionary(Dictionary<int, string> origin)
        {
            return (from p in origin
                    orderby p.Key
                    select p).ToDictionary((KeyValuePair<int, string> p) => p.Key, (KeyValuePair<int, string> o) => o.Value);
        }
        /// <summary>
        /// 合成代码块
        /// </summary>
		public static void NowFormat()
        {
            SaveFileName = "";
            Dictionary<int, string> dictionary = ReSortDictionary(Pictures);
            Bitmap bitmap = new Bitmap(TextDatas.Fglarge.Width, TextDatas.Fglarge.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                foreach (int key in dictionary.Keys)             //遍历词典依次获得图片信息并且在Graphics绘制图片。
                {
                    Infos infos = new Infos(dictionary[key]);
                    if (infos.PicInfo != null)
                    {
                        #region 合成文件名称。
                        if (string.IsNullOrEmpty(SaveFileName))
                        {
                            SaveFileName += Path.GetFileNameWithoutExtension(dictionary[key]);
                        }
                        else
                        {
                            SaveFileName = SaveFileName + "+" + GetIDFromFilePatch(dictionary[key]);
                        }
                        #endregion
                        if (infos.PicInfo.Opacity != 255)
                        {
                            graphics.DrawImage(infos.Pic,
                                               new Rectangle(infos.PicInfo.Left, infos.PicInfo.Top, infos.PicInfo.Width, infos.PicInfo.Height),
                                               0,
                                               0,
                                               infos.Pic.Width,
                                               infos.Pic.Height,
                                               GraphicsUnit.Pixel,
                                               Picture.GetAlphaImgAttr(infos.PicInfo.Opacity)
                                               );
                        }
                        else
                        {
                            graphics.DrawImage(infos.Pic,
                                               new Rectangle(infos.PicInfo.Left, infos.PicInfo.Top, infos.PicInfo.Width, infos.PicInfo.Height)
                                               );
                        }
                    }
                }
            }
            NewPicture = bitmap.Clone(Picture.GetRectFromPictureWithouBlank(bitmap), bitmap.PixelFormat);//裁剪生成图片多余的透明像素
        }
        /// <summary>
        /// 废弃的方法，暂时不会用。
        /// </summary>
        /// <param name="Infos"></param>
        /// <returns></returns>
        [Obsolete]
        private static Bitmap MixBitmaps(params Infos[] Infos)
        {
            int width = TextDatas.Fglarge.Width;
            int height = TextDatas.Fglarge.Height;
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                foreach (Infos infos in Infos)
                {
                    if (infos != null)
                    {
                        graphics.DrawImage(
                            rect: new Rectangle(infos.PicInfo.Left,
                                                infos.PicInfo.Top,
                                                infos.PicInfo.Width,
                                                infos.PicInfo.Height),
                            image: infos.Pic);
                    }
                }
            }
            return bitmap.Clone(Picture.GetRectFromPictureWithouBlank(bitmap), bitmap.PixelFormat);
        }

        public static Bitmap TlgFormat(string file)
        {
            string exePath = Environment.CurrentDirectory;
            string fileArcFormats = Path.Combine(exePath, "ArcFormats.dll");
            string fileGameRes = Path.Combine(exePath, "GameRes.dll");
            Assembly asmArcFormats = Assembly.LoadFrom(fileArcFormats);
            Assembly asmGameRes = Assembly.LoadFrom(fileGameRes);

            var asm_BinaryStream = asmGameRes.GetType("GameRes.BinaryStream");
            var method_BinaryStream = asm_BinaryStream.GetMethod("FromFile");
            var binaryStream = method_BinaryStream.Invoke(null, new object[] { file });


            var asm_TlgFormat = asmArcFormats.GetType("GameRes.Formats.KiriKiri.TlgFormat");
            var tlgFormat = Activator.CreateInstance(asm_TlgFormat);


            var method_ReadMetaData = asm_TlgFormat.GetMethod("ReadMetaData");
            var info = method_ReadMetaData.Invoke(tlgFormat, new object[] { binaryStream });


            var method_Read = asm_TlgFormat.GetMethod("Read");
            var imageData = method_Read.Invoke(tlgFormat, new object[] { binaryStream, info });
            var bitmapSource = (BitmapSource)imageData.GetType().GetProperty("Bitmap").GetValue(imageData);


            BitmapEncoder bitmapEncoder = new PngBitmapEncoder();
            bitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapSource));
            MemoryStream stream = new MemoryStream();
            bitmapEncoder.Save(stream);
            return new Bitmap(stream);
        }
    }
}
