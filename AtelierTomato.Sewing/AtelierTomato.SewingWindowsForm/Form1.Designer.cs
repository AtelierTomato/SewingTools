namespace AtelierTomato.SewingWindowsForm
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
			title = new Label();
			buttonFabric = new Button();
			buttonImage = new Button();
			buttonReturn = new Button();
			SuspendLayout();
			// 
			// title
			// 
			title.Anchor = AnchorStyles.None;
			title.AutoSize = true;
			title.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			title.Location = new Point(308, 9);
			title.Name = "title";
			title.Size = new Size(184, 39);
			title.TabIndex = 0;
			title.Text = "Sewing Tools";
			title.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// buttonFabric
			// 
			buttonFabric.Location = new Point(300, 172);
			buttonFabric.Name = "buttonFabric";
			buttonFabric.Size = new Size(200, 50);
			buttonFabric.TabIndex = 1;
			buttonFabric.Text = "fabric";
			buttonFabric.UseVisualStyleBackColor = true;
			buttonFabric.Click += fabricButtonClick;
			// 
			// buttonImage
			// 
			buttonImage.Location = new Point(300, 228);
			buttonImage.Name = "buttonImage";
			buttonImage.Size = new Size(200, 50);
			buttonImage.TabIndex = 2;
			buttonImage.Text = "image";
			buttonImage.UseVisualStyleBackColor = true;
			buttonImage.Click += imageButtonClick;
			// 
			// returnButton
			// 
			buttonReturn.Location = new Point(350, 413);
			buttonReturn.Name = "returnButton";
			buttonReturn.Size = new Size(100, 25);
			buttonReturn.TabIndex = 3;
			buttonReturn.Text = "return";
			buttonReturn.TextImageRelation = TextImageRelation.TextAboveImage;
			buttonReturn.UseVisualStyleBackColor = true;
			buttonReturn.Visible = false;
			buttonReturn.Click += returnButtonClick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonReturn);
			Controls.Add(buttonImage);
			Controls.Add(buttonFabric);
			Controls.Add(title);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label title;
		private Button buttonFabric;
		private Button buttonImage;
		private Button buttonReturn;
	}
}
