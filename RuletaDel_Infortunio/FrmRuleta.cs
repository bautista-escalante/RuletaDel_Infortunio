using objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RuletaDel_Infortunio
{
    public partial class FrmRuleta : Form
    {
        private int index;
        internal bool imagenElegida;
        internal List<Numeros> numeros;
        private System.Windows.Forms.Timer timer;
        private List<Image> imagenesElegidas;
        private List<Image> imagenes;
        private List<PictureBox> pictureBoxes;
        public FrmRuleta()
        {
            this.imagenes = new List<Image>();
            this.imagenesElegidas = new List<Image>();
            this.CargarImagenes();
            InitializeComponent();
            this.pictureBoxes = this.CrearListaPicturebox();
            this.imagenElegida = false;
        }

        private void FrmRuleta_Load_1(object sender, EventArgs e)
        {

        }
        private void CargarImagenes()
        {
            for (int i = 0; i < 37; i++)
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + $"\\numeros_elegidos\\{i}_elegido.png";
                this.imagenesElegidas.Add(Image.FromFile(ruta));
            }
        }
        #region Eventos Picturebox

        private void Pb0_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb0,0,"verde");
        }
        private void Pb1_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb1, 1, "rojo");
        }
        private void Pb2_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb2, 2, "negro");
        }
        private void Pb3_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb3, 3, "rojo");
        }
        private void Pb4_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb4, 4, "negro");
        }
        private void Pb5_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb5, 5, "rojo");
        }
        private void Pb6_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb6, 6, "negro");
        }
        private void Pb7_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb7, 7, "rojo");
        }

        private void Pb8_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb8, 8, "negro");
        }
        private void Pb9_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb9, 9, "rojo");
        }
        private void Pb10_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb10, 10, "negro");
        }
        private void Pb11_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb11, 11, "negro");
        }
        private void Pb12_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb12, 12, "rojo");
        }
        private void Pb13_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb13, 13, "negro");
        }
        private void Pb14_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb14, 14, "rojo");
        }
        private void Pb15_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb15, 15, "negro");
        }
        private void Pb16_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb16, 16, "rojo");
        }
        private void Pb17_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb17, 17, "negro");
        }
        private void Pb18_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb18, 18, "rojo");
        }
        private void Pb19_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb19, 19, "rojo");
        }
        private void Pb20_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb20, 20, "negro");
        }
        private void pb21_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.pb21, 21, "rojo");
        }
        private void Pb22_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb22, 22, "negro");
        }
        private void Pb23_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb23, 23, "rojo");
        }
        private void Pb24_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb24, 24, "negro");
        }
        private void Pb25_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb25, 25, "rojo");
        }
        private void Pb26_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb26, 26, "negro");
        }
        private void Pb27_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb27, 27, "rojo");
        }
        private void Pb28_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb28, 28, "negro");
        }
        private void Pb29_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb29, 29, "negro");
        }
        private void Pb30_Click(object sender, EventArgs e)
        {

            this.AsignarNumero(this.Pb30, 30, "rojo");
        }
        private void Pb31_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb31, 31, "negro");
        }
        private void Pb32_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb32, 32, "rojo");
        }
        private void Pb33_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb33, 33, "negro");
        }
        private void Pb34_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb34, 34, "rojo");
        }
        private void Pb35_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb35, 35, "negro");
            this.EncontrarPicturebox(22);
        }
        private void Pb36_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb36, 36, "rojo");
            this.EncontrarPicturebox(22);
            this.Animar();
        }
        internal void AsignarNumero(PictureBox pb, int numero,string color)
        {
            pb.Image = imagenesElegidas[numero];
            Numeros num = new Numeros(color, 37, numero);
        }
        #endregion

        #region animacion
        internal List<PictureBox> CrearListaPicturebox()
        {
            List<PictureBox> lista = new List<PictureBox>();
            for (int i = 0; i <= 36; i++)
            {
                PictureBox pictureBox = (PictureBox)this.Controls.Find("Pb" + i, true)[0];
                lista.Add(pictureBox);
            }
            return lista;
        }
        internal void LimpiarPicturebox()
        {
            // en todos los picture boxes mostrar los nmeros sin cuadrados verdes
            for (int i = 0; i < 37; i++)
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + $"numeros\\{i}.png";
                imagenes.Add(Image.FromFile(ruta));

            }
            for (int i = 0; i < this.pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Image = this.imagenes[i];
            }
        }
        internal void Animar()
        {
            this.timer = new System.Windows.Forms.Timer();
            this.LimpiarPicturebox();
            this.index = 0;
            this.timer.Interval = 60;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (index < pictureBoxes.Count)
            {
                if (imagenElegida)
                {
                    // Cambiar a la imagen a "sin elegir"
                    this.LimpiarPicturebox();
                    pictureBoxes[this.index].Image = this.imagenesElegidas[this.index];
                    imagenElegida = false;
                }
                else
                {
                    // Cambiar a la imagen a "elegida"
                    pictureBoxes[this.index].Image = this.imagenesElegidas[this.index];
                    imagenElegida = true;

                }
                index++;
            }
            else
            {
                timer.Stop(); 
                this.LimpiarPicturebox();
            }
        }
        #endregion

        #region encontrar numero
        // en perifericos this.encontrarPicturebox(generarNumero())
        private void EncontrarPicturebox(int num)
        {
            int numero = this.GenerarNumero([num]);
            for(int i = 0; i < this.pictureBoxes.Count; i++)
            {
                if ($"pb{numero}" == this.pictureBoxes[i].Name.ToString().ToLower())
                {
                    pictureBoxes[i].Image = this.imagenesElegidas[i];
                    break;
                }
            }
            
        }
        private int GenerarNumero(List<int> ListaNumeros)
        {
            int numero = 0;
           Random rnd = new Random();
            while (true)
            {
                int numeroAleatorio = rnd.Next(0, 37);
                if (this.EncontrarNumero(ListaNumeros, numeroAleatorio) == false)
                {
                    numero = numeroAleatorio;
                    break;
                }
            }
                return numero;
        }
        private bool EncontrarNumero(List<int> ListaNumeros, int num)
        {
            bool encontrado = false;

            for (int i = 0; i < ListaNumeros.Count; i++)
            {
                if (num == ListaNumeros[i])
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }
        #endregion
    }
}
