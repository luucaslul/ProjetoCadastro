namespace ProjetoCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtEnderecoAluno = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtCidadeAluno = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCEPAluno = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCartaoBem = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtIdadeAluno = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.cbbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.GrpAluno = new System.Windows.Forms.GroupBox();
            this.txtRGAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailAluno = new System.Windows.Forms.MaskedTextBox();
            this.GrpMedio = new System.Windows.Forms.GroupBox();
            this.rbCursando = new System.Windows.Forms.RadioButton();
            this.rbCompleto = new System.Windows.Forms.RadioButton();
            this.GrpExtras = new System.Windows.Forms.GroupBox();
            this.cbOutros = new System.Windows.Forms.CheckBox();
            this.cbDigitacao = new System.Windows.Forms.CheckBox();
            this.cbInformatica = new System.Windows.Forms.CheckBox();
            this.cbIngles = new System.Windows.Forms.CheckBox();
            this.pictImagem = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.GrpResponsavel = new System.Windows.Forms.GroupBox();
            this.txtRGResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonerResponsavel = new System.Windows.Forms.TextBox();
            this.lblTelefoneResponsavel = new System.Windows.Forms.Label();
            this.txtTelResponsavel = new System.Windows.Forms.TextBox();
            this.tlblTelefoneResidencia = new System.Windows.Forms.Label();
            this.txtEmailResponsavel = new System.Windows.Forms.TextBox();
            this.lblEmailResponsavel = new System.Windows.Forms.Label();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.lblNomeResponsavel = new System.Windows.Forms.Label();
            this.lblRGResponsavel = new System.Windows.Forms.Label();
            this.lblCPFResponsavel = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.GrpBtn = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.GrpVerificacao = new System.Windows.Forms.GroupBox();
            this.btnNomes = new System.Windows.Forms.Button();
            this.btnContarControles = new System.Windows.Forms.Button();
            this.btnContarResponsavel = new System.Windows.Forms.Button();
            this.btnContarAluno = new System.Windows.Forms.Button();
            this.pictCavalo = new System.Windows.Forms.PictureBox();
            this.GrpAluno.SuspendLayout();
            this.GrpMedio.SuspendLayout();
            this.GrpExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagem)).BeginInit();
            this.GrpResponsavel.SuspendLayout();
            this.GrpBtn.SuspendLayout();
            this.GrpVerificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCavalo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(74, 19);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(597, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // txtEnderecoAluno
            // 
            this.txtEnderecoAluno.Location = new System.Drawing.Point(74, 45);
            this.txtEnderecoAluno.Name = "txtEnderecoAluno";
            this.txtEnderecoAluno.Size = new System.Drawing.Size(597, 20);
            this.txtEnderecoAluno.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(11, 48);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtCidadeAluno
            // 
            this.txtCidadeAluno.Location = new System.Drawing.Point(75, 71);
            this.txtCidadeAluno.Name = "txtCidadeAluno";
            this.txtCidadeAluno.Size = new System.Drawing.Size(242, 20);
            this.txtCidadeAluno.TabIndex = 5;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(11, 74);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCEPAluno
            // 
            this.txtCEPAluno.Location = new System.Drawing.Point(370, 71);
            this.txtCEPAluno.Name = "txtCEPAluno";
            this.txtCEPAluno.Size = new System.Drawing.Size(147, 20);
            this.txtCEPAluno.TabIndex = 7;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(333, 74);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 6;
            this.lblCEP.Text = "CEP";
            // 
            // lblCartaoBem
            // 
            this.lblCartaoBem.AutoSize = true;
            this.lblCartaoBem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaoBem.Location = new System.Drawing.Point(523, 74);
            this.lblCartaoBem.Name = "lblCartaoBem";
            this.lblCartaoBem.Size = new System.Drawing.Size(151, 13);
            this.lblCartaoBem.TabIndex = 8;
            this.lblCartaoBem.Text = "Tem direito a cartão BEM";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(11, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email pessoal";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(137, 123);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(200, 20);
            this.txtData.TabIndex = 11;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(11, 129);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(120, 13);
            this.lblDataNascimento.TabIndex = 12;
            this.lblDataNascimento.Text = "Data de nascimento";
            // 
            // txtIdadeAluno
            // 
            this.txtIdadeAluno.Location = new System.Drawing.Point(396, 123);
            this.txtIdadeAluno.Name = "txtIdadeAluno";
            this.txtIdadeAluno.Size = new System.Drawing.Size(147, 20);
            this.txtIdadeAluno.TabIndex = 14;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(351, 126);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(39, 13);
            this.lblIdade.TabIndex = 13;
            this.lblIdade.Text = "Idade";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(13, 152);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 15;
            this.lblCPF.Text = "CPF";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(351, 152);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(25, 13);
            this.lblRG.TabIndex = 17;
            this.lblRG.Text = "RG";
            // 
            // cbbGenero
            // 
            this.cbbGenero.FormattingEnabled = true;
            this.cbbGenero.Location = new System.Drawing.Point(67, 175);
            this.cbbGenero.Name = "cbbGenero";
            this.cbbGenero.Size = new System.Drawing.Size(270, 21);
            this.cbbGenero.TabIndex = 19;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(13, 178);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 13);
            this.lblGenero.TabIndex = 20;
            this.lblGenero.Text = "Gênero";
            // 
            // GrpAluno
            // 
            this.GrpAluno.Controls.Add(this.txtRGAluno);
            this.GrpAluno.Controls.Add(this.txtCPFAluno);
            this.GrpAluno.Controls.Add(this.txtEmailAluno);
            this.GrpAluno.Controls.Add(this.GrpMedio);
            this.GrpAluno.Controls.Add(this.GrpExtras);
            this.GrpAluno.Controls.Add(this.txtNomeAluno);
            this.GrpAluno.Controls.Add(this.lblGenero);
            this.GrpAluno.Controls.Add(this.lblNome);
            this.GrpAluno.Controls.Add(this.cbbGenero);
            this.GrpAluno.Controls.Add(this.lblEndereco);
            this.GrpAluno.Controls.Add(this.txtEnderecoAluno);
            this.GrpAluno.Controls.Add(this.lblRG);
            this.GrpAluno.Controls.Add(this.lblCidade);
            this.GrpAluno.Controls.Add(this.txtCidadeAluno);
            this.GrpAluno.Controls.Add(this.lblCPF);
            this.GrpAluno.Controls.Add(this.lblCEP);
            this.GrpAluno.Controls.Add(this.txtIdadeAluno);
            this.GrpAluno.Controls.Add(this.txtCEPAluno);
            this.GrpAluno.Controls.Add(this.lblIdade);
            this.GrpAluno.Controls.Add(this.lblCartaoBem);
            this.GrpAluno.Controls.Add(this.lblDataNascimento);
            this.GrpAluno.Controls.Add(this.lblEmail);
            this.GrpAluno.Controls.Add(this.txtData);
            this.GrpAluno.Location = new System.Drawing.Point(12, 12);
            this.GrpAluno.Name = "GrpAluno";
            this.GrpAluno.Size = new System.Drawing.Size(691, 299);
            this.GrpAluno.TabIndex = 21;
            this.GrpAluno.TabStop = false;
            this.GrpAluno.Text = "Dados do aluno";
            // 
            // txtRGAluno
            // 
            this.txtRGAluno.Location = new System.Drawing.Point(396, 149);
            this.txtRGAluno.Mask = "__-___-___-__";
            this.txtRGAluno.Name = "txtRGAluno";
            this.txtRGAluno.Size = new System.Drawing.Size(275, 20);
            this.txtRGAluno.TabIndex = 25;
            // 
            // txtCPFAluno
            // 
            this.txtCPFAluno.Location = new System.Drawing.Point(67, 152);
            this.txtCPFAluno.Mask = "___-___-___-__";
            this.txtCPFAluno.Name = "txtCPFAluno";
            this.txtCPFAluno.Size = new System.Drawing.Size(270, 20);
            this.txtCPFAluno.TabIndex = 24;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(101, 97);
            this.txtEmailAluno.Mask = "Obrigatorio";
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(570, 20);
            this.txtEmailAluno.TabIndex = 23;
            // 
            // GrpMedio
            // 
            this.GrpMedio.Controls.Add(this.rbCursando);
            this.GrpMedio.Controls.Add(this.rbCompleto);
            this.GrpMedio.Location = new System.Drawing.Point(440, 202);
            this.GrpMedio.Name = "GrpMedio";
            this.GrpMedio.Size = new System.Drawing.Size(231, 77);
            this.GrpMedio.TabIndex = 22;
            this.GrpMedio.TabStop = false;
            this.GrpMedio.Text = "Ensino médio";
            this.GrpMedio.UseCompatibleTextRendering = true;
            // 
            // rbCursando
            // 
            this.rbCursando.AutoSize = true;
            this.rbCursando.Location = new System.Drawing.Point(135, 32);
            this.rbCursando.Name = "rbCursando";
            this.rbCursando.Size = new System.Drawing.Size(70, 17);
            this.rbCursando.TabIndex = 1;
            this.rbCursando.TabStop = true;
            this.rbCursando.Text = "Cursando";
            this.rbCursando.UseVisualStyleBackColor = true;
            // 
            // rbCompleto
            // 
            this.rbCompleto.AutoSize = true;
            this.rbCompleto.Location = new System.Drawing.Point(34, 32);
            this.rbCompleto.Name = "rbCompleto";
            this.rbCompleto.Size = new System.Drawing.Size(69, 17);
            this.rbCompleto.TabIndex = 0;
            this.rbCompleto.TabStop = true;
            this.rbCompleto.Text = "Completo";
            this.rbCompleto.UseVisualStyleBackColor = true;
            // 
            // GrpExtras
            // 
            this.GrpExtras.Controls.Add(this.cbOutros);
            this.GrpExtras.Controls.Add(this.cbDigitacao);
            this.GrpExtras.Controls.Add(this.cbInformatica);
            this.GrpExtras.Controls.Add(this.cbIngles);
            this.GrpExtras.Location = new System.Drawing.Point(16, 202);
            this.GrpExtras.Name = "GrpExtras";
            this.GrpExtras.Size = new System.Drawing.Size(418, 77);
            this.GrpExtras.TabIndex = 21;
            this.GrpExtras.TabStop = false;
            this.GrpExtras.Text = "Cursos extras";
            // 
            // cbOutros
            // 
            this.cbOutros.AutoSize = true;
            this.cbOutros.Location = new System.Drawing.Point(307, 33);
            this.cbOutros.Name = "cbOutros";
            this.cbOutros.Size = new System.Drawing.Size(57, 17);
            this.cbOutros.TabIndex = 3;
            this.cbOutros.Text = "Outros";
            this.cbOutros.UseVisualStyleBackColor = true;
            // 
            // cbDigitacao
            // 
            this.cbDigitacao.AutoSize = true;
            this.cbDigitacao.Location = new System.Drawing.Point(230, 33);
            this.cbDigitacao.Name = "cbDigitacao";
            this.cbDigitacao.Size = new System.Drawing.Size(71, 17);
            this.cbDigitacao.TabIndex = 2;
            this.cbDigitacao.Text = "Digitação";
            this.cbDigitacao.UseVisualStyleBackColor = true;
            // 
            // cbInformatica
            // 
            this.cbInformatica.AutoSize = true;
            this.cbInformatica.Location = new System.Drawing.Point(112, 33);
            this.cbInformatica.Name = "cbInformatica";
            this.cbInformatica.Size = new System.Drawing.Size(112, 17);
            this.cbInformatica.TabIndex = 1;
            this.cbInformatica.Text = "Informática básica";
            this.cbInformatica.UseVisualStyleBackColor = true;
            // 
            // cbIngles
            // 
            this.cbIngles.AutoSize = true;
            this.cbIngles.Location = new System.Drawing.Point(52, 33);
            this.cbIngles.Name = "cbIngles";
            this.cbIngles.Size = new System.Drawing.Size(54, 17);
            this.cbIngles.TabIndex = 0;
            this.cbIngles.Text = "Inglês";
            this.cbIngles.UseVisualStyleBackColor = true;
            // 
            // pictImagem
            // 
            this.pictImagem.Location = new System.Drawing.Point(709, 16);
            this.pictImagem.Name = "pictImagem";
            this.pictImagem.Size = new System.Drawing.Size(225, 247);
            this.pictImagem.TabIndex = 22;
            this.pictImagem.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(709, 267);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(225, 44);
            this.btnCapturar.TabIndex = 23;
            this.btnCapturar.Text = "Capturar imagem";
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // GrpResponsavel
            // 
            this.GrpResponsavel.Controls.Add(this.txtRGResponsavel);
            this.GrpResponsavel.Controls.Add(this.txtCPFResponsavel);
            this.GrpResponsavel.Controls.Add(this.txtTelefonerResponsavel);
            this.GrpResponsavel.Controls.Add(this.lblTelefoneResponsavel);
            this.GrpResponsavel.Controls.Add(this.txtTelResponsavel);
            this.GrpResponsavel.Controls.Add(this.tlblTelefoneResidencia);
            this.GrpResponsavel.Controls.Add(this.txtEmailResponsavel);
            this.GrpResponsavel.Controls.Add(this.lblEmailResponsavel);
            this.GrpResponsavel.Controls.Add(this.txtNomeResponsavel);
            this.GrpResponsavel.Controls.Add(this.lblNomeResponsavel);
            this.GrpResponsavel.Controls.Add(this.lblRGResponsavel);
            this.GrpResponsavel.Controls.Add(this.lblCPFResponsavel);
            this.GrpResponsavel.Controls.Add(this.txtNomeMae);
            this.GrpResponsavel.Controls.Add(this.lblNomeMae);
            this.GrpResponsavel.Controls.Add(this.txtNomePai);
            this.GrpResponsavel.Controls.Add(this.lblNomePai);
            this.GrpResponsavel.Location = new System.Drawing.Point(13, 318);
            this.GrpResponsavel.Name = "GrpResponsavel";
            this.GrpResponsavel.Size = new System.Drawing.Size(921, 162);
            this.GrpResponsavel.TabIndex = 24;
            this.GrpResponsavel.TabStop = false;
            this.GrpResponsavel.Text = "Dados do responsável";
            // 
            // txtRGResponsavel
            // 
            this.txtRGResponsavel.Location = new System.Drawing.Point(560, 48);
            this.txtRGResponsavel.Mask = "__-___-___-__";
            this.txtRGResponsavel.Name = "txtRGResponsavel";
            this.txtRGResponsavel.Size = new System.Drawing.Size(347, 20);
            this.txtRGResponsavel.TabIndex = 26;
            // 
            // txtCPFResponsavel
            // 
            this.txtCPFResponsavel.Location = new System.Drawing.Point(157, 45);
            this.txtCPFResponsavel.Mask = "___-___-___-__";
            this.txtCPFResponsavel.Name = "txtCPFResponsavel";
            this.txtCPFResponsavel.Size = new System.Drawing.Size(287, 20);
            this.txtCPFResponsavel.TabIndex = 26;
            // 
            // txtTelefonerResponsavel
            // 
            this.txtTelefonerResponsavel.Location = new System.Drawing.Point(560, 126);
            this.txtTelefonerResponsavel.Name = "txtTelefonerResponsavel";
            this.txtTelefonerResponsavel.Size = new System.Drawing.Size(347, 20);
            this.txtTelefonerResponsavel.TabIndex = 38;
            // 
            // lblTelefoneResponsavel
            // 
            this.lblTelefoneResponsavel.AutoSize = true;
            this.lblTelefoneResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneResponsavel.Location = new System.Drawing.Point(455, 129);
            this.lblTelefoneResponsavel.Name = "lblTelefoneResponsavel";
            this.lblTelefoneResponsavel.Size = new System.Drawing.Size(99, 13);
            this.lblTelefoneResponsavel.TabIndex = 37;
            this.lblTelefoneResponsavel.Text = "Telefone celular";
            // 
            // txtTelResponsavel
            // 
            this.txtTelResponsavel.Location = new System.Drawing.Point(157, 123);
            this.txtTelResponsavel.Name = "txtTelResponsavel";
            this.txtTelResponsavel.Size = new System.Drawing.Size(287, 20);
            this.txtTelResponsavel.TabIndex = 36;
            // 
            // tlblTelefoneResidencia
            // 
            this.tlblTelefoneResidencia.AutoSize = true;
            this.tlblTelefoneResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlblTelefoneResidencia.Location = new System.Drawing.Point(13, 126);
            this.tlblTelefoneResidencia.Name = "tlblTelefoneResidencia";
            this.tlblTelefoneResidencia.Size = new System.Drawing.Size(137, 13);
            this.tlblTelefoneResidencia.TabIndex = 35;
            this.tlblTelefoneResidencia.Text = "Telefone de residência";
            // 
            // txtEmailResponsavel
            // 
            this.txtEmailResponsavel.Location = new System.Drawing.Point(157, 97);
            this.txtEmailResponsavel.Name = "txtEmailResponsavel";
            this.txtEmailResponsavel.Size = new System.Drawing.Size(750, 20);
            this.txtEmailResponsavel.TabIndex = 34;
            // 
            // lblEmailResponsavel
            // 
            this.lblEmailResponsavel.AutoSize = true;
            this.lblEmailResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailResponsavel.Location = new System.Drawing.Point(13, 100);
            this.lblEmailResponsavel.Name = "lblEmailResponsavel";
            this.lblEmailResponsavel.Size = new System.Drawing.Size(127, 13);
            this.lblEmailResponsavel.TabIndex = 33;
            this.lblEmailResponsavel.Text = "Email do responsável";
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(157, 71);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(750, 20);
            this.txtNomeResponsavel.TabIndex = 32;
            // 
            // lblNomeResponsavel
            // 
            this.lblNomeResponsavel.AutoSize = true;
            this.lblNomeResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeResponsavel.Location = new System.Drawing.Point(13, 74);
            this.lblNomeResponsavel.Name = "lblNomeResponsavel";
            this.lblNomeResponsavel.Size = new System.Drawing.Size(129, 13);
            this.lblNomeResponsavel.TabIndex = 31;
            this.lblNomeResponsavel.Text = "Nome do responsável";
            // 
            // lblRGResponsavel
            // 
            this.lblRGResponsavel.AutoSize = true;
            this.lblRGResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGResponsavel.Location = new System.Drawing.Point(529, 48);
            this.lblRGResponsavel.Name = "lblRGResponsavel";
            this.lblRGResponsavel.Size = new System.Drawing.Size(25, 13);
            this.lblRGResponsavel.TabIndex = 29;
            this.lblRGResponsavel.Text = "RG";
            // 
            // lblCPFResponsavel
            // 
            this.lblCPFResponsavel.AutoSize = true;
            this.lblCPFResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFResponsavel.Location = new System.Drawing.Point(120, 48);
            this.lblCPFResponsavel.Name = "lblCPFResponsavel";
            this.lblCPFResponsavel.Size = new System.Drawing.Size(30, 13);
            this.lblCPFResponsavel.TabIndex = 27;
            this.lblCPFResponsavel.Text = "CPF";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(560, 19);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(347, 20);
            this.txtNomeMae.TabIndex = 26;
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMae.Location = new System.Drawing.Point(470, 22);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(84, 13);
            this.lblNomeMae.TabIndex = 25;
            this.lblNomeMae.Text = "Nome da mãe";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(100, 19);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(344, 20);
            this.txtNomePai.TabIndex = 24;
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePai.Location = new System.Drawing.Point(13, 22);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(78, 13);
            this.lblNomePai.TabIndex = 23;
            this.lblNomePai.Text = "Nome do pai";
            // 
            // GrpBtn
            // 
            this.GrpBtn.Controls.Add(this.btnSair);
            this.GrpBtn.Controls.Add(this.btnLimpar);
            this.GrpBtn.Controls.Add(this.btnCadastrar);
            this.GrpBtn.Location = new System.Drawing.Point(13, 486);
            this.GrpBtn.Name = "GrpBtn";
            this.GrpBtn.Size = new System.Drawing.Size(921, 124);
            this.GrpBtn.TabIndex = 25;
            this.GrpBtn.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(630, 32);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(277, 60);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(322, 32);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(277, 60);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 32);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(277, 60);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // GrpVerificacao
            // 
            this.GrpVerificacao.Controls.Add(this.btnNomes);
            this.GrpVerificacao.Controls.Add(this.btnContarControles);
            this.GrpVerificacao.Controls.Add(this.btnContarResponsavel);
            this.GrpVerificacao.Controls.Add(this.btnContarAluno);
            this.GrpVerificacao.Location = new System.Drawing.Point(949, 12);
            this.GrpVerificacao.Name = "GrpVerificacao";
            this.GrpVerificacao.Size = new System.Drawing.Size(243, 299);
            this.GrpVerificacao.TabIndex = 26;
            this.GrpVerificacao.TabStop = false;
            this.GrpVerificacao.Text = "Verificação de controles";
            // 
            // btnNomes
            // 
            this.btnNomes.Location = new System.Drawing.Point(6, 225);
            this.btnNomes.Name = "btnNomes";
            this.btnNomes.Size = new System.Drawing.Size(231, 60);
            this.btnNomes.TabIndex = 7;
            this.btnNomes.Text = "Nomes e texto dos controles";
            this.btnNomes.UseVisualStyleBackColor = true;
            this.btnNomes.Click += new System.EventHandler(this.BtnNomes_Click);
            // 
            // btnContarControles
            // 
            this.btnContarControles.Location = new System.Drawing.Point(6, 159);
            this.btnContarControles.Name = "btnContarControles";
            this.btnContarControles.Size = new System.Drawing.Size(231, 60);
            this.btnContarControles.TabIndex = 6;
            this.btnContarControles.Text = "Quantidade total de controles do formulário";
            this.btnContarControles.UseVisualStyleBackColor = true;
            this.btnContarControles.Click += new System.EventHandler(this.BtnContarControles_Click);
            // 
            // btnContarResponsavel
            // 
            this.btnContarResponsavel.Location = new System.Drawing.Point(6, 93);
            this.btnContarResponsavel.Name = "btnContarResponsavel";
            this.btnContarResponsavel.Size = new System.Drawing.Size(231, 60);
            this.btnContarResponsavel.TabIndex = 5;
            this.btnContarResponsavel.Text = "Quantidade de controles agrupamento dados do Responsável";
            this.btnContarResponsavel.UseVisualStyleBackColor = true;
            this.btnContarResponsavel.Click += new System.EventHandler(this.BtnContarResponsavel_Click);
            // 
            // btnContarAluno
            // 
            this.btnContarAluno.Location = new System.Drawing.Point(6, 27);
            this.btnContarAluno.Name = "btnContarAluno";
            this.btnContarAluno.Size = new System.Drawing.Size(231, 60);
            this.btnContarAluno.TabIndex = 4;
            this.btnContarAluno.Text = "Quantidade controle agrupamento dados do aluno ";
            this.btnContarAluno.UseVisualStyleBackColor = true;
            this.btnContarAluno.Click += new System.EventHandler(this.BtnContarAluno_Click);
            // 
            // pictCavalo
            // 
            this.pictCavalo.Image = ((System.Drawing.Image)(resources.GetObject("pictCavalo.Image")));
            this.pictCavalo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictCavalo.InitialImage")));
            this.pictCavalo.Location = new System.Drawing.Point(949, 318);
            this.pictCavalo.Name = "pictCavalo";
            this.pictCavalo.Size = new System.Drawing.Size(243, 292);
            this.pictCavalo.TabIndex = 27;
            this.pictCavalo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 622);
            this.Controls.Add(this.pictCavalo);
            this.Controls.Add(this.GrpVerificacao);
            this.Controls.Add(this.GrpBtn);
            this.Controls.Add(this.GrpResponsavel);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.pictImagem);
            this.Controls.Add(this.GrpAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpAluno.ResumeLayout(false);
            this.GrpAluno.PerformLayout();
            this.GrpMedio.ResumeLayout(false);
            this.GrpMedio.PerformLayout();
            this.GrpExtras.ResumeLayout(false);
            this.GrpExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagem)).EndInit();
            this.GrpResponsavel.ResumeLayout(false);
            this.GrpResponsavel.PerformLayout();
            this.GrpBtn.ResumeLayout(false);
            this.GrpVerificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictCavalo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtEnderecoAluno;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtCidadeAluno;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCEPAluno;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCartaoBem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtIdadeAluno;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.ComboBox cbbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.GroupBox GrpAluno;
        private System.Windows.Forms.GroupBox GrpMedio;
        private System.Windows.Forms.GroupBox GrpExtras;
        private System.Windows.Forms.RadioButton rbCursando;
        private System.Windows.Forms.RadioButton rbCompleto;
        private System.Windows.Forms.CheckBox cbOutros;
        private System.Windows.Forms.CheckBox cbDigitacao;
        private System.Windows.Forms.CheckBox cbInformatica;
        private System.Windows.Forms.CheckBox cbIngles;
        private System.Windows.Forms.PictureBox pictImagem;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.GroupBox GrpResponsavel;
        private System.Windows.Forms.TextBox txtTelefonerResponsavel;
        private System.Windows.Forms.Label lblTelefoneResponsavel;
        private System.Windows.Forms.TextBox txtTelResponsavel;
        private System.Windows.Forms.Label tlblTelefoneResidencia;
        private System.Windows.Forms.TextBox txtEmailResponsavel;
        private System.Windows.Forms.Label lblEmailResponsavel;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.Label lblNomeResponsavel;
        private System.Windows.Forms.Label lblRGResponsavel;
        private System.Windows.Forms.Label lblCPFResponsavel;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.GroupBox GrpBtn;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox GrpVerificacao;
        private System.Windows.Forms.Button btnNomes;
        private System.Windows.Forms.Button btnContarControles;
        private System.Windows.Forms.Button btnContarResponsavel;
        private System.Windows.Forms.Button btnContarAluno;
        private System.Windows.Forms.MaskedTextBox txtRGAluno;
        private System.Windows.Forms.MaskedTextBox txtCPFAluno;
        private System.Windows.Forms.MaskedTextBox txtEmailAluno;
        private System.Windows.Forms.MaskedTextBox txtRGResponsavel;
        private System.Windows.Forms.MaskedTextBox txtCPFResponsavel;
        private System.Windows.Forms.PictureBox pictCavalo;
    }
}

