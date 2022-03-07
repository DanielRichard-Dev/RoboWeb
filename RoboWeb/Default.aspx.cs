using RoboModels.Constants;
using RoboModels.RoboEnum;
using RoboModels.RoboModels;
using RoboServices.RoboInterfaces;
using RoboServices.RoboServices;
using System;
using System.Web.UI;

namespace RoboWeb
{
    public partial class _Default : Page
    {
        private IRoboService<RoboApiModel> _roboService { get; set; }
        private RoboApiModel _robo { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _roboService = new RoboService<RoboApiModel>();
            _robo = new RoboApiModel();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                _robo = _roboService.GetApiRobo(ServicoApiRoboConstant.IniciarRobo);

                CarregarChecksRobo(_robo.Robo);
                LiberarPrimeiroChecksAlteracaoRobo();
            }
            else
            {
                _robo.Robo = CarregarRequestRobo();
            }

        }

        protected void checkECotoveloEmRepouso_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloEsquerdo();

            checkECotoveloLevementeContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoEsquerdoRepouso;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkECotoveloLevementeContraido_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloEsquerdo();

            checkECotoveloEmRepouso.Enabled = true;
            checkECotoveloContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoEsquerdoLevementeContraido;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkECotoveloContraido_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloEsquerdo();

            checkECotoveloLevementeContraido.Enabled = true;
            checkECotoveloFortementeContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoEsquerdoContraido;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkECotoveloFortementeContraido_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloEsquerdo();

            checkECotoveloContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoEsquerdoFormenteContraido;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkEPulsoRotacaoMenosNoventa_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoEsquerdo();

            checkECotoveloFortementeContraido.Enabled = true;
            checkEPulsoRotacaoMenosQuarentaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoMenosNoventa;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkEPulsoRotacaoMenosQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoEsquerdo();

            checkEPulsoRotacaoMenosNoventa.Enabled = true;
            checkEPulsoRepouso.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoMenosQuarentaCinco;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkEPulsoRepouso_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoEsquerdo();

            checkEPulsoRotacaoMenosQuarentaCinco.Enabled = true;
            checkEPulsoRotacaoQuarentaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRepouso;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkEPulsoRotacaoQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoEsquerdo();

            checkEPulsoRepouso.Enabled = true;
            checkEPulsoRotacaoNoventa.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoQuarentaCinco;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkEPulsoRotacaoNoventa_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoEsquerdo();

            checkEPulsoRotacaoQuarentaCinco.Enabled = true;
            checkEPulsoRotacaoCemTrintaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoNoventa;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkEPulsoRotacaoCemTrintaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoEsquerdo();

            checkEPulsoRotacaoNoventa.Enabled = true;
            checkEPulsoRotacaoCemOitenta.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoCemTrintaCinco;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkEPulsoRotacaoCemOitenta_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoEsquerdo();

            checkEPulsoRotacaoCemTrintaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoEsquerdoRotacaoCemOitenta;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDCotoveloEmRepouso_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloDireito();

            checkDCotoveloLevementeContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoDireitoRepouso;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDCotoveloLevementeContraido_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloDireito();

            checkDCotoveloEmRepouso.Enabled = true;
            checkDCotoveloContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoDireitoLevementeContraido;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDCotoveloContraido_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloDireito();

            checkDCotoveloLevementeContraido.Enabled = true;
            checkDCotoveloFortementeContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoDireitoContraido;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDCotoveloFortementeContraido_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoCotoveloDireito();

            checkDCotoveloContraido.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.BracoDireitoFormenteContraido;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDPulsoRotacaoMenosNoventa_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoDireito();

            checkDPulsoRotacaoMenosQuarentaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoMenosNoventa;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDPulsoRotacaoMenosQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoDireito();

            checkDPulsoRotacaoMenosNoventa.Enabled = true;
            checkDPulsoRepouso.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoMenosQuarentaCinco;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDPulsoRepouso_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoDireito();

            checkDPulsoRotacaoMenosQuarentaCinco.Enabled = true;
            checkDPulsoRotacaoQuarentaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoDireitoRepouso;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDPulsoRotacaoQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoDireito();

            checkDPulsoRepouso.Enabled = true;
            checkDPulsoRotacaoNoventa.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoQuarentaCinco;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDPulsoRotacaoNoventa_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoDireito();

            checkDPulsoRotacaoQuarentaCinco.Enabled = true;
            checkDPulsoRotacaoCemTrintaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoNoventa;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDPulsoRotacaoCemTrintaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoDireito();

            checkDPulsoRotacaoNoventa.Enabled = true;
            checkDPulsoRotacaoCemOitenta.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoCemTrintaCinco;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkDPulsoRotacaoCemOitenta_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckBracoPulsoDireito();

            checkDPulsoRotacaoCemTrintaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoBraco = RoboCodigoMovimentoBracoEnum.PulsoDireitoRotacaoCemOitenta;

            _robo = MovimentarBracoRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkCabecaRotacaoMenosNoventa_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckRotacaoCabeca();

            checkCabecaRotacaoMenosQuarentaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaRotacaoMenosNoventa;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkCabecaRotacaoMenosQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckRotacaoCabeca();

            checkCabecaRotacaoMenosNoventa.Enabled = true;
            checkCabecaRepouso.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaRotacaoMenosQuarentaCinco;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkCabecaRepouso_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckRotacaoCabeca();

            checkCabecaRotacaoMenosQuarentaCinco.Enabled = true;
            checkCabecaRotacaoQuarentaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaRotacaoRepouso;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkCabecaRotacaoQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckRotacaoCabeca();

            checkCabecaRepouso.Enabled = true;
            checkCabecaRotacaoNoventa.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaRotacaoQuarentaCinco;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkCabecaRotacaoNoventa_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckRotacaoCabeca();

            checkCabecaRotacaoQuarentaCinco.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaRotacaoNoventa;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkCabecaParaCima_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckInclinacaoCabeca();

            checkInclinacaoCabecaRepouso.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaInclinacaoCima;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkInclinacaoCabecaRepouso_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckInclinacaoCabeca();

            checkCabecaParaCima.Enabled = true;
            checkCabecaParaBaixo.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaInclinacaoRepouso;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        protected void checkCabecaParaBaixo_CheckedChanged(object sender, EventArgs e)
        {
            DesativarCheckInclinacaoCabeca();

            checkInclinacaoCabecaRepouso.Enabled = true;

            _robo.RoboCodigoMovimentoCabeca = RoboCodigoMovimentoCabecaEnum.CabecaInclinacaoBaixo;

            _robo = MovimentarCabecaRobo(_robo);
            CarregarChecksRobo(_robo.Robo);
        }

        //Método para liberar primeiros movimentos do robô
        protected void LiberarPrimeiroChecksAlteracaoRobo()
        {
            checkECotoveloLevementeContraido.Enabled = true;
            checkEPulsoRotacaoMenosQuarentaCinco.Enabled = true;
            checkEPulsoRotacaoQuarentaCinco.Enabled = true;

            checkDCotoveloLevementeContraido.Enabled = true;
            checkDPulsoRotacaoMenosQuarentaCinco.Enabled = true;
            checkDPulsoRotacaoQuarentaCinco.Enabled = true;

            checkCabecaRotacaoMenosQuarentaCinco.Enabled = true;
            checkCabecaRotacaoQuarentaCinco.Enabled = true;

            checkCabecaParaCima.Enabled = true;
            checkCabecaParaBaixo.Enabled = true;
        }

        protected void CarregarChecksRobo(RoboModel robo)
        {
            //Rotação da cabeça robô
            checkCabecaRotacaoMenosNoventa.Checked = robo.CabecaRotacaoMenosNoventa;
            checkCabecaRotacaoMenosQuarentaCinco.Checked = robo.CabecaRotacaoMenosQuarentaCinco;
            checkCabecaRepouso.Checked = robo.CabecaRotacaoRepouso;
            checkCabecaRotacaoQuarentaCinco.Checked = robo.CabecaRotacaoQuarencaCinco;
            checkCabecaRotacaoNoventa.Checked = robo.CabecaRotacaoNoventa;

            //Inclinação da cabeça robô
            checkCabecaParaCima.Checked = robo.CabecaInclinacaoCima;
            checkInclinacaoCabecaRepouso.Checked = robo.CabecaInclinacaoRepouso;
            checkCabecaParaBaixo.Checked = robo.CabecaInclinacaoBaixo;

            //Movimento dos braços robô
            foreach (var braco in robo.Bracos)
            {
                if (braco.PosicaoBraco == RoboPosicaoBracoEnum.Esquerdo)
                {
                    //Cotovelo esquerdo
                    checkECotoveloEmRepouso.Checked = braco.CotoveloRepouso;
                    checkECotoveloLevementeContraido.Checked = braco.CotoveloLevementeContraido;
                    checkECotoveloContraido.Checked = braco.CotoveloContraido;
                    checkECotoveloFortementeContraido.Checked = braco.CotoveloFormenteContraido;

                    //Pulso esquerdo
                    checkEPulsoRotacaoMenosNoventa.Checked = braco.PulsoRotacaoMenosNoventa;
                    checkEPulsoRotacaoMenosQuarentaCinco.Checked = braco.PulsoRotacaoMenosQuarentaCinco;
                    checkEPulsoRepouso.Checked = braco.PulsoEmRepouso;
                    checkEPulsoRotacaoQuarentaCinco.Checked = braco.PulsoRotacaoQuarentaCinco;
                    checkEPulsoRotacaoNoventa.Checked = braco.PulsoRotacaoNoventa;
                    checkEPulsoRotacaoCemTrintaCinco.Checked = braco.PulsoRotacaoCemTrintaCinco;
                    checkEPulsoRotacaoCemOitenta.Checked = braco.PulsoRotacaoCemOitenta;
                }

                if (braco.PosicaoBraco == RoboPosicaoBracoEnum.Direito)
                {
                    //Cotovelo direito
                    checkDCotoveloEmRepouso.Checked = braco.CotoveloRepouso;
                    checkDCotoveloLevementeContraido.Checked = braco.CotoveloLevementeContraido;
                    checkDCotoveloContraido.Checked = braco.CotoveloContraido;
                    checkDCotoveloFortementeContraido.Checked = braco.CotoveloFormenteContraido;

                    //Pulso direito
                    checkDPulsoRotacaoMenosNoventa.Checked = braco.PulsoRotacaoMenosNoventa;
                    checkDPulsoRotacaoMenosQuarentaCinco.Checked = braco.PulsoRotacaoMenosQuarentaCinco;
                    checkDPulsoRepouso.Checked = braco.PulsoEmRepouso;
                    checkDPulsoRotacaoQuarentaCinco.Checked = braco.PulsoRotacaoQuarentaCinco;
                    checkDPulsoRotacaoNoventa.Checked = braco.PulsoRotacaoNoventa;
                    checkDPulsoRotacaoCemTrintaCinco.Checked = braco.PulsoRotacaoCemTrintaCinco;
                    checkDPulsoRotacaoCemOitenta.Checked = braco.PulsoRotacaoCemOitenta;
                }
            }
        }

        protected void DesativarCheckBracoCotoveloEsquerdo()
        {
            checkECotoveloEmRepouso.Enabled = false;
            checkECotoveloLevementeContraido.Enabled = false;
            checkECotoveloContraido.Enabled = false;
            checkECotoveloFortementeContraido.Enabled = false;
        }

        protected void DesativarCheckBracoPulsoEsquerdo()
        {
            checkEPulsoRotacaoMenosNoventa.Enabled = false;
            checkEPulsoRotacaoMenosQuarentaCinco.Enabled = false;
            checkEPulsoRepouso.Enabled = false;
            checkEPulsoRotacaoQuarentaCinco.Enabled = false;
            checkEPulsoRotacaoNoventa.Enabled = false;
            checkEPulsoRotacaoCemTrintaCinco.Enabled = false;
            checkEPulsoRotacaoCemOitenta.Enabled = false;
        }

        protected void DesativarCheckBracoCotoveloDireito()
        {
            checkDCotoveloEmRepouso.Enabled = false;
            checkDCotoveloLevementeContraido.Enabled = false;
            checkDCotoveloContraido.Enabled = false;
            checkDCotoveloFortementeContraido.Enabled = false;
        }

        protected void DesativarCheckBracoPulsoDireito()
        {
            checkDPulsoRotacaoMenosNoventa.Enabled = false;
            checkDPulsoRotacaoMenosQuarentaCinco.Enabled = false;
            checkDPulsoRepouso.Enabled = false;
            checkDPulsoRotacaoQuarentaCinco.Enabled = false;
            checkDPulsoRotacaoNoventa.Enabled = false;
            checkDPulsoRotacaoCemTrintaCinco.Enabled = false;
            checkDPulsoRotacaoCemOitenta.Enabled = false;
        }

        protected void DesativarCheckRotacaoCabeca()
        {
            checkCabecaRotacaoMenosNoventa.Enabled = false;
            checkCabecaRotacaoMenosQuarentaCinco.Enabled = false;
            checkCabecaRepouso.Enabled = false;
            checkCabecaRotacaoQuarentaCinco.Enabled = false;
            checkCabecaRotacaoNoventa.Enabled = false;
        }

        protected void DesativarCheckInclinacaoCabeca()
        {
            checkCabecaParaCima.Enabled = false;
            checkInclinacaoCabecaRepouso.Enabled = false;
            checkCabecaParaBaixo.Enabled = false;
        }

        protected RoboModel CarregarRequestRobo()
        {
            var robo = new RoboModel();

            //Rotação da cabeça robô
            robo.CabecaRotacaoMenosNoventa = checkCabecaRotacaoMenosNoventa.Checked;
            robo.CabecaRotacaoMenosQuarentaCinco = checkCabecaRotacaoMenosQuarentaCinco.Checked;
            robo.CabecaRotacaoRepouso = checkCabecaRepouso.Checked;
            robo.CabecaRotacaoQuarencaCinco = checkCabecaRotacaoQuarentaCinco.Checked;
            robo.CabecaRotacaoNoventa = checkCabecaRotacaoNoventa.Checked;

            //Inclinação da cabeça robô
            robo.CabecaInclinacaoCima = checkCabecaParaCima.Checked;
            robo.CabecaInclinacaoRepouso = checkInclinacaoCabecaRepouso.Checked;
            robo.CabecaInclinacaoBaixo = checkCabecaParaBaixo.Checked;

            //Movimento dos braços robô
            var roboBracoEsquerdo = new RoboBracoModel
            {
                PosicaoBraco = RoboPosicaoBracoEnum.Esquerdo,

                //Cotovelo esquerdo
                CotoveloRepouso = checkECotoveloEmRepouso.Checked,
                CotoveloLevementeContraido = checkECotoveloLevementeContraido.Checked,
                CotoveloContraido = checkECotoveloContraido.Checked,
                CotoveloFormenteContraido = checkECotoveloFortementeContraido.Checked,

                //Pulso esquerdo
                PulsoRotacaoMenosNoventa = checkEPulsoRotacaoMenosNoventa.Checked,
                PulsoRotacaoMenosQuarentaCinco = checkEPulsoRotacaoMenosQuarentaCinco.Checked,
                PulsoEmRepouso = checkEPulsoRepouso.Checked,
                PulsoRotacaoQuarentaCinco = checkEPulsoRotacaoQuarentaCinco.Checked,
                PulsoRotacaoNoventa = checkEPulsoRotacaoNoventa.Checked,
                PulsoRotacaoCemTrintaCinco = checkEPulsoRotacaoCemTrintaCinco.Checked,
                PulsoRotacaoCemOitenta = checkEPulsoRotacaoCemOitenta.Checked
            };

            var roboBracoDireito = new RoboBracoModel
            {
                PosicaoBraco = RoboPosicaoBracoEnum.Direito,

                //Cotovelo direito
                CotoveloRepouso = checkDCotoveloEmRepouso.Checked,
                CotoveloLevementeContraido = checkDCotoveloLevementeContraido.Checked,
                CotoveloContraido = checkDCotoveloContraido.Checked,
                CotoveloFormenteContraido = checkDCotoveloFortementeContraido.Checked,

                //Pulso direito
                PulsoRotacaoMenosNoventa = checkDPulsoRotacaoMenosNoventa.Checked,
                PulsoRotacaoMenosQuarentaCinco = checkDPulsoRotacaoMenosQuarentaCinco.Checked,
                PulsoEmRepouso = checkDPulsoRepouso.Checked,
                PulsoRotacaoQuarentaCinco = checkDPulsoRotacaoQuarentaCinco.Checked,
                PulsoRotacaoNoventa = checkDPulsoRotacaoNoventa.Checked,
                PulsoRotacaoCemTrintaCinco = checkDPulsoRotacaoCemTrintaCinco.Checked,
                PulsoRotacaoCemOitenta = checkDPulsoRotacaoCemOitenta.Checked
            };

            robo.Bracos.Add(roboBracoEsquerdo);
            robo.Bracos.Add(roboBracoDireito);

            return robo;
        }

        protected RoboApiModel MovimentarBracoRobo(RoboApiModel robo)
        {
            _robo = _roboService.PutApiRobo(ServicoApiRoboConstant.MovimentarBracoRobo, _robo);

            return _robo;
        }

        protected RoboApiModel MovimentarCabecaRobo(RoboApiModel robo)
        {
            _robo = _roboService.PutApiRobo(ServicoApiRoboConstant.MovimentarCabecaRobo, _robo);

            return _robo;
        }
    }
}