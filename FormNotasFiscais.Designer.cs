namespace MinimizacaoLoja
{
    partial class FormNotasFiscais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPromptProduto = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboEmissao = new System.Windows.Forms.ComboBox();
            this.cboTipoOperacao = new System.Windows.Forms.ComboBox();
            this.cboFilial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.Selecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperacaoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumentoFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEntidadeDetalhado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHoraEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHoraEntradaSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusUnificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChaveDocumentoFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnTransmitirNfe = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMarcarTodos = new System.Windows.Forms.Button();
            this.btnGravarArquivoXml = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnHistoricoEmails = new System.Windows.Forms.Button();
            this.btnExportarDados = new System.Windows.Forms.Button();
            this.btnImprimirEtiquetas = new System.Windows.Forms.Button();
            this.grpPesquisaRapida = new System.Windows.Forms.GroupBox();
            this.btnBuscaAvancada = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBuscaRapida = new System.Windows.Forms.TextBox();
            this.grpBuscaAvancada = new System.Windows.Forms.GroupBox();
            this.btnPromptEntidade = new System.Windows.Forms.Button();
            this.cboEntidade = new System.Windows.Forms.ComboBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnDocumentoComplementar = new System.Windows.Forms.Button();
            this.pnlResumo = new System.Windows.Forms.GroupBox();
            this.TotalSaidas = new System.Windows.Forms.TextBox();
            this.QtdSaidas = new System.Windows.Forms.TextBox();
            this.TotalEntradas = new System.Windows.Forms.TextBox();
            this.QtdEntradas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCartaCorrecao = new System.Windows.Forms.Button();
            this.btnInutilizar = new System.Windows.Forms.Button();
            this.btnEnviarPorWhatsApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.grpPesquisaRapida.SuspendLayout();
            this.grpBuscaAvancada.SuspendLayout();
            this.pnlResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(1032, 603);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(155, 25);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "&Fechar (ESC)";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnPromptProduto
            // 
            this.btnPromptProduto.Location = new System.Drawing.Point(532, 102);
            this.btnPromptProduto.Name = "btnPromptProduto";
            this.btnPromptProduto.Size = new System.Drawing.Size(35, 25);
            this.btnPromptProduto.TabIndex = 5;
            this.btnPromptProduto.TabStop = false;
            this.btnPromptProduto.UseVisualStyleBackColor = true;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.White;
            this.txtNomeProduto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(145, 104);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(381, 20);
            this.txtNomeProduto.TabIndex = 4;
            this.txtNomeProduto.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 55;
            this.label9.Text = "Produto";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(817, 21);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(108, 20);
            this.dtpDataFinal.TabIndex = 7;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(671, 21);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(108, 20);
            this.dtpDataInicial.TabIndex = 6;
            // 
            // cboModelo
            // 
            this.cboModelo.BackColor = System.Drawing.Color.White;
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(145, 48);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(381, 22);
            this.cboModelo.TabIndex = 1;
            // 
            // cboEmissao
            // 
            this.cboEmissao.BackColor = System.Drawing.Color.White;
            this.cboEmissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmissao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmissao.FormattingEnabled = true;
            this.cboEmissao.Location = new System.Drawing.Point(671, 76);
            this.cboEmissao.Name = "cboEmissao";
            this.cboEmissao.Size = new System.Drawing.Size(254, 22);
            this.cboEmissao.TabIndex = 9;
            // 
            // cboTipoOperacao
            // 
            this.cboTipoOperacao.BackColor = System.Drawing.Color.White;
            this.cboTipoOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoOperacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoOperacao.FormattingEnabled = true;
            this.cboTipoOperacao.Location = new System.Drawing.Point(671, 48);
            this.cboTipoOperacao.Name = "cboTipoOperacao";
            this.cboTipoOperacao.Size = new System.Drawing.Size(254, 22);
            this.cboTipoOperacao.TabIndex = 8;
            // 
            // cboFilial
            // 
            this.cboFilial.BackColor = System.Drawing.Color.White;
            this.cboFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilial.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilial.FormattingEnabled = true;
            this.cboFilial.Location = new System.Drawing.Point(145, 20);
            this.cboFilial.Name = "cboFilial";
            this.cboFilial.Size = new System.Drawing.Size(381, 22);
            this.cboFilial.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Período";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente/fornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Emissão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Operação";
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvNotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecao,
            this.Modelo,
            this.OperacaoDocumento,
            this.IdNotaFiscal,
            this.NumeroDocumentoFiscal,
            this.NomeEntidadeDetalhado,
            this.DataHoraEmissao,
            this.DataHoraEntradaSaida,
            this.QuantidadeTotal,
            this.ValorDocumento,
            this.StatusUnificado,
            this.TipoEmissao,
            this.ChaveDocumentoFiscal});
            this.dgvNotas.Location = new System.Drawing.Point(12, 231);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersWidth = 25;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNotas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNotas.Size = new System.Drawing.Size(1175, 275);
            this.dgvNotas.TabIndex = 2;
            // 
            // Selecao
            // 
            this.Selecao.HeaderText = "Sel";
            this.Selecao.MinimumWidth = 6;
            this.Selecao.Name = "Selecao";
            this.Selecao.ReadOnly = true;
            this.Selecao.Width = 30;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "sigla";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 60;
            // 
            // OperacaoDocumento
            // 
            this.OperacaoDocumento.DataPropertyName = "operacao_documento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperacaoDocumento.DefaultCellStyle = dataGridViewCellStyle2;
            this.OperacaoDocumento.HeaderText = "Ope";
            this.OperacaoDocumento.MinimumWidth = 6;
            this.OperacaoDocumento.Name = "OperacaoDocumento";
            this.OperacaoDocumento.ReadOnly = true;
            this.OperacaoDocumento.Width = 40;
            // 
            // IdNotaFiscal
            // 
            this.IdNotaFiscal.DataPropertyName = "id_nota_fiscal";
            this.IdNotaFiscal.HeaderText = "IdNota";
            this.IdNotaFiscal.MinimumWidth = 6;
            this.IdNotaFiscal.Name = "IdNotaFiscal";
            this.IdNotaFiscal.ReadOnly = true;
            this.IdNotaFiscal.Visible = false;
            this.IdNotaFiscal.Width = 125;
            // 
            // NumeroDocumentoFiscal
            // 
            this.NumeroDocumentoFiscal.DataPropertyName = "numero_documento_fiscal";
            this.NumeroDocumentoFiscal.HeaderText = "Número";
            this.NumeroDocumentoFiscal.MinimumWidth = 6;
            this.NumeroDocumentoFiscal.Name = "NumeroDocumentoFiscal";
            this.NumeroDocumentoFiscal.ReadOnly = true;
            this.NumeroDocumentoFiscal.Width = 70;
            // 
            // NomeEntidadeDetalhado
            // 
            this.NomeEntidadeDetalhado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomeEntidadeDetalhado.DataPropertyName = "nome_entidade_detalhado";
            this.NomeEntidadeDetalhado.HeaderText = "Cliente/fornecedor";
            this.NomeEntidadeDetalhado.MinimumWidth = 6;
            this.NomeEntidadeDetalhado.Name = "NomeEntidadeDetalhado";
            this.NomeEntidadeDetalhado.ReadOnly = true;
            this.NomeEntidadeDetalhado.Width = 250;
            // 
            // DataHoraEmissao
            // 
            this.DataHoraEmissao.DataPropertyName = "data_hora_emissao";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DataHoraEmissao.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataHoraEmissao.HeaderText = "Emissão";
            this.DataHoraEmissao.MinimumWidth = 6;
            this.DataHoraEmissao.Name = "DataHoraEmissao";
            this.DataHoraEmissao.ReadOnly = true;
            this.DataHoraEmissao.Width = 80;
            // 
            // DataHoraEntradaSaida
            // 
            this.DataHoraEntradaSaida.DataPropertyName = "data_entrada_saida";
            this.DataHoraEntradaSaida.HeaderText = "Data e hora de entrada ou saída";
            this.DataHoraEntradaSaida.MinimumWidth = 6;
            this.DataHoraEntradaSaida.Name = "DataHoraEntradaSaida";
            this.DataHoraEntradaSaida.ReadOnly = true;
            this.DataHoraEntradaSaida.Width = 120;
            // 
            // QuantidadeTotal
            // 
            this.QuantidadeTotal.DataPropertyName = "quantidade_total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.QuantidadeTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.QuantidadeTotal.HeaderText = "Quantidade total";
            this.QuantidadeTotal.MinimumWidth = 6;
            this.QuantidadeTotal.Name = "QuantidadeTotal";
            this.QuantidadeTotal.ReadOnly = true;
            this.QuantidadeTotal.Width = 90;
            // 
            // ValorDocumento
            // 
            this.ValorDocumento.DataPropertyName = "valor_total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.ValorDocumento.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorDocumento.HeaderText = "Valor total";
            this.ValorDocumento.MinimumWidth = 6;
            this.ValorDocumento.Name = "ValorDocumento";
            this.ValorDocumento.ReadOnly = true;
            this.ValorDocumento.Width = 110;
            // 
            // StatusUnificado
            // 
            this.StatusUnificado.DataPropertyName = "nome_status_unificado";
            this.StatusUnificado.HeaderText = "Status";
            this.StatusUnificado.MinimumWidth = 6;
            this.StatusUnificado.Name = "StatusUnificado";
            this.StatusUnificado.ReadOnly = true;
            this.StatusUnificado.Width = 200;
            // 
            // TipoEmissao
            // 
            this.TipoEmissao.DataPropertyName = "nome_tipo_emissao";
            this.TipoEmissao.HeaderText = "Tipo emissão";
            this.TipoEmissao.MinimumWidth = 6;
            this.TipoEmissao.Name = "TipoEmissao";
            this.TipoEmissao.ReadOnly = true;
            this.TipoEmissao.Width = 90;
            // 
            // ChaveDocumentoFiscal
            // 
            this.ChaveDocumentoFiscal.DataPropertyName = "chave_documento_fiscal";
            this.ChaveDocumentoFiscal.HeaderText = "Chave";
            this.ChaveDocumentoFiscal.MinimumWidth = 6;
            this.ChaveDocumentoFiscal.Name = "ChaveDocumentoFiscal";
            this.ChaveDocumentoFiscal.ReadOnly = true;
            this.ChaveDocumentoFiscal.Width = 340;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(334, 603);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(154, 25);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "I&mprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnTransmitirNfe
            // 
            this.btnTransmitirNfe.Location = new System.Drawing.Point(495, 572);
            this.btnTransmitirNfe.Name = "btnTransmitirNfe";
            this.btnTransmitirNfe.Size = new System.Drawing.Size(155, 25);
            this.btnTransmitirNfe.TabIndex = 6;
            this.btnTransmitirNfe.Text = "Tran&smitir NF-e";
            this.btnTransmitirNfe.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(656, 572);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 25);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.Enabled = false;
            this.btnMarcarTodos.Location = new System.Drawing.Point(1032, 572);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Size = new System.Drawing.Size(155, 25);
            this.btnMarcarTodos.TabIndex = 18;
            this.btnMarcarTodos.Tag = "0";
            this.btnMarcarTodos.Text = "Marcar to&dos";
            this.btnMarcarTodos.UseVisualStyleBackColor = true;
            // 
            // btnGravarArquivoXml
            // 
            this.btnGravarArquivoXml.Location = new System.Drawing.Point(12, 603);
            this.btnGravarArquivoXml.Name = "btnGravarArquivoXml";
            this.btnGravarArquivoXml.Size = new System.Drawing.Size(155, 25);
            this.btnGravarArquivoXml.TabIndex = 9;
            this.btnGravarArquivoXml.Text = "&Gravar XML";
            this.btnGravarArquivoXml.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Enabled = false;
            this.btnIncluir.Location = new System.Drawing.Point(12, 572);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(155, 25);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "&Novo";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(173, 572);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(155, 25);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "A&lterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(817, 572);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(155, 25);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Enabled = false;
            this.btnEnviarEmail.Location = new System.Drawing.Point(12, 634);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(155, 25);
            this.btnEnviarEmail.TabIndex = 15;
            this.btnEnviarEmail.Text = "En&viar por e-mail";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            // 
            // btnHistoricoEmails
            // 
            this.btnHistoricoEmails.Enabled = false;
            this.btnHistoricoEmails.Location = new System.Drawing.Point(173, 634);
            this.btnHistoricoEmails.Name = "btnHistoricoEmails";
            this.btnHistoricoEmails.Size = new System.Drawing.Size(155, 25);
            this.btnHistoricoEmails.TabIndex = 16;
            this.btnHistoricoEmails.Text = "&Histórico e-mails";
            this.btnHistoricoEmails.UseVisualStyleBackColor = true;
            // 
            // btnExportarDados
            // 
            this.btnExportarDados.Enabled = false;
            this.btnExportarDados.Location = new System.Drawing.Point(656, 603);
            this.btnExportarDados.Name = "btnExportarDados";
            this.btnExportarDados.Size = new System.Drawing.Size(155, 25);
            this.btnExportarDados.TabIndex = 14;
            this.btnExportarDados.Text = "Exp&ortar dados";
            this.btnExportarDados.UseVisualStyleBackColor = true;
            // 
            // btnImprimirEtiquetas
            // 
            this.btnImprimirEtiquetas.Enabled = false;
            this.btnImprimirEtiquetas.Location = new System.Drawing.Point(494, 603);
            this.btnImprimirEtiquetas.Name = "btnImprimirEtiquetas";
            this.btnImprimirEtiquetas.Size = new System.Drawing.Size(156, 25);
            this.btnImprimirEtiquetas.TabIndex = 13;
            this.btnImprimirEtiquetas.Text = "Imprimir eti&quetas";
            this.btnImprimirEtiquetas.UseVisualStyleBackColor = true;
            // 
            // grpPesquisaRapida
            // 
            this.grpPesquisaRapida.Controls.Add(this.btnBuscaAvancada);
            this.grpPesquisaRapida.Controls.Add(this.btnPesquisar);
            this.grpPesquisaRapida.Controls.Add(this.txtBuscaRapida);
            this.grpPesquisaRapida.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisaRapida.Location = new System.Drawing.Point(12, 27);
            this.grpPesquisaRapida.Name = "grpPesquisaRapida";
            this.grpPesquisaRapida.Size = new System.Drawing.Size(1175, 55);
            this.grpPesquisaRapida.TabIndex = 0;
            this.grpPesquisaRapida.TabStop = false;
            this.grpPesquisaRapida.Text = "Pesquisa rápida (número da nota ou nome do remetente/destinatário)";
            // 
            // btnBuscaAvancada
            // 
            this.btnBuscaAvancada.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaAvancada.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaAvancada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaAvancada.Location = new System.Drawing.Point(1034, 20);
            this.btnBuscaAvancada.Name = "btnBuscaAvancada";
            this.btnBuscaAvancada.Size = new System.Drawing.Size(135, 25);
            this.btnBuscaAvancada.TabIndex = 2;
            this.btnBuscaAvancada.TabStop = false;
            this.btnBuscaAvancada.Text = "Busca avançada (F12)";
            this.btnBuscaAvancada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscaAvancada.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Location = new System.Drawing.Point(993, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(35, 25);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtBuscaRapida
            // 
            this.txtBuscaRapida.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtBuscaRapida.Location = new System.Drawing.Point(12, 22);
            this.txtBuscaRapida.Name = "txtBuscaRapida";
            this.txtBuscaRapida.Size = new System.Drawing.Size(975, 20);
            this.txtBuscaRapida.TabIndex = 0;
            // 
            // grpBuscaAvancada
            // 
            this.grpBuscaAvancada.Controls.Add(this.btnPromptEntidade);
            this.grpBuscaAvancada.Controls.Add(this.cboEntidade);
            this.grpBuscaAvancada.Controls.Add(this.cboFilial);
            this.grpBuscaAvancada.Controls.Add(this.btnPromptProduto);
            this.grpBuscaAvancada.Controls.Add(this.label6);
            this.grpBuscaAvancada.Controls.Add(this.txtNomeProduto);
            this.grpBuscaAvancada.Controls.Add(this.label2);
            this.grpBuscaAvancada.Controls.Add(this.label9);
            this.grpBuscaAvancada.Controls.Add(this.label7);
            this.grpBuscaAvancada.Controls.Add(this.label1);
            this.grpBuscaAvancada.Controls.Add(this.label8);
            this.grpBuscaAvancada.Controls.Add(this.label3);
            this.grpBuscaAvancada.Controls.Add(this.dtpDataFinal);
            this.grpBuscaAvancada.Controls.Add(this.label5);
            this.grpBuscaAvancada.Controls.Add(this.dtpDataInicial);
            this.grpBuscaAvancada.Controls.Add(this.cboTipoOperacao);
            this.grpBuscaAvancada.Controls.Add(this.cboModelo);
            this.grpBuscaAvancada.Controls.Add(this.cboEmissao);
            this.grpBuscaAvancada.Location = new System.Drawing.Point(12, 88);
            this.grpBuscaAvancada.Name = "grpBuscaAvancada";
            this.grpBuscaAvancada.Size = new System.Drawing.Size(1175, 137);
            this.grpBuscaAvancada.TabIndex = 1;
            this.grpBuscaAvancada.TabStop = false;
            this.grpBuscaAvancada.Text = "Filtros da busca avançada";
            // 
            // btnPromptEntidade
            // 
            this.btnPromptEntidade.Location = new System.Drawing.Point(532, 75);
            this.btnPromptEntidade.Name = "btnPromptEntidade";
            this.btnPromptEntidade.Size = new System.Drawing.Size(35, 25);
            this.btnPromptEntidade.TabIndex = 56;
            this.btnPromptEntidade.TabStop = false;
            this.btnPromptEntidade.UseVisualStyleBackColor = true;
            // 
            // cboEntidade
            // 
            this.cboEntidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEntidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEntidade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntidade.FormattingEnabled = true;
            this.cboEntidade.Location = new System.Drawing.Point(145, 76);
            this.cboEntidade.Name = "cboEntidade";
            this.cboEntidade.Size = new System.Drawing.Size(381, 22);
            this.cboEntidade.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(334, 572);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(155, 25);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnDocumentoComplementar
            // 
            this.btnDocumentoComplementar.Enabled = false;
            this.btnDocumentoComplementar.Location = new System.Drawing.Point(173, 603);
            this.btnDocumentoComplementar.Name = "btnDocumentoComplementar";
            this.btnDocumentoComplementar.Size = new System.Drawing.Size(155, 25);
            this.btnDocumentoComplementar.TabIndex = 17;
            this.btnDocumentoComplementar.Text = "NF complementar";
            this.btnDocumentoComplementar.UseVisualStyleBackColor = true;
            // 
            // pnlResumo
            // 
            this.pnlResumo.Controls.Add(this.TotalSaidas);
            this.pnlResumo.Controls.Add(this.QtdSaidas);
            this.pnlResumo.Controls.Add(this.TotalEntradas);
            this.pnlResumo.Controls.Add(this.QtdEntradas);
            this.pnlResumo.Controls.Add(this.label10);
            this.pnlResumo.Controls.Add(this.label11);
            this.pnlResumo.Controls.Add(this.label4);
            this.pnlResumo.Controls.Add(this.label12);
            this.pnlResumo.Location = new System.Drawing.Point(12, 516);
            this.pnlResumo.Name = "pnlResumo";
            this.pnlResumo.Size = new System.Drawing.Size(1175, 50);
            this.pnlResumo.TabIndex = 20;
            this.pnlResumo.TabStop = false;
            this.pnlResumo.Text = "Resumo dos documentos fiscais";
            // 
            // TotalSaidas
            // 
            this.TotalSaidas.Location = new System.Drawing.Point(1066, 17);
            this.TotalSaidas.Name = "TotalSaidas";
            this.TotalSaidas.ReadOnly = true;
            this.TotalSaidas.Size = new System.Drawing.Size(100, 20);
            this.TotalSaidas.TabIndex = 16;
            this.TotalSaidas.Text = "0.0";
            this.TotalSaidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // QtdSaidas
            // 
            this.QtdSaidas.Location = new System.Drawing.Point(784, 17);
            this.QtdSaidas.Name = "QtdSaidas";
            this.QtdSaidas.ReadOnly = true;
            this.QtdSaidas.Size = new System.Drawing.Size(100, 20);
            this.QtdSaidas.TabIndex = 15;
            this.QtdSaidas.Text = "0.0";
            this.QtdSaidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalEntradas
            // 
            this.TotalEntradas.Location = new System.Drawing.Point(456, 18);
            this.TotalEntradas.Name = "TotalEntradas";
            this.TotalEntradas.ReadOnly = true;
            this.TotalEntradas.Size = new System.Drawing.Size(100, 20);
            this.TotalEntradas.TabIndex = 14;
            this.TotalEntradas.Text = "0.0";
            this.TotalEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // QtdEntradas
            // 
            this.QtdEntradas.Location = new System.Drawing.Point(149, 18);
            this.QtdEntradas.Name = "QtdEntradas";
            this.QtdEntradas.ReadOnly = true;
            this.QtdEntradas.Size = new System.Drawing.Size(100, 20);
            this.QtdEntradas.TabIndex = 13;
            this.QtdEntradas.Text = "0.0";
            this.QtdEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(654, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Quantidade de saídas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(972, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total de saídas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade de entradas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total de entradas";
            // 
            // btnCartaCorrecao
            // 
            this.btnCartaCorrecao.Enabled = false;
            this.btnCartaCorrecao.Location = new System.Drawing.Point(334, 634);
            this.btnCartaCorrecao.Name = "btnCartaCorrecao";
            this.btnCartaCorrecao.Size = new System.Drawing.Size(155, 25);
            this.btnCartaCorrecao.TabIndex = 21;
            this.btnCartaCorrecao.Text = "Carta de Correção";
            this.btnCartaCorrecao.UseVisualStyleBackColor = true;
            // 
            // btnInutilizar
            // 
            this.btnInutilizar.Location = new System.Drawing.Point(495, 634);
            this.btnInutilizar.Name = "btnInutilizar";
            this.btnInutilizar.Size = new System.Drawing.Size(154, 25);
            this.btnInutilizar.TabIndex = 22;
            this.btnInutilizar.Text = "Inutilizar";
            this.btnInutilizar.UseVisualStyleBackColor = true;
            // 
            // btnEnviarPorWhatsApp
            // 
            this.btnEnviarPorWhatsApp.Location = new System.Drawing.Point(817, 603);
            this.btnEnviarPorWhatsApp.Name = "btnEnviarPorWhatsApp";
            this.btnEnviarPorWhatsApp.Size = new System.Drawing.Size(155, 25);
            this.btnEnviarPorWhatsApp.TabIndex = 23;
            this.btnEnviarPorWhatsApp.Text = "En&viar por WhatsApp";
            this.btnEnviarPorWhatsApp.UseVisualStyleBackColor = true;
            // 
            // FormNotasFiscais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.BotaoAplicarFiltros = this.btnPesquisar;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1199, 671);
            this.Controls.Add(this.btnEnviarPorWhatsApp);
            this.Controls.Add(this.btnInutilizar);
            this.Controls.Add(this.btnCartaCorrecao);
            this.Controls.Add(this.pnlResumo);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.grpBuscaAvancada);
            this.Controls.Add(this.grpPesquisaRapida);
            this.Controls.Add(this.btnImprimirEtiquetas);
            this.Controls.Add(this.btnDocumentoComplementar);
            this.Controls.Add(this.btnExportarDados);
            this.Controls.Add(this.btnGravarArquivoXml);
            this.Controls.Add(this.btnMarcarTodos);
            this.Controls.Add(this.btnHistoricoEmails);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnTransmitirNfe);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvNotas);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.Name = "FormNotasFiscais";
            this.PadronizarGrids = true;
            this.Text = "Notas fiscais";
            this.Load += new System.EventHandler(this.FormNotasFiscais_Load);
            this.Controls.SetChildIndex(this.dgvNotas, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnTransmitirNfe, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnEnviarEmail, 0);
            this.Controls.SetChildIndex(this.btnHistoricoEmails, 0);
            this.Controls.SetChildIndex(this.btnMarcarTodos, 0);
            this.Controls.SetChildIndex(this.btnGravarArquivoXml, 0);
            this.Controls.SetChildIndex(this.btnExportarDados, 0);
            this.Controls.SetChildIndex(this.btnDocumentoComplementar, 0);
            this.Controls.SetChildIndex(this.btnImprimirEtiquetas, 0);
            this.Controls.SetChildIndex(this.grpPesquisaRapida, 0);
            this.Controls.SetChildIndex(this.grpBuscaAvancada, 0);
            this.Controls.SetChildIndex(this.btnVisualizar, 0);
            this.Controls.SetChildIndex(this.pnlResumo, 0);
            this.Controls.SetChildIndex(this.btnCartaCorrecao, 0);
            this.Controls.SetChildIndex(this.btnInutilizar, 0);
            this.Controls.SetChildIndex(this.btnEnviarPorWhatsApp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.grpPesquisaRapida.ResumeLayout(false);
            this.grpPesquisaRapida.PerformLayout();
            this.grpBuscaAvancada.ResumeLayout(false);
            this.grpBuscaAvancada.PerformLayout();
            this.pnlResumo.ResumeLayout(false);
            this.pnlResumo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.ComboBox cboTipoOperacao;
        private System.Windows.Forms.ComboBox cboFilial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnTransmitirNfe;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMarcarTodos;
        private System.Windows.Forms.Button btnGravarArquivoXml;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cboEmissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnHistoricoEmails;
        private System.Windows.Forms.Button btnExportarDados;
        private System.Windows.Forms.Button btnImprimirEtiquetas;
        private System.Windows.Forms.Button btnPromptProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpPesquisaRapida;
        private System.Windows.Forms.Button btnBuscaAvancada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBuscaRapida;
        private System.Windows.Forms.GroupBox grpBuscaAvancada;
        private System.Windows.Forms.ComboBox cboEntidade;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnDocumentoComplementar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperacaoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumentoFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEntidadeDetalhado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraEntradaSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusUnificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChaveDocumentoFiscal;
        private System.Windows.Forms.Button btnPromptEntidade;
        private System.Windows.Forms.GroupBox pnlResumo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCartaCorrecao;
        private System.Windows.Forms.Button btnInutilizar;
        private System.Windows.Forms.Button btnEnviarPorWhatsApp;
        private System.Windows.Forms.TextBox TotalSaidas;
        private System.Windows.Forms.TextBox QtdSaidas;
        private System.Windows.Forms.TextBox TotalEntradas;
        private System.Windows.Forms.TextBox QtdEntradas;
    }
}
