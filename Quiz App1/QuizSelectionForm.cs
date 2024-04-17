using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quiz_App1
{
    public partial class QuizSelectionForm : Form
    {
        private int currentQuestionIndex = 0;
        private int score = 0;
        private int[] questionScores = { 1, 2, 3, 4, 5, 3, 2 };
        private string[] questions = {
            "What is the fastest land animal?",
            "Which bird is known for its ability to mimic human speech?",
            "What is the largest mammal in the world?",
            "Which animal has the longest neck?",
            "What is the only mammal capable of sustained flight?",
            "Which animal is known as the \"King of the Jungle\"?",
            "What is the largest species of bear?"
        };
        private string[][] options = {
            new string[] { "A. Cheetah", "B. Lion", "C. Elephant", "D. Giraffe" },
            new string[] { "A. Parrot", "B. Penguin", "C. Owl", "D. Sparrow" },
            new string[] { "A. Elephant", "B. Blue Whale", "C. Hippopotamus", "D. Giraffe" },
            new string[] { "A. Giraffe", "B. Zebra", "C. Elephant", "D. Lion" },
            new string[] { "A. Bat", "B. Eagle", "C. Sparrow", "D. Penguin" },
            new string[] { "A. Lion", "B. Tiger", "C. Leopard", "D. Cheetah" },
            new string[] { "A. Polar Bear", "B. Grizzly Bear", "C. Panda Bear", "D. Black Bear" }
        };
        private string[] answers = {
            "A", "A", "B", "A", "A", "A", "A"
        };

        private Label lblQuestion;
        private RadioButton Option1;
        private RadioButton Option2;
        private RadioButton Option3;
        private RadioButton Option4;
        private Button next;
        private Button button2;
        private Button retakeQuizButton;
        private Panel panel1;
        private Form1 parentForm;

        public QuizSelectionForm(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadQuestion(); // Load the first question when the form initializes
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                lblQuestion.Text = questions[currentQuestionIndex];
                AdjustPanelWidth();
                Option1.Text = options[currentQuestionIndex][0];
                Option2.Text = options[currentQuestionIndex][1];
                Option3.Text = options[currentQuestionIndex][2];
                Option4.Text = options[currentQuestionIndex][3];
            }
            else
            {
                int totalQuestions = questions.Length;
                double percentage = (double)score / totalQuestions * 100;
                MessageBox.Show("End of questions. Your score: " + score + "/" + totalQuestions + " = " + percentage.ToString("0.##") + "%", "Quiz Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblQuestion = new Label();
            Option1 = new RadioButton();
            Option2 = new RadioButton();
            Option3 = new RadioButton();
            Option4 = new RadioButton();
            next = new Button();
            button2 = new Button();
            retakeQuizButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(lblQuestion);
            panel1.Location = new Point(44, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 190);
            panel1.TabIndex = 0;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 20F);
            lblQuestion.Location = new Point(4, 45);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(90, 37);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            // 
            // Option1
            // 
            Option1.AutoSize = true;
            Option1.Font = new Font("Segoe UI", 15F);
            Option1.Location = new Point(99, 232);
            Option1.Margin = new Padding(4, 3, 4, 3);
            Option1.Name = "Option1";
            Option1.Size = new Size(108, 32);
            Option1.TabIndex = 1;
            Option1.TabStop = true;
            Option1.Text = "Option 1";
            Option1.UseVisualStyleBackColor = true;
            Option1.CheckedChanged += Option1_CheckedChanged;
            // 
            // Option2
            // 
            Option2.AutoSize = true;
            Option2.Font = new Font("Segoe UI", 15F);
            Option2.Location = new Point(99, 287);
            Option2.Margin = new Padding(4, 3, 4, 3);
            Option2.Name = "Option2";
            Option2.Size = new Size(108, 32);
            Option2.TabIndex = 2;
            Option2.TabStop = true;
            Option2.Text = "Option 2";
            Option2.UseVisualStyleBackColor = true;
            Option2.CheckedChanged += Option2_CheckedChanged;
            // 
            // Option3
            // 
            Option3.AutoSize = true;
            Option3.Font = new Font("Segoe UI", 15F);
            Option3.Location = new Point(354, 232);
            Option3.Margin = new Padding(4, 3, 4, 3);
            Option3.Name = "Option3";
            Option3.Size = new Size(108, 32);
            Option3.TabIndex = 3;
            Option3.TabStop = true;
            Option3.Text = "Option 3";
            Option3.UseVisualStyleBackColor = true;
            Option3.CheckedChanged += Option3_CheckedChanged;
            // 
            // Option4
            // 
            Option4.AutoSize = true;
            Option4.Font = new Font("Segoe UI", 15F);
            Option4.Location = new Point(354, 287);
            Option4.Margin = new Padding(4, 3, 4, 3);
            Option4.Name = "Option4";
            Option4.Size = new Size(108, 32);
            Option4.TabIndex = 4;
            Option4.TabStop = true;
            Option4.Text = "Option 4";
            Option4.UseVisualStyleBackColor = true;
            Option4.CheckedChanged += Option4_CheckedChanged;
            // 
            // next
            // 
            next.Font = new Font("Segoe UI", 17F);
            next.Location = new Point(99, 355);
            next.Margin = new Padding(4, 3, 4, 3);
            next.Name = "next";
            next.Size = new Size(380, 67);
            next.TabIndex = 5;
            next.Text = "Next";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 17F);
            button2.Location = new Point(99, 429);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(180, 67);
            button2.TabIndex = 6;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // retakeQuizButton
            // 
            retakeQuizButton.Font = new Font("Segoe UI", 17F);
            retakeQuizButton.Location = new Point(300, 429);
            retakeQuizButton.Margin = new Padding(4, 3, 4, 3);
            retakeQuizButton.Name = "retakeQuizButton";
            retakeQuizButton.Size = new Size(180, 67);
            retakeQuizButton.TabIndex = 7;
            retakeQuizButton.Text = "Retake Quiz";
            retakeQuizButton.UseVisualStyleBackColor = true;
            retakeQuizButton.Click += RetakeQuizButton_Click;
            // 
            // QuizSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 519);
            Controls.Add(retakeQuizButton);
            Controls.Add(button2);
            Controls.Add(next);
            Controls.Add(Option4);
            Controls.Add(Option3);
            Controls.Add(Option2);
            Controls.Add(Option1);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuizSelectionForm";
            Text = "Quiz Selection Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedAnswer = GetSelectedAnswer();
                if (selectedAnswer == answers[currentQuestionIndex])
                {
                    score += questionScores[currentQuestionIndex]; // Increase score based on question weight
                    MessageBox.Show("Correct Answer!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong Answer! Try again", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (currentQuestionIndex < questions.Length - 1)
                {
                    currentQuestionIndex++; // Increment the question index if there are more questions
                    LoadQuestion(); // Load the next question
                }
                else
                {
                    // If it's the last question, calculate and display final score
                    double percentage = (double)score / questionScores.Sum() * 100; // Calculate percentage based on total possible scores
                    int totalPossibleScore = questionScores.Sum();
                    MessageBox.Show("End of questions. Your final score: " + score + "/" + totalPossibleScore + " = " + percentage.ToString("0.##") + "%", "Quiz Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Please select an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("An error occurred. No more questions or invalid question index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) // More general exception catch to diagnose issues
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void next_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++; // Move to the next question
            LoadQuestion(); // Load the next question
        }

        private void RetakeQuizButton_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            score = 0;
            LoadQuestion();
        }

        private string GetSelectedAnswer()
        {
            if (Option1.Checked) return "A";
            if (Option2.Checked) return "B";
            if (Option3.Checked) return "C";
            if (Option4.Checked) return "D";
            throw new InvalidOperationException("No answer selected.");
        }

        private void AdjustPanelWidth()
        {
            // Adjust the width of panel based on the length of the question text
            int questionWidth = TextRenderer.MeasureText(lblQuestion.Text, lblQuestion.Font).Width;
            int maxWidth = questionWidth + 20; // Add padding

            // Set the width of panel to fit the question text
            panel1.Width = maxWidth;
        }

        private void Option1_CheckedChanged(object sender, EventArgs e)
        {
            // Placeholder event handler for Option1_CheckedChanged
            // You can implement this method according to your requirement
        }

        private void Option2_CheckedChanged(object sender, EventArgs e)
        {
            // Placeholder event handler for Option2_CheckedChanged
            // You can implement this method according to your requirement
        }

        private void Option3_CheckedChanged(object sender, EventArgs e)
        {
            // Placeholder event handler for Option3_CheckedChanged
            // You can implement this method according to your requirement
        }

        private void Option4_CheckedChanged(object sender, EventArgs e)
        {
            // Placeholder event handler for Option4_CheckedChanged
            // You can implement this method according to your requirement
        }
    }
}