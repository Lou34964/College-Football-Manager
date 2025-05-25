using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace College_Football_Manager.MetaSettings
{
    public class Team
    {
        public int ID { get; set; }

        public string TeamName { get; set; }

        [XmlIgnore]
        public Color TeamPrimaryColor { get; set; }

        [XmlIgnore]
        public Color TeamSecondaryColor { get; set; }

        #region xmlcolors
        [XmlElement("TeamPrimaryColor")]
        public string TeamPrimaryColorHex
        {
            get => ColorTranslator.ToHtml(TeamPrimaryColor);
            set => TeamPrimaryColor = ColorTranslator.FromHtml(value);
        }

        [XmlElement("TeamSecondaryColor")]
        public string TeamSecondaryColorHex
        {
            get => ColorTranslator.ToHtml(TeamSecondaryColor);
            set => TeamSecondaryColor = ColorTranslator.FromHtml(value);
        }
        #endregion

        public string Conference {  get; set; }

        [XmlIgnore]
        public Image Logo { get; set; }

        public string _imageFileName;
        
        [XmlIgnore]
        public string ImageFileName
        {
            get => _imageFileName;
            set
            {
                _imageFileName = value;
                if (!string.IsNullOrEmpty(value) && File.Exists(value))
                {
                    try
                    {
                        Logo = Image.FromFile(value);
                    }
                    catch
                    {
                        Logo = null;
                    }
                }
                else
                {
                    Logo = null;
                }
            }
        }

        public void SetLogo()
        {
            Logo = Image.FromFile(ImageFileName);
        }

        public Team()
        {

        }
    }
}
