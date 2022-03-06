using RoboModels.Constants;
using RoboModels.RoboEnum;
using RoboModels.RoboModels;
using RoboServices.RoboInterfaces;
using RoboServices.RoboServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoboWeb
{
    public partial class _Default : Page
    {
        private IRoboService _roboService { get; set; }
        private RoboModel _robo { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _roboService = new RoboService();
            _robo = new RoboModel();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _robo = _roboService.GetApiRobo(ServicoApiRoboConstant.IniciarRobo);

            CarregarChecksRobo(_robo);
        }

        protected void checkECotoveloCotoveloEmRepouso_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkECotoveloLevementeContraido_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkECotoveloContraido_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkECotoveloFortementeContraido_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkEPulsoRotacaoMenosNoventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkEPulsoRotacaoMenosQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkEPulsoRepouso_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkEPulsoRotacaoQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkEPulsoRotacaoNoventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkEPulsoRotacaoCemTrintaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkEPulsoRotacaoCemOitenta_CheckedChanged(object sender, EventArgs e)
        {

        }

        //

        protected void checkDCotoveloEmRepouso_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDCotoveloLevementeContraido_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDCotoveloContraido_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDCotoveloFortementeContraido_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDPulsoRotacaoMenosNoventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDPulsoRotacaoMenosQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDPulsoRepouso_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDPulsoRotacaoQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDPulsoRotacaoNoventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDPulsoRotacaoCemTrintaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkDPulsoRotacaoCemOitenta_CheckedChanged(object sender, EventArgs e)
        {

        }

        //

        protected void checkCabecaRotacaoMenosNoventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkCabecaRotacaoMenosQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkCabecaRepouso_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkCabecaRotacaoQuarentaCinco_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkCabecaRotacaoNoventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkCabecaParaCima_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkInclinacaoCabecaRepouso_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void checkCabecaParaBaixo_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}