namespace Name_Formatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFormatName_Click(object sender, EventArgs e)
        {
            String firstName = textBoxFirstName.Text;
            String middleName = textBoxMiddleName.Text;
            String lastName = textBoxLastName.Text;
            String preferredTitle = textBoxPreferredTitle.Text;

            String format1 = preferredTitle + " " + firstName + " " + middleName + " " + lastName;
            String format2 = firstName + " " + middleName + " " + lastName;
            String format3 = firstName + " " + lastName;
            String format4 = lastName + ", " + firstName + " " + middleName + " " + preferredTitle;
            String format5 = lastName + ", " + firstName + " " + lastName;
            String format6 = lastName + ", " + firstName;

            labelFormattedNames.Text = format1 + "\n" + format2 + "\n" + format3 + "\n" + format4 + "\n" + format5 + "\n" + format6;
        }
    }
}