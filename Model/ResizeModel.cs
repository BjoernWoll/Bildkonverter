using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Model
{
    public class ResizeModel
    {
        #region Variablen
        private String resizeImageFolder;
        private Graphics graphic;
        private List<String> originalImages;
        private String savePath;
        private Int32 horizontalSize;
        private Int32 verticaleSize;
        private String fileName;
        private String fileExtension;
        private Double factor;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orginalImage">Enthält die Pfade der Bilder</param>
        /// <param name="savePath">Ist der Pfad in dem die skalieten Bilder gespeichert werden</param>
        /// <param name="horizontalSize">Wert auf dem die Bilder skaliert werden(Höhe)</param>
        /// <param name="verticaleSize">Wert auf dem die Bilder skaliert werden(Breite)</param>


        public ResizeModel(List<string> orginalImage, String savePath, double factor)
        {

            this.factor = factor;
            this.originalImages = orginalImage;
            this.savePath = savePath;
           
            CreateResizeImageFolder();
        }



        #region Resize Funktion

        /// <summary>
        /// 
        /// </summary>
        public void ResizePictures()
        {
            Int32 height;
            Int32 width;
            Bitmap resizeImage;
            Rectangle destRec;
            Rectangle srcRec;
            Bitmap picture;
            String format;
            String fileName;
            
            destRec = new Rectangle(0, 0, verticaleSize, horizontalSize);
            foreach (String image in originalImages)
            {
                picture = new Bitmap(image);
                width = (int)(factor * picture.Width);
                height = (int)(factor * picture.Height);
                resizeImage = new Bitmap(width, height );
                fileName = GetFileName(image);
                format = GetFileExtension(image);
                fileName = ReplacementFileName(fileName,format);
                
               
                graphic = Graphics.FromImage(resizeImage);
                graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                   graphic.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                  graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

              

                graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphic.DrawImage(picture,0,0, width,height);



                graphic.Save();
                resizeImage.Save(resizeImageFolder + "\\" + fileName);
                resizeImage.Dispose();
                graphic.Dispose();
               
                picture.Dispose();
            }
        }



        #endregion

        public void CreateResizeImageFolder()
        {
            if(!Directory.Exists(savePath+"\\"+"ResizeImage"))
            {
                Directory.CreateDirectory(savePath + "\\" + "ResizeImage");
                resizeImageFolder = savePath + "\\" + "ResizeImage";
            }
            else
                resizeImageFolder = savePath + "\\" + "ResizeImage";



        }



        #region fileInfo

        /// <summary>
        /// Gibt den Dateinamen zurück
        /// </summary>
        /// <param name="imageFile">Enthält den Dateinamen.</param>
        /// <returns></returns>
        public String GetFileName(String imageFile)
        {
            String fileName;
            String[] splittingName = imageFile.Split('\\');
            


            return splittingName[splittingName.Length - 1];
        }


        public String ReplacementFileName(String fileName,String format)
        {
            String[] splitting;
            Int32 counter=0;
            bool exist = File.Exists(resizeImageFolder + "\\" + fileName);
          

            while (exist == true)
            {
                splitting = fileName.Split('.');
                fileName = splitting[0];
                counter++;
                fileName = fileName + counter+"."+format;
                exist = File.Exists(resizeImageFolder + "\\" + fileName);
            }
            return fileName;
        }


        /// <summary>
        /// Gibt das Dateiformat zurück.
        /// </summary>
        /// <param name="imageFile">Enthält das Dateiformat.</param>
        /// <returns></returns>
        public String GetFileExtension(String imageFile)
        {
            String[] splittingExtension = imageFile.Split('.');

            return splittingExtension[splittingExtension.Length - 1];
        }


        #endregion
    }
}
