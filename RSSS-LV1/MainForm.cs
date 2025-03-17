namespace RSSS_LV1;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    int? criticalValue;
    string? filePath;

    void NextButton_Click(object sender, EventArgs e)
    {
        string value = this.criticalValueTextBox.Text;
        if (!int.TryParse(value, out int criticalValue))
        {
            MessageBox.Show("Value needs to be an integer.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        this.criticalValue = criticalValue;

        if (filePath is null)
        {
            MessageBox.Show("No file selected.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ResultForm resultForm = new(this, criticalValue, filePath);
        resultForm.Show();
        this.Hide();
    }

    private void SelectFileButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new()
        {
            Filter = "TextFiles|*.txt"
        };

        if(openFileDialog.ShowDialog() == DialogResult.OK)
        {
            filePath = openFileDialog.FileName;
            selectedFileLabel.Text = filePath;
        }
    }
}
