namespace AtelierTomato.SewingWindowsForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void fabricButtonClick(object sender, EventArgs e)
		{
			title.Text = "Fabric";
			title.Left = (ClientSize.Width / 2) - (title.Width / 2);
			buttonFabric.Visible = false;
			buttonImage.Visible = false;
			addFabricButton.Visible = true;
			editFabricButton.Visible = true;
			addSquareButton.Visible = true;
			removeSquareButton.Visible = true;
			addTriangleButton.Visible = true;
			removeTriangleButton.Visible = true;
			buttonReturn.Visible = true;
		}

		private void imageButtonClick(object sender, EventArgs e)
		{
			title.Text = "Image";
			title.Left = (ClientSize.Width / 2) - (title.Width / 2);
			buttonFabric.Visible = false;
			buttonImage.Visible = false;
			buttonReturn.Visible = true;
		}

		private void returnButtonClick(object sender, EventArgs e)
		{
			title.Text = "Sewing Tools";
			title.Left = (ClientSize.Width / 2) - (title.Width / 2);
			buttonFabric.Visible = true;
			buttonImage.Visible = true;
			addFabricButton.Visible = false;
			editFabricButton.Visible = false;
			addSquareButton.Visible = false;
			removeSquareButton.Visible = false;
			addTriangleButton.Visible = false;
			removeTriangleButton.Visible = false;
			buttonReturn.Visible = false;
		}
	}
}
