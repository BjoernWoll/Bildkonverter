using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converter;
using Converter.View;
using Converter.Presenter;
namespace Converter.View
{
    public partial class ConverterView : Form
    {
      //  public MainPresenter Presenter { get; set; }
      public Presenter.Presenter Presenter { get; set; }
        public ConverterView()
        {
            InitializeComponent();
        }

        private void ConverterView_Load(object sender, EventArgs e)
        {
            
        }

    

        private void txtSaveFilePath_Click(object sender, EventArgs e)
        {
            Presenter.OnSaveImageFilePathClicked();
        }

        private void txtOpenImages_Click(object sender, EventArgs e)
        {
            Presenter.OnOpenImagesclicked();
        }



        public void UpdateView(List<string> openImages, string saveFilePath)
        {
           
           
           lbImages.Items.Clear();
            foreach(string image in openImages)
                lbImages.Items.Add(image);
           
        }

        public void UpdateSavePath(string dir)
        {
            txtSaveFilePath.Text = dir;
        }

        private void lbImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Presenter.OnConvertClicked();
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            Presenter.OnDeleteListClicked();
        }

        private void txtSaveFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBmp_CheckStateChanged(object sender, EventArgs e)
        {
            Presenter.OnBmpChanged(cbBmp.Checked);
        }

        private void cbPng_CheckedStateChanged(object sender, EventArgs e)
        {
            Presenter.OnPngChanged(cbPng.Checked);
        }

        private void cbJpg_CheckStateChanged(object sender, EventArgs e)
        {
            Presenter.OnJpgChanged(cbJpg.Checked);
        }

        private void cbTiff_CheckStateChanged(object sender, EventArgs e)
        {
            Presenter.OnTiffChanged(cbTiff.Checked);
        }

        private void cbIcon_CheckStateChanged(object sender, EventArgs e)
        {
            Presenter.OnIconChanged(cbIcon.Checked);
        }

        private void cbGif_CheckStateChanged(object sender, EventArgs e)
        {
            Presenter.OnGifChanged(cbGif.Checked);
        }

       

        private void btnResize_Click(object sender, EventArgs e)
        {
           
            Presenter.OnResizeClicked();
        }

        private void tbFactor_ValueChanged(object sender, EventArgs e)
        {
            double test = (double)tbFactor.Value;

            Presenter.OnFactorChanged((double)tbFactor.Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConverterView_Load_1(object sender, EventArgs e)
        {

        }

        internal void OnViewFileListClear()
        {
            lbImages.Items.Clear();
        }
    }
}
