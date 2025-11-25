
namespace Bankaccountapp
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BotonAceptar = new Button();
            User = new TextBox();
            password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 53);
            label1.Name = "label1";
            label1.Size = new Size(111, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 149);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(333, 253);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // BotonAceptar
            // 
            BotonAceptar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonAceptar.Location = new Point(319, 364);
            BotonAceptar.Name = "BotonAceptar";
            BotonAceptar.Size = new Size(143, 44);
            BotonAceptar.TabIndex = 3;
            BotonAceptar.Text = "Aceptar";
            BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            User.Location = new Point(308, 191);
            User.Name = "User";
            User.Size = new Size(166, 27);
            User.TabIndex = 4;
            // 
            // password
            // 
            password.Location = new Point(308, 292);
            password.Name = "password";
            password.Size = new Size(177, 27);
            password.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(password);
            Controls.Add(User);
            Controls.Add(BotonAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BotonAceptar;
        private TextBox User;
        private TextBox password;
    }
}