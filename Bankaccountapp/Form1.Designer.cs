namespace Bankaccountapp
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
            label1 = new Label();
            label3 = new Label();
            Ownertext = new TextBox();
            Amountbar = new NumericUpDown();
            AccountGrid = new DataGridView();
            Depositbtn = new Button();
            withdrawbtn = new Button();
            newaccountbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Amountbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 439);
            label3.Name = "label3";
            label3.Size = new Size(127, 38);
            label3.TabIndex = 2;
            label3.Text = "Amount:";
            label3.Click += label3_Click;
            // 
            // Ownertext
            // 
            Ownertext.Location = new Point(118, 49);
            Ownertext.Name = "Ownertext";
            Ownertext.Size = new Size(234, 27);
            Ownertext.TabIndex = 3;
            // 
            // Amountbar
            // 
            Amountbar.Location = new Point(176, 439);
            Amountbar.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            Amountbar.Name = "Amountbar";
            Amountbar.Size = new Size(283, 27);
            Amountbar.TabIndex = 4;
            Amountbar.ValueChanged += AmountNum_ValueChanged;
            // 
            // AccountGrid
            // 
            AccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountGrid.Location = new Point(429, 135);
            AccountGrid.Name = "AccountGrid";
            AccountGrid.RowHeadersWidth = 51;
            AccountGrid.Size = new Size(495, 264);
            AccountGrid.TabIndex = 5;
            AccountGrid.VirtualMode = true;
            AccountGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Depositbtn
            // 
            Depositbtn.Location = new Point(515, 446);
            Depositbtn.Name = "Depositbtn";
            Depositbtn.Size = new Size(170, 56);
            Depositbtn.TabIndex = 6;
            Depositbtn.Text = "Deposit";
            Depositbtn.UseVisualStyleBackColor = true;
            Depositbtn.Click += Depositbtn_Click;
            // 
            // withdrawbtn
            // 
            withdrawbtn.Location = new Point(760, 446);
            withdrawbtn.Name = "withdrawbtn";
            withdrawbtn.Size = new Size(149, 56);
            withdrawbtn.TabIndex = 7;
            withdrawbtn.Text = "Withdraw";
            withdrawbtn.UseVisualStyleBackColor = true;
            withdrawbtn.Click += withdrawbtn_Click;
            // 
            // newaccountbtn
            // 
            newaccountbtn.Location = new Point(137, 82);
            newaccountbtn.Name = "newaccountbtn";
            newaccountbtn.Size = new Size(198, 60);
            newaccountbtn.TabIndex = 8;
            newaccountbtn.Text = "Create account";
            newaccountbtn.UseVisualStyleBackColor = true;
            newaccountbtn.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 558);
            Controls.Add(newaccountbtn);
            Controls.Add(withdrawbtn);
            Controls.Add(Depositbtn);
            Controls.Add(AccountGrid);
            Controls.Add(Amountbar);
            Controls.Add(Ownertext);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Amountbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox Ownertext;
        private NumericUpDown Amountbar;
        private DataGridView AccountGrid;
        private Button Depositbtn;
        private Button withdrawbtn;
        private Button newaccountbtn;
    }
}
