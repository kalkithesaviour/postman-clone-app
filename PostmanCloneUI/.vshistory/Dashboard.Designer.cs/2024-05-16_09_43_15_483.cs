namespace PostmanCloneUI;

partial class Dashboard
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
        formHeader = new Label();
        apiLabel = new Label();
        apiText = new TextBox();
        resultsText = new TextBox();
        callApiButton = new Button();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        httpVerbSelection = new ComboBox();
        callData = new TabControl();
        bodyTab = new TabPage();
        bodyText = new TextBox();
        resultsTab = new TabPage();
        statusStrip.SuspendLayout();
        callData.SuspendLayout();
        bodyTab.SuspendLayout();
        resultsTab.SuspendLayout();
        SuspendLayout();
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(35, -2);
        formHeader.Margin = new Padding(2, 0, 2, 0);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(372, 70);
        formHeader.TabIndex = 0;
        formHeader.Text = "Postman Clone";
        // 
        // apiLabel
        // 
        apiLabel.Location = new Point(35, 67);
        apiLabel.Margin = new Padding(2, 0, 2, 0);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(81, 56);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API:";
        apiLabel.Click += apiLabel_Click;
        // 
        // apiText
        // 
        apiText.Location = new Point(272, 68);
        apiText.Margin = new Padding(2);
        apiText.Name = "apiText";
        apiText.Size = new Size(459, 55);
        apiText.TabIndex = 2;
        // 
        // resultsText
        // 
        resultsText.BackColor = Color.White;
        resultsText.BorderStyle = BorderStyle.FixedSingle;
        resultsText.Dock = DockStyle.Fill;
        resultsText.Location = new Point(3, 3);
        resultsText.Margin = new Padding(2);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.ReadOnly = true;
        resultsText.ScrollBars = ScrollBars.Both;
        resultsText.Size = new Size(767, 405);
        resultsText.TabIndex = 3;
        resultsText.TextChanged += resultsText_TextChanged;
        // 
        // callApiButton
        // 
        callApiButton.Location = new Point(735, 68);
        callApiButton.Margin = new Padding(2);
        callApiButton.Name = "callApiButton";
        callApiButton.Size = new Size(81, 56);
        callApiButton.TabIndex = 4;
        callApiButton.Text = "Go";
        callApiButton.UseVisualStyleBackColor = true;
        callApiButton.Click += callApiButton_Click;
        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.Transparent;
        statusStrip.ImageScalingSize = new Size(24, 24);
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 597);
        statusStrip.Name = "statusStrip";
        statusStrip.Padding = new Padding(1, 0, 10, 0);
        statusStrip.Size = new Size(849, 39);
        statusStrip.TabIndex = 5;
        statusStrip.Text = "statusStrip1";
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(78, 32);
        systemStatus.Text = "Ready";
        // 
        // httpVerbSelection
        // 
        httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
        httpVerbSelection.FormattingEnabled = true;
        httpVerbSelection.Items.AddRange(new object[] { "GET", "POST" });
        httpVerbSelection.Location = new Point(121, 67);
        httpVerbSelection.Name = "httpVerbSelection";
        httpVerbSelection.Size = new Size(146, 56);
        httpVerbSelection.TabIndex = 7;
        httpVerbSelection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // callData
        // 
        callData.Controls.Add(bodyTab);
        callData.Controls.Add(resultsTab);
        callData.Location = new Point(35, 145);
        callData.Name = "callData";
        callData.SelectedIndex = 0;
        callData.Size = new Size(781, 449);
        callData.TabIndex = 8;
        // 
        // bodyTab
        // 
        bodyTab.Controls.Add(bodyText);
        bodyTab.Location = new Point(4, 57);
        bodyTab.Name = "bodyTab";
        bodyTab.Padding = new Padding(3);
        bodyTab.Size = new Size(773, 388);
        bodyTab.TabIndex = 0;
        bodyTab.Text = "Body";
        bodyTab.UseVisualStyleBackColor = true;
        // 
        // bodyText
        // 
        bodyText.BackColor = Color.White;
        bodyText.BorderStyle = BorderStyle.FixedSingle;
        bodyText.Dock = DockStyle.Fill;
        bodyText.Location = new Point(3, 3);
        bodyText.Margin = new Padding(2);
        bodyText.Multiline = true;
        bodyText.Name = "bodyText";
        bodyText.ScrollBars = ScrollBars.Both;
        bodyText.Size = new Size(767, 382);
        bodyText.TabIndex = 4;
        // 
        // resultsTab
        // 
        resultsTab.Controls.Add(resultsText);
        resultsTab.Location = new Point(4, 34);
        resultsTab.Name = "resultsTab";
        resultsTab.Padding = new Padding(3);
        resultsTab.Size = new Size(773, 411);
        resultsTab.TabIndex = 1;
        resultsTab.Text = "Results";
        resultsTab.UseVisualStyleBackColor = true;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(20F, 48F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(849, 636);
        Controls.Add(callData);
        Controls.Add(httpVerbSelection);
        Controls.Add(statusStrip);
        Controls.Add(callApiButton);
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(formHeader);
        Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Dashboard";
        Text = "Postman Clone by Vishal Singh Adhikari";
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        callData.ResumeLayout(false);
        bodyTab.ResumeLayout(false);
        bodyTab.PerformLayout();
        resultsTab.ResumeLayout(false);
        resultsTab.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label formHeader;
    private Label apiLabel;
    private TextBox apiText;
    private TextBox resultsText;
    private Button callApiButton;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
    private ComboBox httpVerbSelection;
    private TabControl callData;
    private TabPage bodyTab;
    private TabPage resultsTab;
    private TextBox bodyText;
}
