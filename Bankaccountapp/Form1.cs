namespace Bankaccountapp
{
    public partial class Form1 : Form
    {

        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Ownertext.Text))
            {

                MessageBox.Show(" Debes ingresar un nombre ");

                return;
            }

            
        

            BankAccount bankAccount = new BankAccount(Ownertext.Text);
            BankAccounts.Add(bankAccount);
            RefreshGrid();
            Ownertext.Clear();

        }

        public void RefreshGrid()
        {

            AccountGrid.DataSource = null;
            AccountGrid.DataSource = BankAccounts;


        }

        private void Depositbtn_Click(object sender, EventArgs e)
        {
            if (AccountGrid.SelectedRows.Count == 1 && Amountbar.Value > 0)

            {
                BankAccount selectedBankAccount = AccountGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.deposit(Amountbar.Value);
                RefreshGrid();
                Amountbar.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {


            if (AccountGrid.SelectedRows.Count == 1 && Amountbar.Value > 0)

            {
                BankAccount selectedBankAccount = AccountGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw (Amountbar.Value);
                RefreshGrid();
                Amountbar.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
