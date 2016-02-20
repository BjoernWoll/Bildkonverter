using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter.Model
{
    public class ConvertModel
    {

        #region Variablen
        private BackgroundWorker convertWorker;
        List<string> images;
        string savePath;
        Dictionary<string, bool> imageFormat;
        #endregion

        public ConvertModel()
        {

        }


      


        public void Convert(List<string> images, string savePath, Dictionary<string, bool> imageFormat)
        {
            Bitmap bmp; 
            string imageName;
            string fileName;
           // string format;
           string fileExtension;
            
            {
                foreach (string image in images)
                {
                    fileExtension = FileExtensionExtract(image);
                    imageName = FileNameExtract(image);
                    fileName = FileNameComposer(imageName, savePath);
                    try
                    {
                        if ((imageFormat.ContainsKey("Bmp"))&&(fileExtension!="bmp"))
                        {
                            string file = fileName + "." + "bmp";

                            bmp = new Bitmap(image);
                            bmp.Save(file,ImageFormat.Bmp);
                        }

                        if ((imageFormat.ContainsKey("Gif"))&& (fileExtension != "gif"))
                        {
                            string file = fileName + "." + "gif";

                            bmp = new Bitmap(image);
                            bmp.Save(file, ImageFormat.Gif);
                        }

                        if ((imageFormat.ContainsKey("Icon"))&& (fileExtension != "icon"))
                        {
                            string file = fileName + "." + "icon";

                            bmp = new Bitmap(image);
                            bmp.Save(file, ImageFormat.Icon);
                        }

                        if ((imageFormat.ContainsKey("Jpeg")) && (fileExtension != "jpg"))
                        {
                            string file = fileName + "." + "jpg";

                            bmp = new Bitmap(image);
                            bmp.Save(file, ImageFormat.Jpeg);
                        }

                        if ((imageFormat.ContainsKey("Png")) && (fileExtension != "png"))
                        {
                            string file = fileName + "." + "png";

                            bmp = new Bitmap(image);
                            bmp.Save(file, ImageFormat.Png);
                        }

                        if ((imageFormat.ContainsKey("Tiff"))&& (fileExtension != "tiff"))
                        {
                            //string file = fileName + "." + "tiff";

                            //  bmp = new Bitmap(image);
                            // bmp.Save(file, ImageFormat.Tiff);

                            ConvertTiffToJpg(image, savePath);

                        }


                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.ToString(), "Fehler:" + fileName);
                    }
                }
            }
        }
      
        private string FileNameComposer(string imageName, string savePath)
        {
            string name;
            string[] split = imageName.Split('.');
            name = savePath + "\\" + split[0];

            return name;

        }

        private string FileExtensionExtract(string imageFileName)
        {
            string[] nameSplit = imageFileName.Split('.');

            return nameSplit[nameSplit.Length - 1];
        }

        private string FileNameExtract(string imageFileName)
        {
            string[] nameSplit = imageFileName.Split('\\');

            return nameSplit[nameSplit.Length - 1];
        }

        private void ConvertTiffToJpg(string fileName,string Path)
        {
            string[] split = fileName.Split('.');
            string fileWithoutExt = split[1];
            try
            {
                Image image = Image.FromFile(fileName);

                FrameDimension frameDim = new FrameDimension(image.FrameDimensionsList[0]);
                int dim = image.GetFrameCount(frameDim);

                string[] jpgPath = new string[dim];
                for (int frame = 0; frame < dim; frame++)
                {
                    image.SelectActiveFrame(frameDim, frame);
                    using (Bitmap bmp = new Bitmap(fileName))
                    {
                        
                        jpgPath[frame] = String.Format("{0}\\{1}{2}.jpg",
                            Path,
                           fileWithoutExt,
                            frame);
                        bmp.Save(jpgPath[frame], ImageFormat.Jpeg);
                    }
                }




            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
