namespace Assignment1.Jacob.WindowsForm.V2
{
    public partial class FormMenu : Form
    {
        private readonly DataAccessLayer _layer;
        public FormMenu()
        {
             _layer = new ();
            InitializeComponent();
           
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if(textBoxFirstNameCustomer.Text == "" || textBoxLastNameCustomer.Text == "")
            {
                labelResponseCustomer.Text = "Please insert a First name and a Last name!";
            }

            else
            {

                string firstName = textBoxFirstNameCustomer.Text;
                string lastName = textBoxLastNameCustomer.Text;
                _layer.AddCustomer(firstName, lastName);

            }


        }

 
    }
}