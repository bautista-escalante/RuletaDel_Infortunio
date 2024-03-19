using System.Windows.Forms;

namespace RuletaDel_Infortunio
{
    public partial class FrmRuleta : Form
    {
        private List<Image> imagenes;
        public FrmRuleta()
        {
            this.imagenes = new List<Image>();
            this.CargarImagenes();
            InitializeComponent();
        }

        private void FrmRuleta_Load_1(object sender, EventArgs e)
        {

        }
        private void CargarImagenes()
        {
            for (int i = 0; i <= 37; i++)
            {
                string nombreImagen = AppDomain.CurrentDomain.BaseDirectory + $"\\numeros_elegidos\\{i}_marcado.jpg";
                imagenes.Add(Image.FromFile(nombreImagen));
            }
        }
        #region Eventos Picturebox
        private void Pb0_Click(object sender, EventArgs e)
        {
            this.Pb0.Image = imagenes[0];
        }
        private void Pb1_Click(object sender, EventArgs e)
        {
            this.Pb1.Image = imagenes[1];
        }

        private void Pb2_Click(object sender, EventArgs e)
        {
            this.Pb2.Image = imagenes[2];
        }

        private void Pb3_Click(object sender, EventArgs e)
        {
            this.Pb3.Image = imagenes[3];
        }

        private void Pb4_Click(object sender, EventArgs e)
        {
            this.Pb4.Image = imagenes[4];
        }
        private void Pb5_Click(object sender, EventArgs e)
        {
            this.Pb5.Image = imagenes[5];
        }
        private void Pb6_Click(object sender, EventArgs e)
        {
            this.Pb6.Image = imagenes[6];
        }
        private void Pb7_Click(object sender, EventArgs e)
        {
            this.Pb7.Image = imagenes[7];
        }

        private void Pb8_Click(object sender, EventArgs e)
        {
            this.Pb8.Image = imagenes[8];
        }
        private void Pb9_Click(object sender, EventArgs e)
        {
            this.Pb9.Image = imagenes[9];
        }
        private void Pb10_Click(object sender, EventArgs e)
        {
            this.Pb10.Image = imagenes[10];
        }
        private void Pb11_Click(object sender, EventArgs e)
        {
            this.Pb11.Image = imagenes[11];
        }
        private void Pb12_Click(object sender, EventArgs e)
        {
            this.Pb12.Image = imagenes[12];
        }
        private void Pb13_Click(object sender, EventArgs e)
        {
            this.Pb13.Image = imagenes[13];
        }
        private void Pb14_Click(object sender, EventArgs e)
        {
            this.Pb14.Image = imagenes[14];
        }
        private void Pb15_Click(object sender, EventArgs e)
        {
            this.Pb15.Image = imagenes[15];
        }
        private void Pb16_Click(object sender, EventArgs e)
        {
            this.Pb16.Image = imagenes[16];
        }
        private void Pb17_Click(object sender, EventArgs e)
        {
            this.Pb17.Image = imagenes[17];
        }

        private void Pb18_Click(object sender, EventArgs e)
        {
            this.Pb18.Image = imagenes[18];
        }
        private void Pb19_Click(object sender, EventArgs e)
        {
            this.Pb19.Image = imagenes[19];
        }
        private void Pb20_Click(object sender, EventArgs e)
        {
            this.Pb20.Image = imagenes[20];
        }
        private void pb21_Click(object sender, EventArgs e)
        {
            this.pb21.Image = imagenes[21];
        }
        private void Pb22_Click(object sender, EventArgs e)
        {
            this.Pb22.Image = imagenes[22];
        }
        private void Pb23_Click(object sender, EventArgs e)
        {
            this.Pb23.Image = imagenes[23];
        }
        private void Pb24_Click(object sender, EventArgs e)
        {
            this.Pb24.Image = imagenes[24];
        }
        private void Pb25_Click(object sender, EventArgs e)
        {
            this.Pb25.Image = imagenes[25];
        }
        private void Pb26_Click(object sender, EventArgs e)
        {
            this.Pb26.Image = imagenes[26];
        }
        private void Pb27_Click(object sender, EventArgs e)
        {
            this.Pb27.Image = imagenes[27];
        }
        private void Pb28_Click(object sender, EventArgs e)
        {
            this.Pb28.Image = imagenes[28];
        }
        private void Pb29_Click(object sender, EventArgs e)
        {
            this.Pb29.Image = imagenes[29];
        }
        private void Pb30_Click(object sender, EventArgs e)
        {

            this.Pb30.Image = imagenes[30];
        }
        private void Pb31_Click(object sender, EventArgs e)
        {
            this.Pb31.Image = imagenes[31];
        }
        private void Pb32_Click(object sender, EventArgs e)
        {
            this.Pb32.Image = imagenes[32];
        }
        private void Pb33_Click(object sender, EventArgs e)
        {
            this.Pb33.Image = imagenes[33];
        }
        private void Pb34_Click(object sender, EventArgs e)
        {
            this.Pb34.Image = imagenes[34];
        }
        private void Pb35_Click(object sender, EventArgs e)
        {
            this.Pb35.Image = imagenes[35];
        }
        private void Pb36_Click(object sender, EventArgs e)
        {
            this.Pb36.Image = imagenes[36];
        }
        #endregion

    }
}
