using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.SelectedItem = "GET";
    }

    private async void callApiButton_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultsText.Text = "";

        // Validate the API URL
        if (api.IsValidUrl(apiText.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        HttpAction action;
        if (!Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action))
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        try
        {
            resultsText.Text = await api.CallApiAsync(apiText.Text, true, action);
            callData.SelectedTab = resultsTab;
            resultsTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void apiLabel_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void resultsText_TextChanged(object sender, EventArgs e)
    {

    }
}
