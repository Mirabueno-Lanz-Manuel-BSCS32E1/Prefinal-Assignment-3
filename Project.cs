private void Project_Load(object sender, EventArgs e)
{
    Label helloLabel = new Label();
    helloLabel.Text = "Hello ";
    helloLabel.Location = new Point(50, 50);
    this.Controls.Add(helloLabel);
}