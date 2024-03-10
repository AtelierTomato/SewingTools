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
			addFabricButton = new Button();
			editFabricButton = new Button();
			addSquareButton = new Button();
			removeSquareButton = new Button();
			addTriangleButton = new Button();
			removeTriangleButton = new Button();
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
			// buttonReturn
			// 
			buttonReturn.Location = new Point(350, 413);
			buttonReturn.Name = "buttonReturn";
			buttonReturn.Size = new Size(100, 25);
			buttonReturn.TabIndex = 3;
			buttonReturn.Text = "return";
			buttonReturn.TextImageRelation = TextImageRelation.TextAboveImage;
			buttonReturn.UseVisualStyleBackColor = true;
			buttonReturn.Visible = false;
			buttonReturn.Click += returnButtonClick;
			// 
			// addFabricButton
			// 
			addFabricButton.Location = new Point(197, 144);
			addFabricButton.Name = "addFabricButton";
			addFabricButton.Size = new Size(200, 50);
			addFabricButton.TabIndex = 4;
			addFabricButton.Text = "add fabric";
			addFabricButton.UseVisualStyleBackColor = true;
			addFabricButton.Visible = false;
			// 
			// editFabricButton
			// 
			editFabricButton.Location = new Point(403, 144);
			editFabricButton.Name = "editFabricButton";
			editFabricButton.Size = new Size(200, 50);
			editFabricButton.TabIndex = 5;
			editFabricButton.Text = "edit fabric";
			editFabricButton.UseVisualStyleBackColor = true;
			editFabricButton.Visible = false;
			// 
			// addSquareButton
			// 
			addSquareButton.Location = new Point(197, 200);
			addSquareButton.Name = "addSquareButton";
			addSquareButton.Size = new Size(200, 50);
			addSquareButton.TabIndex = 6;
			addSquareButton.Text = "add fabric square";
			addSquareButton.UseVisualStyleBackColor = true;
			addSquareButton.Visible = false;
			// 
			// removeSquareButton
			// 
			removeSquareButton.Location = new Point(403, 200);
			removeSquareButton.Name = "removeSquareButton";
			removeSquareButton.Size = new Size(200, 50);
			removeSquareButton.TabIndex = 7;
			removeSquareButton.Text = "remove fabric square";
			removeSquareButton.UseVisualStyleBackColor = true;
			removeSquareButton.Visible = false;
			// 
			// addTriangleButton
			// 
			addTriangleButton.Location = new Point(197, 256);
			addTriangleButton.Name = "addTriangleButton";
			addTriangleButton.Size = new Size(200, 50);
			addTriangleButton.TabIndex = 8;
			addTriangleButton.Text = "add fabric triangle";
			addTriangleButton.UseVisualStyleBackColor = true;
			addTriangleButton.Visible = false;
			// 
			// removeTriangleButton
			// 
			removeTriangleButton.Location = new Point(403, 256);
			removeTriangleButton.Name = "removeTriangleButton";
			removeTriangleButton.Size = new Size(200, 50);
			removeTriangleButton.TabIndex = 9;
			removeTriangleButton.Text = "remove fabric triangle";
			removeTriangleButton.UseVisualStyleBackColor = true;
			removeTriangleButton.Visible = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(removeTriangleButton);
			Controls.Add(addTriangleButton);
			Controls.Add(removeSquareButton);
			Controls.Add(addSquareButton);
			Controls.Add(editFabricButton);
			Controls.Add(addFabricButton);
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
		private Button addFabricButton;
		private Button editFabricButton;
		private Button addSquareButton;
		private Button removeSquareButton;
		private Button addTriangleButton;
		private Button removeTriangleButton;
	}
}
