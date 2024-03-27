using exepciones;
using objetos;

namespace RuletaDel_Infortunio
{
    public partial class FrmRuleta : Form
    {
        private int index;
        private int numeroSaliente;
        private int creditos;
        private int tiempoApuesta;
        internal bool imagenElegida;
        private int valorFicha;
        private int valorApuesta;
        private bool ganador;
        internal List<Numeros> numeros;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer tiempo;
        private List<Image> imagenesElegidas;
        private List<Image> imagenes;
        private List<Image> fichasElegidas;
        private List<Image> fichas;
        private List<PictureBox> pictureBoxes;
        public FrmRuleta()
        {
            InitializeComponent();
            this.numeroSaliente = 0;
            this.valorApuesta = 0;
            this.valorFicha = 100;
            this.creditos = 4000;
            this.tiempoApuesta = 15;
            this.ganador = false;
            this.imagenElegida = false;
            this.fichas = new List<Image>();
            this.imagenes = new List<Image>();
            this.fichasElegidas = new List<Image>();
            this.imagenesElegidas = new List<Image>();
            this.timer = new System.Windows.Forms.Timer();
            this.tiempo = new System.Windows.Forms.Timer();
            this.pictureBoxes = this.CrearListaPicturebox();
            this.CargarImagenes();
            this.CargarFichas();
        }

        private void FrmRuleta_Load_1(object sender, EventArgs e)
        {
            this.ManejarTiempo();
        }
        private void CargarImagenes()
        {
            for (int i = 0; i < 37; i++)
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + $"numeros_elegidos\\{i}_elegido.png";
                this.imagenesElegidas.Add(Image.FromFile(ruta));
            }
        }
        #region Eventos Picturebox

        private void Pb0_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb0, 0, "verde");
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
        }
        private void Pb36_Click(object sender, EventArgs e)
        {
            this.AsignarNumero(this.Pb36, 36, "rojo");
        }
        internal void AsignarNumero(PictureBox pb, int numero, string color)
        {
            pb.Image = imagenesElegidas[numero];
            Numeros num = new Numeros(color, 37, numero);
            int numAleatorio = GenerarNumero([numero]);
            this.valorApuesta = num.valor;
            if(num.numero == numAleatorio)
            {
                this.ganador = true;
                creditos += this.valorApuesta;
            }
            else
            {
                this.ganador = false;
                creditos -= this.valorFicha;
            }
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
            for (int i = 0; i < 37; i++)
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + $"numeros\\{i}.png";
                pictureBoxes[i].Image = Image.FromFile(ruta);

            }
        }
        internal void Animar()
        {
            this.LimpiarPicturebox();
            this.index = 0;
            this.timer.Interval = 100;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.index < pictureBoxes.Count)
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
                // bucle principal
                timer.Stop();
                this.LimpiarPicturebox();
                this.LimpiarPerifericos();
                timer.Stop();
                int indice = this.EncontrarPicturebox(this.numeroSaliente);
                pictureBoxes[this.numeroSaliente].Image = this.imagenesElegidas[this.numeroSaliente];
                if (ganador)
                {
                    int ganancia = valorApuesta * valorFicha;
                    this.creditos += ganancia;
                    this.LblValorFicha.Text = $"ganaste {ganancia} creditos";
                }
                else
                {
                    this.creditos -= valorFicha;
                }
                LblCreditoDisponibles.Text = $"tienes {this.creditos} creditos";
                
            }
        }
        private void tiempo_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = tiempoApuesta.ToString();
            tiempoApuesta--;
            if (tiempoApuesta == 0)
            {
                tiempo.Stop();
                this.Animar();
                this.tiempoApuesta = 15;
                this.tiempo.Start();
            }
        }
        private void ManejarTiempo()
        {
            this.tiempo.Interval = 1000;
            tiempo.Tick += tiempo_Tick;
            tiempo.Start();
        }
        #endregion

        #region encontrar numero
        private int EncontrarPicturebox(int? num)
        {
            for (int i = 0; i < this.pictureBoxes.Count; i++)
            {
                if ($"pb{num}" == this.pictureBoxes[i].Name.ToString().ToLower())
                {
                    return i; 
                }
            }
            return 0;
        }
        private int GenerarNumero(List<int> ListaNumeros)
        {
            Random rnd = new Random();
            while (true)
            {
                int numeroAleatorio = rnd.Next(0, 37);
                if (this.EncontrarNumero(ListaNumeros, numeroAleatorio) == false)
                {
                    return numeroAleatorio;
                }
            }
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

        #region Eventos perifericos
        private void PbNegro_Click(object sender, EventArgs e)
        {
            PbPeriferico4.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\rombo_negro_elegido.png");
            Periferia RomboNegro = new Periferia("rombo", 48, "negro");
            this.numeroSaliente = this.GenerarNumero(RomboNegro.ObtenerNumeros());
            if (this.EncontrarNumero(RomboNegro.negro, this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = RomboNegro.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void PbRojo_Click(object sender, EventArgs e)
        {
            PbPeriferico5.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\rombo_rojo_elegido.png");
            Periferia Romborojo = new Periferia("rombo", 48, "rojo");
            this.numeroSaliente = this.GenerarNumero(Romborojo.ObtenerNumeros());
            if (this.EncontrarNumero(Romborojo.rojo, this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = Romborojo.valor;
            }
            else
            {
                this.ganador = false;
                this.valorApuesta = 0;
            }
        }
        private void Pb1Docena_Click(object sender, EventArgs e)
        {
            PbPeriferico1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\1ra_docena_elegida.png");
            Periferia primeraDoc = new Periferia("1ra Docena", 12);
            this.numeroSaliente = this.GenerarNumero(primeraDoc.ObtenerNumeros());
            if (this.EncontrarNumero(primeraDoc.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = primeraDoc.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void Pb2Docena_Click(object sender, EventArgs e)
        {
            PbPeriferico2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\2da_docena_elegida.png");
            Periferia segundaDoc = new Periferia("2da Docena", 12);
            this.numeroSaliente = this.GenerarNumero(segundaDoc.ObtenerNumeros());
            if (this.EncontrarNumero(segundaDoc.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = segundaDoc.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void Pb3Docena_Click(object sender, EventArgs e)
        {
            PbPeriferico3.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\3ra_docena_elegida.png");
            Periferia terceraDoc = new Periferia("3ra Docena", 12);
            this.numeroSaliente = this.GenerarNumero(terceraDoc.ObtenerNumeros());
            if (this.EncontrarNumero(terceraDoc.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = terceraDoc.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void PbPares_Click(object sender, EventArgs e)
        {

            PbPeriferico7.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\pares_elegido.png");
            Periferia pares = new Periferia("pares", 18);
            this.numeroSaliente = this.GenerarNumero(pares.ObtenerNumeros());
            if (this.EncontrarNumero(pares.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = pares.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void PbImpares_Click(object sender, EventArgs e)
        {
            PbPeriferico6.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\impares_elegido.png");
            Periferia impares = new Periferia("impares", 18);
            this.numeroSaliente = this.GenerarNumero(impares.ObtenerNumeros());
            if (this.EncontrarNumero(impares.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = impares.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void Pb1raFila_Click(object sender, EventArgs e)
        {
            PbPeriferico8.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\1_fila_elegida.png");
            Periferia primeraFila = new Periferia("1ra linea", 12);
            this.numeroSaliente = this.GenerarNumero(primeraFila.ObtenerNumeros());
            if (this.EncontrarNumero(primeraFila.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = primeraFila.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void Pb2daFila_Click(object sender, EventArgs e)
        {
            PbPeriferico9.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\2_fila_elegida.png");
            Periferia segundaFila = new Periferia("2da linea", 12);
            this.numeroSaliente = this.GenerarNumero(segundaFila.ObtenerNumeros());
            if (this.EncontrarNumero(segundaFila.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = segundaFila.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        private void Pb3Fila_Click(object sender, EventArgs e)
        {
            PbPeriferico10.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos_elegidos\\3_fila_elegida.png");
            Periferia terceraFila = new Periferia("3ra linea", 12);
            this.numeroSaliente = this.GenerarNumero(terceraFila.ObtenerNumeros());
            if (this.EncontrarNumero(terceraFila.ObtenerNumeros(), this.numeroSaliente))
            {
                this.ganador = true;
                this.valorApuesta = terceraFila.valor;
            }
            else
            {
                this.valorApuesta = 0;
                this.ganador = false;
            }
        }
        public void LimpiarPerifericos()
        {
            for(int i = 1; i < 11; i++)
            {
                PictureBox pictureBox = (PictureBox)this.Controls.Find($"PbPeriferico{i}", true)[0];
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"perifericos\\Periferico_{i}.png");
            }
        }
        #endregion

        #region cambiar fichas
        private void PbFichaRoja_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.creditos < 100)
                {
                    throw new FichasInsuficientesExepcion(this.creditos, this.valorFicha);
                }
                this.OrdenarFichas();
                PbFicha1.Image = this.fichasElegidas[0];
                this.valorFicha = 100;
                this.LblValorFicha.Text = $"valor de ficha: {this.valorFicha}";
            }
            catch (FichasInsuficientesExepcion ex)
            {
                this.LblCreditoDisponibles.Text = ex.Message;
            }
        }
        private void PbFichaAzul_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.creditos < 200)
                {
                    throw new FichasInsuficientesExepcion(this.creditos, this.valorFicha);
                }
                this.OrdenarFichas();
                PbFicha2.Image = this.fichasElegidas[1];
                this.valorFicha = 200;
                this.LblValorFicha.Text = $"valor de ficha: {this.valorFicha}";
            }
            catch (FichasInsuficientesExepcion ex)
            {
                this.LblCreditoDisponibles.Text = ex.Message;
            }
        }
        private void PbFichaVerde_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.creditos < 500)
                {
                    throw new FichasInsuficientesExepcion(this.creditos, this.valorFicha);
                }
                this.OrdenarFichas();
                PbFicha3.Image = this.fichasElegidas[2];
                this.valorFicha = 500;
                this.LblValorFicha.Text = $"valor de ficha: {this.valorFicha}";
            }
            catch (FichasInsuficientesExepcion ex)
            {
                this.LblCreditoDisponibles.Text = ex.Message;
            }
        }
        private void PbFichaVioleta_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.creditos < 1000)
                {
                    throw new FichasInsuficientesExepcion(this.creditos, this.valorFicha);
                }
                this.OrdenarFichas();
                PbFicha4.Image = this.fichasElegidas[3];
                this.valorFicha = 1000;
                this.LblValorFicha.Text = $"valor de ficha: {this.valorFicha}";
            }
            catch (FichasInsuficientesExepcion ex)
            {
                this.LblCreditoDisponibles.Text = ex.Message;
            }
        }
        private void OrdenarFichas()
        {
            PbFicha1.Image = this.fichas[0];
            PbFicha2.Image = this.fichas[1];
            PbFicha3.Image = this.fichas[2];
            PbFicha4.Image = this.fichas[3];
        }
        private void CargarFichas()
        {
            this.fichasElegidas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_roja_elegida.png"));
            this.fichasElegidas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_azul_elegida.png"));
            this.fichasElegidas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_verde_elegida.png"));
            this.fichasElegidas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_violeta_elegida.png"));
            // no elegidas
            this.fichas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_roja.png"));
            this.fichas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_azul.png"));
            this.fichas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_verde.png"));
            this.fichas.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + $"fichas\\ficha_violeta.png"));
        }
        #endregion

        public void CancelarApuesta()
        {
            this.LimpiarPerifericos();
            this.LimpiarPicturebox();
            if(this.creditos < 0)
            {
                this.creditos = 0;
            }
        }
    }
}
