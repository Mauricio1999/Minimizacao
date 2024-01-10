
using MinimizacaoLoja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

//namespace MinimizacaoLoja
//{
//    public partial class Form2 : FormModeloDialogo
//    {
//        public FormDocumentosFiscais(int? idEntidadeEntrada)
//        {
//            InitializeComponent();
//        }

namespace MinimizacaoLoja
{
    public partial class FormNotasFiscais : FormModeloDialogo
    {
        public FormNotasFiscais()
        {
            InitializeComponent();
        }
    
        private void FormNotasFiscais_Load(object sender, EventArgs e)
        {
            // Efetua bloqueio dos campos após a MinimizacaoLoja
            AplicarMinimizacaoLoja();
        }

        private void AplicarMinimizacaoLoja()
        {
            btnVisualizar.Enabled = true;
            btnImprimir.Enabled = true;
            btnEnviarPorWhatsApp.Enabled = true;
            cboModelo.Enabled = false;
            btnIncluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnGravarArquivoXml.Enabled = true;
            btnEnviarEmail.Enabled = false;
            btnHistoricoEmails.Enabled = false;
            btnImprimir.Enabled = true;
            btnDocumentoComplementar.Enabled = false;
            btnTransmitirNfe.Enabled = true;
            btnImprimirEtiquetas.Enabled = false;
            btnExcluir.Enabled = false;
            btnExportarDados.Enabled = false;
            btnEnviarPorWhatsApp.Enabled = true;
        }
               
    }
}