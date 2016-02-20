using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converter;
using Converter.View;
using Converter.Model;
using System.Data;

namespace Converter.Presenter
{
    public class Presenter
    {

        private Dictionary<string, bool> imageFormats = new Dictionary<string, bool>() ;
        private ConverterView view;
        private ConvertModel model;
      //  private MainModel model;
        private List<String> images = new List<string>();
        private string savePath;
        private Int32 heigth;
        private Int32 width;
        private double factor;
        public Presenter(ConvertModel model, ConverterView view)
        {
            this.view = view;
            this.model = model;

            view.Presenter = this;

        }



       

        #region Checkbox State
        public void OnBmpChanged(bool state)
        {
            if (state == true)
                imageFormats.Add("Bmp", state);
            else
                imageFormats.Remove("Bmp");

        }

        public void OnPngChanged(bool state)
        {
            if (state == true)
                imageFormats.Add("Png", state);
            else
                imageFormats.Remove("Png");
        }

        public void OnJpgChanged(bool state)
        {
            if (state == true)
                imageFormats.Add("Jpeg", state);
            else
                imageFormats.Remove("Jpeg");
        }


        public void OnTiffChanged(bool state)
        {
            if (state == true)
                imageFormats.Add("Tiff", state);
            else
                imageFormats.Remove("Tiff");
        }


        public void OnIconChanged(bool state)
        {
            if (state == true)
                imageFormats.Add("Icon", state);
            else
                imageFormats.Remove("Icon");
        }


        public void OnGifChanged(bool state)
        {
            if (state == true)
                imageFormats.Add("Gif", state);
            else
                imageFormats.Remove("Gif");
        }


       





        #endregion

        public void OnConvertClicked()
        {
            //model.Start(images, savePath, imageFormats);
           // model.Convert(images, savePath,imageFormats);
        }


     

        public void OnSaveImageFilePathClicked()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            savePath = fbd.SelectedPath;
            fbd.Dispose();
            UpdateSavePath(savePath);
        }

        public void OnOpenImagesclicked()
        {
           
            images = openImages();
            UpdateView(images);
        }

        public void OnDeleteListClicked()
        {
            images.Clear();
            List<string> nil = new List<string>();
            UpdateView(nil);
        }

        public void UpdateSavePath(string dir)
        {
            view.UpdateSavePath(dir);
        }
        public void UpdateView(List<string> images)
        {
            view.UpdateView(images,"");
        }

        public List<String> openImages()
        {
            List<String> images = new List<string>();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            images = ofd.FileNames.ToList<string>();
            ofd.Dispose();
            
            return images;

        }

        internal void OnFactorChanged( double factor)
        {
            this.factor = factor;
        }



        #region Resize
        public void OnViewFileListClear()
        {
            images.Clear();
            view.OnViewFileListClear();
        }


        public void OnResizeClicked()
        {
            ResizeModel resizemdl = new ResizeModel(images, savePath,factor);
             resizemdl.ResizePictures();
            OnViewFileListClear();
      
        }

        public void OnChangeResizeLength(Int32 length)
        {
            heigth = length;
        }

        public void OnChangeResizeWidth(Int32 width)
        {
            this.width = width;
        }

        #endregion

    }
}
