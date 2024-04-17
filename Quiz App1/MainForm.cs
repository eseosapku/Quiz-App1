using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz_App1
{
    public partial class Form1 : Form
    {
        private Button AnimalQuiz;
        private Button btnCarQuiz;
        private Button btnMusicQuiz;
        private Button btnAnimalQuiz;
        private Button CarQuiz;
        private Button MusicQuiz;
        private Label label1;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AnimalQuiz = new Button();
            CarQuiz = new Button();
            MusicQuiz = new Button();
            label1 = new Label();
            SuspendLayout();

            // 
            // AnimalQuiz
            // 
            AnimalQuiz.Location = new Point(28, 216);
            AnimalQuiz.Name = "AnimalQuiz";
            AnimalQuiz.Size = new Size(125, 48);
            AnimalQuiz.TabIndex = 0;
            AnimalQuiz.Text = "Animal Quiz";
            AnimalQuiz.UseVisualStyleBackColor = true;
            AnimalQuiz.Click += new EventHandler(btnAnimalQuiz_Click); // Attach event handler
            // 
            // CarQuiz
            // 
            CarQuiz.Location = new Point(159, 216);
            CarQuiz.Name = "CarQuiz";
            CarQuiz.Size = new Size(125, 48);
            CarQuiz.TabIndex = 1;
            CarQuiz.Text = "Car Quiz";
            CarQuiz.UseVisualStyleBackColor = true;
            // 
            // MusicQuiz
            // 
            MusicQuiz.Location = new Point(290, 216);
            MusicQuiz.Name = "MusicQuiz";
            MusicQuiz.Size = new Size(125, 48);
            MusicQuiz.TabIndex = 2;
            MusicQuiz.Text = "Music Quiz";
            MusicQuiz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 112);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            ClientSize = new Size(447, 378);
            Controls.Add(label1);
            Controls.Add(MusicQuiz);
            Controls.Add(CarQuiz);
            Controls.Add(AnimalQuiz);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

            Controls.Add(label1);
            Controls.Add(MusicQuiz);
            Controls.Add(CarQuiz);
            Controls.Add(AnimalQuiz);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAnimalQuiz_Click(object sender, EventArgs e)
        {
            
            //open the form
            QuizSelectionForm quizSelectionForm = new QuizSelectionForm(this);
            quizSelectionForm.Show();
            this.Hide();
        }

        private void btnCarQuiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This quiz is under development.");
        }

        private void btnMusicQuiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This quiz is under development.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Implementation of button1_Click method goes here
            // Omitted for brevity
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Implementation of Form1_Load method goes here
            // Omitted for brevity
        }
    }
}