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
            SuspendLayout();
            // 
            // btn_getPessoas
            // 
            btn_getPessoas.Location = new Point(582, 91);
            btn_getPessoas.Name = "btn_getPessoas";
            btn_getPessoas.Size = new Size(141, 23);
            btn_getPessoas.TabIndex = 0;
            btn_getPessoas.Text = "GET Pessoas";
            btn_getPessoas.UseVisualStyleBackColor = true;
            btn_getPessoas.Click += btn_getPessoas_Click;
            // 
            // btn_getBairros
            // 
            btn_getBairros.Location = new Point(582, 178);
            btn_getBairros.Name = "btn_getBairros";
            btn_getBairros.Size = new Size(141, 23);
            btn_getBairros.TabIndex = 1;
            btn_getBairros.Text = "GET Bairros";
            btn_getBairros.UseVisualStyleBackColor = true;
            btn_getBairros.Click += btn_getBairros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_getBairros);
            Controls.Add(btn_getPessoas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_getPessoas;
        private Button btn_getBairros;
    }
}