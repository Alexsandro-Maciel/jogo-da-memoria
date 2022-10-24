using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jogo_da_memoria
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EsconderCartas();
            PosicionarCartas();
        }

        int posicao = 0;

        public void Random()
        {
            Random random = new Random();
            posicao = random.Next(1, 3);
        }

        string imgCorneta = "C:/Users/alexs/Downloads/corneta.jpg";
        string imgSpotify = "C:/Users/alexs/Downloads/spotify.png";
        string imgOperaGX = "C:/Users/alexs/Downloads/operagx.png";
        string imgCSharp = "C:/Users/alexs/Downloads/c#.png";

        int contadorErros = 0;

        int contadorAcertos = 0;

        bool acabou = false;

        int contadorCliques = 0;

        int contadorTentativas = 0;

        int primeiraCarta = 0;
        int segundaCarta = 0;

        Task task;
        CancellationToken cancellationToken;
        CancellationTokenSource tokenSource;

        public void IniciaTaskContagem()
        {
            tokenSource = new CancellationTokenSource();
            cancellationToken = tokenSource.Token;
            task = IniciaContagem(tokenSource.Token);
        }

        public async Task IniciaContagem(CancellationToken token)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }
                await Task.Delay(3000);
                txtTrava.Visibility = Visibility.Hidden;
                EsconderCartasErradas();
                PararTask();
            }
        }

        public void TestarErro()
        {
            switch (posicao)
            {
                case 1:
                    if (primeiraCarta == 1 && segundaCarta != 6 || primeiraCarta == 6 && segundaCarta != 1)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 3 && segundaCarta != 8 || primeiraCarta == 8 && segundaCarta != 3)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 7 && segundaCarta != 4 || primeiraCarta == 4 && segundaCarta != 7)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 5 && segundaCarta != 2 || primeiraCarta == 2 && segundaCarta != 5)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    break;

                case 2:
                    if (primeiraCarta == 1 && segundaCarta != 3 || primeiraCarta == 3 && segundaCarta != 1)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 5 && segundaCarta != 8 || primeiraCarta == 8 && segundaCarta != 5)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 7 && segundaCarta != 4 || primeiraCarta == 4 && segundaCarta != 7)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 6 && segundaCarta != 2 || primeiraCarta == 2 && segundaCarta != 6)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    break;

                case 3:
                    if (primeiraCarta == 1 && segundaCarta != 8 || primeiraCarta == 8 && segundaCarta != 1)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 3 && segundaCarta != 6 || primeiraCarta == 6 && segundaCarta != 3)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 5 && segundaCarta != 4 || primeiraCarta == 4 && segundaCarta != 5)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    else if (primeiraCarta == 7 && segundaCarta != 2 || primeiraCarta == 2 && segundaCarta != 7)
                    {
                        contadorErros++;
                        txtQuantidadeErros.Text = contadorErros.ToString();
                        Contar3Segundos();
                    }

                    break;
            }
        }

        public void Contar3Segundos()
        {
            IniciaTaskContagem();
        }

        public void PararTask()
        {
            tokenSource.Cancel();
            tokenSource.Dispose();
        }

        public void TestarAcerto()
        {
            switch (posicao)
            {
                case 1:
                    if (primeiraCarta == 1 && segundaCarta == 6 || primeiraCarta == 6 && segundaCarta == 1)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 3 && segundaCarta == 8 || primeiraCarta == 8 && segundaCarta == 3)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 7 && segundaCarta == 4 || primeiraCarta == 4 && segundaCarta == 7)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 5 && segundaCarta == 2 || primeiraCarta == 2 && segundaCarta == 5)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    break;

                case 2:
                    if (primeiraCarta == 1 && segundaCarta == 3 || primeiraCarta == 3 && segundaCarta == 1)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 5 && segundaCarta == 8 || primeiraCarta == 8 && segundaCarta == 5)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 7 && segundaCarta == 4 || primeiraCarta == 4 && segundaCarta == 7)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 6 && segundaCarta == 2 || primeiraCarta == 2 && segundaCarta == 6)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    break;

                case 3:
                    if (primeiraCarta == 1 && segundaCarta == 8 || primeiraCarta == 8 && segundaCarta == 1)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 3 && segundaCarta == 6 || primeiraCarta == 6 && segundaCarta == 3)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 5 && segundaCarta == 4 || primeiraCarta == 4 && segundaCarta == 5)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    else if (primeiraCarta == 7 && segundaCarta == 2 || primeiraCarta == 2 && segundaCarta == 7)
                    {
                        contadorAcertos++;
                        txtTrava.Visibility = Visibility.Hidden;
                    }

                    break;
            }
        }

        public void TestarFimJogo()
        {
            acabou  = (contadorAcertos == 4) ? true : false;
            if (acabou == true)
            {
                AparecerMensagem();
                txtTrava.Visibility=Visibility.Visible;
            }
        }

        private void IniciarNovoJogo(object sender, RoutedEventArgs e)
        {
            txtQuantidadeErros.Text = "0";
            txtTrava.Visibility = Visibility.Hidden;
            EsconderCartas();
            posicao = 0;
            PosicionarCartas();
            contadorErros = 0;
            contadorCliques = 0;
            contadorTentativas = 0;
            contadorAcertos = 0;
            primeiraCarta = 0;
            segundaCarta = 0;
            acabou = false;
        }

        public void EsconderCartas()
        {
            imgCarta1Aberta.Visibility = Visibility.Hidden;
            imgCarta2Aberta.Visibility = Visibility.Hidden;
            imgCarta3Aberta.Visibility = Visibility.Hidden;
            imgCarta4Aberta.Visibility = Visibility.Hidden;
            imgCarta5Aberta.Visibility = Visibility.Hidden;
            imgCarta6Aberta.Visibility = Visibility.Hidden;
            imgCarta7Aberta.Visibility = Visibility.Hidden;
            imgCarta8Aberta.Visibility = Visibility.Hidden;

            imgCarta1Fechada.Visibility = Visibility.Visible;
            imgCarta2Fechada.Visibility = Visibility.Visible;
            imgCarta3Fechada.Visibility = Visibility.Visible;
            imgCarta4Fechada.Visibility = Visibility.Visible;
            imgCarta5Fechada.Visibility = Visibility.Visible;
            imgCarta6Fechada.Visibility = Visibility.Visible;
            imgCarta7Fechada.Visibility = Visibility.Visible;
            imgCarta8Fechada.Visibility = Visibility.Visible;
        }

        public void EsconderCartasErradas()
        {
            switch (primeiraCarta)
            {
                case 1:
                    imgCarta1Aberta.Visibility = Visibility.Hidden;
                    imgCarta1Fechada.Visibility = Visibility.Visible;

                    break;

                case 2:
                    imgCarta2Aberta.Visibility = Visibility.Hidden;
                    imgCarta2Fechada.Visibility = Visibility.Visible;

                    break;

                case 3:
                    imgCarta3Aberta.Visibility = Visibility.Hidden;
                    imgCarta3Fechada.Visibility = Visibility.Visible;

                    break;

                case 4:
                    imgCarta4Aberta.Visibility = Visibility.Hidden;
                    imgCarta4Fechada.Visibility = Visibility.Visible;

                    break;

                case 5:
                    imgCarta5Aberta.Visibility = Visibility.Hidden;
                    imgCarta5Fechada.Visibility = Visibility.Visible;

                    break;

                case 6:
                    imgCarta6Aberta.Visibility = Visibility.Hidden;
                    imgCarta6Fechada.Visibility = Visibility.Visible;

                    break;

                case 7:
                    imgCarta7Aberta.Visibility = Visibility.Hidden;
                    imgCarta7Fechada.Visibility = Visibility.Visible;

                    break;

                case 8:
                    imgCarta8Aberta.Visibility = Visibility.Hidden;
                    imgCarta8Fechada.Visibility = Visibility.Visible;

                    break;
            }

            switch (segundaCarta)
            {
                case 1:
                    imgCarta1Aberta.Visibility = Visibility.Hidden;
                    imgCarta1Fechada.Visibility = Visibility.Visible;

                    break;

                case 2:
                    imgCarta2Aberta.Visibility = Visibility.Hidden;
                    imgCarta2Fechada.Visibility = Visibility.Visible;

                    break;

                case 3:
                    imgCarta3Aberta.Visibility = Visibility.Hidden;
                    imgCarta3Fechada.Visibility = Visibility.Visible;

                    break;

                case 4:
                    imgCarta4Aberta.Visibility = Visibility.Hidden;
                    imgCarta4Fechada.Visibility = Visibility.Visible;

                    break;

                case 5:
                    imgCarta5Aberta.Visibility = Visibility.Hidden;
                    imgCarta5Fechada.Visibility = Visibility.Visible;

                    break;

                case 6:
                    imgCarta6Aberta.Visibility = Visibility.Hidden;
                    imgCarta6Fechada.Visibility = Visibility.Visible;

                    break;

                case 7:
                    imgCarta7Aberta.Visibility = Visibility.Hidden;
                    imgCarta7Fechada.Visibility = Visibility.Visible;

                    break;

                case 8:
                    imgCarta8Aberta.Visibility = Visibility.Hidden;
                    imgCarta8Fechada.Visibility = Visibility.Visible;

                    break;
            }
        }

        public void PosicionarCartas()
        {
            Random();
            switch (posicao)
            {
                case 1:
                    imgCarta1Aberta.Source = new BitmapImage(new Uri($"{imgCorneta}"));
                    imgCarta6Aberta.Source = new BitmapImage(new Uri($"{imgCorneta}"));

                    imgCarta3Aberta.Source = new BitmapImage(new Uri($"{imgCSharp}"));
                    imgCarta8Aberta.Source = new BitmapImage(new Uri($"{imgCSharp}"));

                    imgCarta7Aberta.Source = new BitmapImage(new Uri($"{imgSpotify}"));
                    imgCarta4Aberta.Source = new BitmapImage(new Uri($"{imgSpotify}"));

                    imgCarta5Aberta.Source = new BitmapImage(new Uri($"{imgOperaGX}"));
                    imgCarta2Aberta.Source = new BitmapImage(new Uri($"{imgOperaGX}"));

                    break;

                case 2:
                    imgCarta4Aberta.Source = new BitmapImage(new Uri($"{imgCorneta}"));
                    imgCarta7Aberta.Source = new BitmapImage(new Uri($"{imgCorneta}"));

                    imgCarta1Aberta.Source = new BitmapImage(new Uri($"{imgCSharp}"));
                    imgCarta3Aberta.Source = new BitmapImage(new Uri($"{imgCSharp}"));

                    imgCarta5Aberta.Source = new BitmapImage(new Uri($"{imgSpotify}"));
                    imgCarta8Aberta.Source = new BitmapImage(new Uri($"{imgSpotify}"));

                    imgCarta6Aberta.Source = new BitmapImage(new Uri($"{imgOperaGX}"));
                    imgCarta2Aberta.Source = new BitmapImage(new Uri($"{imgOperaGX}"));

                    break;

                case 3:
                    imgCarta8Aberta.Source = new BitmapImage(new Uri($"{imgCorneta}"));
                    imgCarta1Aberta.Source = new BitmapImage(new Uri($"{imgCorneta}"));

                    imgCarta7Aberta.Source = new BitmapImage(new Uri($"{imgCSharp}"));
                    imgCarta2Aberta.Source = new BitmapImage(new Uri($"{imgCSharp}"));

                    imgCarta6Aberta.Source = new BitmapImage(new Uri($"{imgSpotify}"));
                    imgCarta3Aberta.Source = new BitmapImage(new Uri($"{imgSpotify}"));

                    imgCarta5Aberta.Source = new BitmapImage(new Uri($"{imgOperaGX}"));
                    imgCarta4Aberta.Source = new BitmapImage(new Uri($"{imgOperaGX}"));

                    break;
            }
        }

        public void AparecerMensagem()
        {
            txtTrava.Visibility = Visibility.Visible;
            retPopUp.Visibility = Visibility.Visible;
            imgCongrats.Visibility = Visibility.Visible;
            imgOK.Visibility = Visibility.Visible;
            txtYouWin.Visibility = Visibility.Visible;
            txtMensagem.Visibility = Visibility.Visible;

            txtMensagem.Text = $"Você terminou o jogo com {Aproveitamento().ToString("F")}% de aproveitamento. Parabéns!";

        }

        public float Aproveitamento()
        {
            float aproveitamento = 100;

            float erros = ((float)contadorErros / (float)contadorTentativas) * 100f;

            aproveitamento = aproveitamento - erros;

            return aproveitamento;
        }

        private void FecharPopUp(object sender, MouseButtonEventArgs e)
        {
            txtTrava.Visibility = Visibility.Hidden;
            retPopUp.Visibility = Visibility.Hidden;
            imgCongrats.Visibility = Visibility.Hidden;
            imgOK.Visibility = Visibility.Hidden;
            txtYouWin.Visibility = Visibility.Hidden;
            txtMensagem.Visibility = Visibility.Hidden;
        }

        private void Carta1Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta1Aberta.Visibility = Visibility.Visible;
            imgCarta1Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 1;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 1;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void Carta2Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta2Aberta.Visibility = Visibility.Visible;
            imgCarta2Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 2;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 2;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void Carta3Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta3Aberta.Visibility = Visibility.Visible;
            imgCarta3Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 3;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 3;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void Carta4Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta4Aberta.Visibility = Visibility.Visible;
            imgCarta4Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 4;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 4;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void Carta5Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta5Aberta.Visibility = Visibility.Visible;
            imgCarta5Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 5;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 5;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void Carta6Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta6Aberta.Visibility = Visibility.Visible;
            imgCarta6Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 6;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 6;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void Carta7Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta7Aberta.Visibility = Visibility.Visible;
            imgCarta7Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 7;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 7;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void Carta8Selecionada(object sender, MouseButtonEventArgs e)
        {
            imgCarta8Aberta.Visibility = Visibility.Visible;
            imgCarta8Fechada.Visibility = Visibility.Hidden;
            contadorCliques++;
            if (contadorCliques == 1)
            {
                primeiraCarta = 8;
            }

            else if (contadorCliques == 2)
            {
                segundaCarta = 8;
                txtTrava.Visibility = Visibility.Visible;
                contadorCliques = 0;
                TestarAcerto();
                TestarErro();
                contadorTentativas++;
                TestarFimJogo();
            }
        }

        private void FecharTela(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
