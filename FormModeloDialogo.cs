
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MinimizacaoLoja
{
    public partial class FormModeloDialogo : Form
    {
        public FormModeloDialogo()
        {
            InitializeComponent();
            ListaGrids = new List<DataGridView>();
            Shown += new EventHandler(FormModeloDialogo_Shown);
        }

        public enum OpcoesOperacao
        {
            [Description("Cadastramento")]
            Incluir,

            [Description("Alteração")]
            Alterar,

            [Description("Visualização")]
            Visualizar,

            [Description("Alteração Múltipla")]
            AlteracaoMultipla
        }

        public IButtonControl BotaoAplicarFiltros { get; set; }

        [Category("Opções personalizadas"), DefaultValue(false)]
        public IButtonControl BotaoConfirmacao { get; set; }

        public IButtonControl BotaoSelecionar { get; set; }

        [Browsable(false)]
        public BuscaAvancadaPadrao BuscaAvancada { get; set; }

        public OpcoesOperacao? ModoOperacao { get; set; }
        public bool PadronizarGrids { get; set; }
        private bool Fechar { get; set; }
        private List<DataGridView> ListaGrids { get; set; }
        private Keys UltimaTeclaNavegacao { get; set; }

        public static void AutoTab(object sender, EventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "TextBox":
                    TextBox campoTexto = (TextBox)sender;
                    if (campoTexto.Focused && campoTexto.Text.Length >= campoTexto.MaxLength)
                    {
                        SendKeys.Send("^");
                        SendKeys.Send("{TAB}");
                    }
                    break;

                case "RichTextBox":
                    RichTextBox campoRichText = (RichTextBox)sender;
                    if (campoRichText.Focused && campoRichText.Text.Length >= campoRichText.MaxLength)
                    {
                        SendKeys.Send("^");
                        SendKeys.Send("{TAB}");
                    }
                    break;

                case "MaskedTextBox":
                    MaskedTextBox campoMask = (MaskedTextBox)sender;
                    if (campoMask.Focused && campoMask.MaskFull)
                    {
                        SendKeys.Send("^");
                        SendKeys.Send("{TAB}");
                    }
                    break;
            }
        }

        public void PadronizarGrid(DataGridView grid)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Gainsboro;
            grid.AlternatingRowsDefaultCellStyle = style;
            grid.RowHeadersWidth = 25;
        }

        private void FormModeloDialogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        private void FormModeloDialogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                var controle = ((ContainerControl)sender).ActiveControl;
                UltimaTeclaNavegacao = e.KeyCode;
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    if (NavegarUpDown(controle, e))
                        return;
                }

                if (NavegarControlesFilhos(Controls, e))
                {
                    return;
                }

                e.SuppressKeyPress = true;
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || (e.KeyCode == Keys.Up && controle.Name == "txtBuscaRapida"))
                    SendKeys.Send("{TAB}");
                else if (e.KeyCode == Keys.Up)
                    SendKeys.Send("+{TAB}");

                return;
            }

            if (e.Modifiers == Keys.None)
            {
                // Ação para o botão de confirmação
                if (BotaoConfirmacao != null && e.KeyCode == Keys.F3 && ((Button)BotaoConfirmacao).Enabled)
                {
                    BotaoConfirmacao.PerformClick();
                    e.SuppressKeyPress = true;
                    return;
                }

                // Ação para o botão aplicar filtros
                if (BotaoAplicarFiltros != null && e.KeyCode == Keys.F5 && ((Button)BotaoAplicarFiltros).Enabled)
                {
                    BotaoAplicarFiltros.PerformClick();
                    e.SuppressKeyPress = true;
                    return;
                }
            }
        }

        private void FormModeloDialogo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                try
                {
                    var grid = ((DataGridView)((ContainerControl)sender).ActiveControl);
                    if (grid.GetType().Name == "DataGridView")
                    {
                        if (grid.CurrentCell != null)
                        {
                            int linha = grid.CurrentCell.RowIndex;
                            if (UltimaTeclaNavegacao == Keys.Up && (linha > 0))
                                linha -= 1;
                            else
                            if (UltimaTeclaNavegacao == Keys.Down && (linha < grid.Rows.Count - 1))
                                linha += 1;

                            grid.CurrentCell = grid.Rows[linha].Cells[grid.CurrentCell.ColumnIndex];
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void FormModeloDialogo_Resize(object sender, EventArgs e)
        {
            VerificarNomenclaturaPadrao();
        }

        private void FormModeloDialogo_Shown(object sender, EventArgs e)
        {
            // Mapeia o evento de aplicação de filtros para o botão ativados da pesquisa rápida
            if (BotaoAplicarFiltros == null && BuscaAvancada != null &&
                BuscaAvancada.BotaoAtivadorBuscaRapida == null && BuscaAvancada.BotaoAtivadorPesquisa != null)
            {
                BotaoAplicarFiltros = BuscaAvancada.BotaoAtivadorPesquisa;
            }

            NavegarControlesFilhos(Controls, null);

            FormModeloDialogo_Resize(sender, e);

        }

        private bool NavegarControlesFilhos(Control.ControlCollection controlesPai, KeyEventArgs e)
        {
            foreach (Control controleFilho in controlesPai)
            {
                if (controleFilho.GetType().Name == "TextBox")
                {
                    if (((TextBox)controleFilho).Focused && ((TextBox)controleFilho).Multiline)
                    {
                        return true;
                    }
                }
                if (controleFilho.GetType().Name == "RichTextBox")
                {
                    if (((RichTextBox)controleFilho).Focused && ((RichTextBox)controleFilho).Multiline)
                    {
                        return true;
                    }
                }
                if (controleFilho.GetType().Name == "Button")
                {
                    Button btn = (Button)controleFilho;
                    if (btn != CancelButton)
                    {
                        btn.DialogResult = DialogResult.None;
                    }
                }
                if (controleFilho.GetType().Name == "DataGridView")
                {
                    if (PadronizarGrids)
                    {
                        PadronizarGrid((DataGridView)controleFilho);
                    }
                    if (e != null && ((DataGridView)controleFilho).Focused && BotaoSelecionar != null && e.Modifiers == Keys.None)
                    {
                        BotaoSelecionar.PerformClick();
                        e.SuppressKeyPress = true;
                        return true;
                    }
                }

                if (controleFilho.Controls.Count > 0)
                {
                    if (NavegarControlesFilhos(controleFilho.Controls, e))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool NavegarUpDown(Control controle, KeyEventArgs e)
        {
            var nomeTipoControle = controle.GetType().Name;
            switch (nomeTipoControle)
            {
                case "DataGridView":
                case "ComboBox":
                case "DateTimePicker":
                    return true;

                default:
                    return false;
            }
        }
        private void VerificarNomenclaturaPadrao()
        {
            Button btn;

            // Tratamento para os textos dos botões padrão
            if (BotaoSelecionar != null && !((Button)BotaoSelecionar).Text.EndsWith(" (ENTER)"))
            {
                ((Button)BotaoSelecionar).Text = String.Format("{0} (ENTER)", ((Button)BotaoSelecionar).Text.Replace("(ENTER)", "").Trim());
            }
            if (CancelButton != null && !((Button)CancelButton).Text.EndsWith(" (ESC)"))
            {
                ((Button)CancelButton).Text = String.Format("{0} (ESC)", ((Button)CancelButton).Text.Replace("(ESC)", "").Trim());
            }
            if (BotaoConfirmacao != null && !((Button)BotaoConfirmacao).Text.EndsWith(" (F3)"))
            {
                ((Button)BotaoConfirmacao).Text = String.Format("{0} (F3)", ((Button)BotaoConfirmacao).Text.Replace("(F3)", "").Trim());
            }
            if (BotaoAplicarFiltros != null && !((Button)BotaoAplicarFiltros).Text.EndsWith(" (F5)"))
            {
                btn = (Button)BotaoAplicarFiltros;
                if (btn.Text != "")
                {
                    btn.Text = String.Format("{0} (F5)", btn.Text.Replace("(F5)", "").Trim());
                }
            }
        }

        public class BuscaAvancadaPadrao
        {
            public BuscaAvancadaPadrao(Control groupBoxFiltros, Control controleSuperior, Control controleInferior, DataGridView grid, Button botaoAtivadorBuscaRapida,
                TextBox controleBuscaRapida, Button botaoAtivadorPesquisa)
            {
                ExibirBuscaAvancada = false;
                GroupBoxFiltros = groupBoxFiltros;
                ControleSuperior = controleSuperior;
                ControleInferior = controleInferior;
                Grid = grid;
                BotaoAtivadorBuscaRapida = botaoAtivadorBuscaRapida;
                BotaoAtivadorPesquisa = botaoAtivadorPesquisa;
                ControleBuscaRapida = controleBuscaRapida;
                controleBuscaRapida.Enter += new EventHandler(controleBuscaRapida_Enter);
                controleBuscaRapida.Leave += new EventHandler(controleBuscaRapida_Leave);
            }

            public Button BotaoAtivadorBuscaRapida { get; set; }
            public Button BotaoAtivadorPesquisa { get; set; }
            public TextBox ControleBuscaRapida { get; set; }
            public Control ControleInferior { get; set; }
            public Control ControleSuperior { get; set; }
            public bool ExibirBuscaAvancada { get; set; }
            public DataGridView Grid { get; set; }
            public Control GroupBoxFiltros { get; set; }
            public bool RealizarBuscaRapida { get; set; }
            private string StrPesquisaRapida { get; set; }

            public void ReposicionarCampos()
            {
                // Exibe/oculta o quadro de busca avançada
                if (GroupBoxFiltros != null)
                {
                    GroupBoxFiltros.Visible = ExibirBuscaAvancada;
                }

                // Altera a funcionalidade do botão busca avançada
                if (BotaoAtivadorBuscaRapida != null)
                {
                    BotaoAtivadorBuscaRapida.Text = ExibirBuscaAvancada ? "Aplicar filtros (F5)" : "Busca avançada (F12)";
                }

                // Posiciona o grid de produtos
                int posicaoInicial = (GroupBoxFiltros != null && GroupBoxFiltros.Visible) ? (GroupBoxFiltros.Top + GroupBoxFiltros.Height + 5) : (ControleSuperior.Top + ControleSuperior.Height + 5);
                int posicaoFinal = ControleInferior is null ? 0 : (ControleInferior.Top - 5);
                Grid.Height = posicaoFinal - posicaoInicial;
                Grid.Height -= ((Grid.Height - Grid.ColumnHeadersHeight) % Grid.RowTemplate.Height);
                Grid.Top = posicaoInicial + ((posicaoFinal - (posicaoInicial + Grid.Height)) / 2);
            }

            private void controleBuscaRapida_Enter(object sender, EventArgs e)
            {
                StrPesquisaRapida = ControleBuscaRapida.Text;
            }

            private void controleBuscaRapida_Leave(object sender, EventArgs e)
            {
                if (StrPesquisaRapida != ControleBuscaRapida.Text)
                {
                    BotaoAtivadorPesquisa.PerformClick();
                }
            }
        }
    }
}