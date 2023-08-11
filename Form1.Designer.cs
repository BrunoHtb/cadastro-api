namespace TesteAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_getPessoas = new Button();
            btn_getBairros = new Button();
            btn_postPessoas = new Button();
            btn_postPessoasMultiElemento = new Button();
            btn_postImoveisMultiElemento = new Button();
            btn_postImoveisMultiElementoUPDATE = new Button();
            btn_getPessoasTripaCPF = new Button();
            btn_getImoveisIndividual = new Button();
            SuspendLayout();
            // 
            // btn_getPessoas
            // 
            btn_getPessoas.Location = new Point(144, 39);
            btn_getPessoas.Name = "btn_getPessoas";
            btn_getPessoas.Size = new Size(182, 23);
            btn_getPessoas.TabIndex = 0;
            btn_getPessoas.Text = "GET Pessoas INDIVIDUAL";
            btn_getPessoas.UseVisualStyleBackColor = true;
            btn_getPessoas.Click += btn_getPessoas_Click_1;
            // 
            // btn_getBairros
            // 
            btn_getBairros.Location = new Point(144, 80);
            btn_getBairros.Name = "btn_getBairros";
            btn_getBairros.Size = new Size(182, 23);
            btn_getBairros.TabIndex = 1;
            btn_getBairros.Text = "GET Bairros INDIVIDUAL";
            btn_getBairros.UseVisualStyleBackColor = true;
            btn_getBairros.Click += btn_getBairros_Click;
            // 
            // btn_postPessoas
            // 
            btn_postPessoas.Location = new Point(144, 124);
            btn_postPessoas.Name = "btn_postPessoas";
            btn_postPessoas.Size = new Size(182, 23);
            btn_postPessoas.TabIndex = 2;
            btn_postPessoas.Text = "POST Pessoas INDIVIDUAL";
            btn_postPessoas.UseVisualStyleBackColor = true;
            btn_postPessoas.Click += btn_postPessoas_Click;
            // 
            // btn_postPessoasMultiElemento
            // 
            btn_postPessoasMultiElemento.Location = new Point(485, 39);
            btn_postPessoasMultiElemento.Name = "btn_postPessoasMultiElemento";
            btn_postPessoasMultiElemento.Size = new Size(260, 23);
            btn_postPessoasMultiElemento.TabIndex = 3;
            btn_postPessoasMultiElemento.Text = "POST Pessoas Tripa";
            btn_postPessoasMultiElemento.UseVisualStyleBackColor = true;
            btn_postPessoasMultiElemento.Click += btn_postPessoasMultiElemento_Click;
            // 
            // btn_postImoveisMultiElemento
            // 
            btn_postImoveisMultiElemento.Location = new Point(485, 80);
            btn_postImoveisMultiElemento.Name = "btn_postImoveisMultiElemento";
            btn_postImoveisMultiElemento.Size = new Size(260, 23);
            btn_postImoveisMultiElemento.TabIndex = 4;
            btn_postImoveisMultiElemento.Text = "POST Imoveis Tripa (Imoveis NOVOS)";
            btn_postImoveisMultiElemento.UseVisualStyleBackColor = true;
            btn_postImoveisMultiElemento.Click += btn_postImoveisMultiElemento_Click;
            // 
            // btn_postImoveisMultiElementoUPDATE
            // 
            btn_postImoveisMultiElementoUPDATE.Location = new Point(485, 124);
            btn_postImoveisMultiElementoUPDATE.Name = "btn_postImoveisMultiElementoUPDATE";
            btn_postImoveisMultiElementoUPDATE.Size = new Size(260, 23);
            btn_postImoveisMultiElementoUPDATE.TabIndex = 5;
            btn_postImoveisMultiElementoUPDATE.Text = "POST Imoveis Tripe (UPDATE)";
            btn_postImoveisMultiElementoUPDATE.UseVisualStyleBackColor = true;
            btn_postImoveisMultiElementoUPDATE.Click += btn_postImoveisMultiElementoUPDATE_Click;
            // 
            // btn_getPessoasTripaCPF
            // 
            btn_getPessoasTripaCPF.Location = new Point(163, 373);
            btn_getPessoasTripaCPF.Name = "btn_getPessoasTripaCPF";
            btn_getPessoasTripaCPF.Size = new Size(163, 23);
            btn_getPessoasTripaCPF.TabIndex = 6;
            btn_getPessoasTripaCPF.Text = "GET Pessoas Tripa CPF";
            btn_getPessoasTripaCPF.UseVisualStyleBackColor = true;
            btn_getPessoasTripaCPF.Click += btn_getPessoasTripaCPF_Click;
            // 
            // btn_getImoveisIndividual
            // 
            btn_getImoveisIndividual.Location = new Point(144, 194);
            btn_getImoveisIndividual.Name = "btn_getImoveisIndividual";
            btn_getImoveisIndividual.Size = new Size(182, 23);
            btn_getImoveisIndividual.TabIndex = 7;
            btn_getImoveisIndividual.Text = "GET Imoveis Individual";
            btn_getImoveisIndividual.UseVisualStyleBackColor = true;
            btn_getImoveisIndividual.Click += btn_getImoveisIndividual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_getImoveisIndividual);
            Controls.Add(btn_getPessoasTripaCPF);
            Controls.Add(btn_postImoveisMultiElementoUPDATE);
            Controls.Add(btn_postImoveisMultiElemento);
            Controls.Add(btn_postPessoasMultiElemento);
            Controls.Add(btn_postPessoas);
            Controls.Add(btn_getBairros);
            Controls.Add(btn_getPessoas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_getPessoas;
        private Button btn_getBairros;
        private Button btn_postPessoas;
        private Button btn_postPessoasMultiElemento;
        private Button btn_postImoveisMultiElemento;
        private Button btn_postImoveisMultiElementoUPDATE;
        private Button btn_getPessoasTripaCPF;
        private Button btn_getImoveisIndividual;
    }
}