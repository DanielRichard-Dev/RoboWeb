<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RoboWeb._Default" %>


<asp:Content ID="bodyRobo" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row col-md-12">
        <div class="row">
            <h1>Braços</h1>
        </div>

        <div class="col-md-6">
            <div>
                <h1>Braço Esquerdo</h1>
                <div class="jumbotron">
                    <div>
                        <h3>- Cotovelo</h3>
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkECotoveloEmRepouso" runat="server" AutoPostBack="true" OnCheckedChanged="checkECotoveloCotoveloEmRepouso_CheckedChanged" Text="Em Repouso" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkECotoveloLevementeContraido" runat="server" AutoPostBack="true" OnCheckedChanged="checkECotoveloLevementeContraido_CheckedChanged" Text="Levemente Contraído" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkECotoveloContraido" runat="server" AutoPostBack="true" OnCheckedChanged="checkECotoveloContraido_CheckedChanged" Text="Contraído" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkECotoveloFortementeContraido" runat="server" AutoPostBack="true" OnCheckedChanged="checkECotoveloFortementeContraido_CheckedChanged" Text="Fortemente Contraído" TextAlign="Right" />
                    </div>

                    <div>
                        <h3>- Pulso</h3>
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkEPulsoRotacaoMenosNoventa" runat="server" AutoPostBack="true" OnCheckedChanged="checkEPulsoRotacaoMenosNoventa_CheckedChanged" Text="Rotação para -90°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkEPulsoRotacaoMenosQuarentaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkEPulsoRotacaoMenosQuarentaCinco_CheckedChanged" Text="Rotação para -45°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkEPulsoRepouso" runat="server" AutoPostBack="true" OnCheckedChanged="checkEPulsoRepouso_CheckedChanged" Text="Em Repouso" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkEPulsoRotacaoQuarentaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkEPulsoRotacaoQuarentaCinco_CheckedChanged" Text="Rotação para 45°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkEPulsoRotacaoNoventa" runat="server" AutoPostBack="true" OnCheckedChanged="checkEPulsoRotacaoNoventa_CheckedChanged" Text="Rotação para 90°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkEPulsoRotacaoCemTrintaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkEPulsoRotacaoCemTrintaCinco_CheckedChanged" Text="Rotação para 135°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkEPulsoRotacaoCemOitenta" runat="server" AutoPostBack="true" OnCheckedChanged="checkEPulsoRotacaoCemOitenta_CheckedChanged" Text="Rotação para 180°" TextAlign="Right" />
                    </div>
                </div>
            </div>
        </div>

        <div class="col-md-6">
            <div>
                <h1>Braço Direito</h1>
                <div class="jumbotron">
                    <div>
                        <h3>- Cotovelo</h3>
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDCotoveloEmRepouso" runat="server" AutoPostBack="true" OnCheckedChanged="checkDCotoveloEmRepouso_CheckedChanged" Text="Em Repouso" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDCotoveloLevementeContraido" runat="server" AutoPostBack="true" OnCheckedChanged="checkDCotoveloLevementeContraido_CheckedChanged" Text="Levemente Contraído" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDCotoveloContraido" runat="server" AutoPostBack="true" OnCheckedChanged="checkDCotoveloContraido_CheckedChanged" Text="Contraído" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDCotoveloFortementeContraido" runat="server" AutoPostBack="true" OnCheckedChanged="checkDCotoveloFortementeContraido_CheckedChanged" Text="Fortemente Contraído" TextAlign="Right" />
                    </div>

                    <div>
                        <h3>- Pulso</h3>
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDPulsoRotacaoMenosNoventa" runat="server" AutoPostBack="true" OnCheckedChanged="checkDPulsoRotacaoMenosNoventa_CheckedChanged" Text="Rotação para -90°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDPulsoRotacaoMenosQuarentaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkDPulsoRotacaoMenosQuarentaCinco_CheckedChanged" Text="Rotação para -45°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDPulsoRepouso" runat="server" AutoPostBack="true" OnCheckedChanged="checkDPulsoRepouso_CheckedChanged" Text="Em Repouso" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDPulsoRotacaoQuarentaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkDPulsoRotacaoQuarentaCinco_CheckedChanged" Text="Rotação para 45°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDPulsoRotacaoNoventa" runat="server" AutoPostBack="true" OnCheckedChanged="checkDPulsoRotacaoNoventa_CheckedChanged" Text="Rotação para 90°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDPulsoRotacaoCemTrintaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkDPulsoRotacaoCemTrintaCinco_CheckedChanged" Text="Rotação para 135°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkDPulsoRotacaoCemOitenta" runat="server" AutoPostBack="true" OnCheckedChanged="checkDPulsoRotacaoCemOitenta_CheckedChanged" Text="Rotação para 180°" TextAlign="Right" />
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class="row col-md-12">
        <div class="row d-flex justify-content-center">
            <h1>Cabeça</h1>
        </div>

        <div class="col-md-6">
            <div>
                <h1>Rotação</h1>
                <div class="jumbotron">
                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkCabecaRotacaoMenosNoventa" runat="server" AutoPostBack="true" OnCheckedChanged="checkCabecaRotacaoMenosNoventa_CheckedChanged" Text="Rotação -90°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkCabecaRotacaoMenosQuarentaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkCabecaRotacaoMenosQuarentaCinco_CheckedChanged" Text="Rotação -45°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkCabecaRepouso" runat="server" AutoPostBack="true" OnCheckedChanged="checkCabecaRepouso_CheckedChanged" Text="Em Repouso" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkCabecaRotacaoQuarentaCinco" runat="server" AutoPostBack="true" OnCheckedChanged="checkCabecaRotacaoQuarentaCinco_CheckedChanged" Text="Rotação 45°" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkCabecaRotacaoNoventa" runat="server" AutoPostBack="true" OnCheckedChanged="checkCabecaRotacaoNoventa_CheckedChanged" Text="Rotação 90°" TextAlign="Right" />
                    </div>               
                </div>
            </div>
        </div>

        <div class="col-md-6">
            <div>
                <h1>Inclinação</h1>
                <div class="jumbotron">
                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkCabecaParaCima" runat="server" AutoPostBack="true" OnCheckedChanged="checkCabecaParaCima_CheckedChanged" Text="Para Cima" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkInclinacaoCabecaRepouso" runat="server" AutoPostBack="true" OnCheckedChanged="checkInclinacaoCabecaRepouso_CheckedChanged" Text="Em Repouso" TextAlign="Right" />
                    </div>

                    <div class="checkbox form-check form-check-inline">
                        <asp:CheckBox ID="checkCabecaParaBaixo" runat="server" AutoPostBack="true" OnCheckedChanged="checkCabecaParaBaixo_CheckedChanged" Text="Para Baixo" TextAlign="Right" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
