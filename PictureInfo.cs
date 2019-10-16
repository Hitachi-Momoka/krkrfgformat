using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Li.Text
{
    public class PictureInfo
    {
        [JsonProperty(PropertyName = "layer_type")]
        public int LayerType
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "left")]
        public int Left
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "top")]
        public int Top
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "width")]
        public int Width
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "height")]
        public int Height
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "type")]
        public int Type
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "opacity")]
        public int Opacity
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "visible")]
        public int Visible
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "layer_id")]
        public int LayerId
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "group_layer_id")]
        public int GroupLayerId
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "base")]
        public int Base
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "images")]
        public int Images
        {
            get;
            set;
        }

        public PictureInfo()
        {
            LayerType = 0;
            Name = string.Empty;
            Left = 0;
            Top = 0;
            Width = 0;
            Height = 0;
            Type = 0;
            Opacity = 0;
            Visible = 0;
            LayerId = 0;
            GroupLayerId = 0;
            Base = 0;
            Images = 0;
        }

        public PictureInfo(string readline)
        {
            List<string> list = new List<string>();
            if (readline != string.Empty)
            {
                string text = string.Empty;
                for (int i = 0; i < readline.Length; i++)
                {
                    if (readline[i] != '\t')
                    {
                        text += readline[i].ToString();
                    }
                    else
                    {
                        if (text == string.Empty)
                        {
                            list.Add("0");
                            text = string.Empty;
                            continue;
                        }
                        list.Add(text);
                        text = string.Empty;
                    }
                    if (list.Count == 13)
                    {
                        break;
                    }
                }
            }
            if (list.Count < 13)
            {
                throw new Exception("txt文件内容格式错误");
            }
            LayerType = Convert.ToInt32(list[0]);
            Name = list[1];
            Left = Convert.ToInt32(list[2]);
            Top = Convert.ToInt32(list[3]);
            Width = Convert.ToInt32(list[4]);
            Height = Convert.ToInt32(list[5]);
            Type = Convert.ToInt32(list[6]);
            Opacity = Convert.ToInt32(list[7]);
            Visible = Convert.ToInt32(list[8]);
            LayerId = Convert.ToInt32(list[9]);
            GroupLayerId = Convert.ToInt32(list[10]);
            Base = Convert.ToInt32(list[11]);
            Images = Convert.ToInt32(list[12]);
        }

        public override string ToString()
        {
            string tmp = "";
            tmp += (this.LayerType + "\t");
            tmp += (this.Name + "\t");
            tmp += (this.Left + "\t");
            tmp += (this.Top + "\t");
            tmp += (this.Width + "\t");
            tmp += (this.Height + "\t");
            tmp += (this.Type + "\t");
            tmp += (this.Opacity + "\t");
            tmp += (this.Visible + "\t");
            tmp += (this.LayerId + "\t");
            tmp += (this.GroupLayerId + "\t");
            tmp += (this.Base + "\t");
            tmp += (this.Images + "\t");
            return tmp;
        }
    }
}
