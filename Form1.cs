namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            List<Horse> horseList = new List<Horse>() { new Horse(1), new Horse(2), new Horse(3) };
            List<ProgressBar> progressList = new List<ProgressBar>() { progressBar1, progressBar2, progressBar3 };
            progressBar1.BackColor = Color.Blue;
            progressBar2.ForeColor = Color.Red;
            progressBar3.ForeColor = Color.Yellow;
            List<Label> progressInt = new List<Label>() { label1, label2, label3 };

            while (true)
            {
                var tasks = new List<Task>() { new Task(horseList[0].Advance), new Task(horseList[1].Advance), new Task(horseList[2].Advance) };
                foreach (var i in tasks)
                {
                    label4.Text = " ";
                    i.Start();
                }

                await Task.WhenAll(tasks);                                                 

                for (int i = 0; i < progressList.Count; i++)
                {
                    progressInt[i].Text = horseList[i].progressPercent.ToString() + '%';
                    progressList[i].Value = horseList[i].RaceLocation;
                    progressList[i].Update();
                }
                var horseHasWon = horseList.Where(h => h.isFinished);

                if (horseHasWon.Any())
                {
                    foreach (var dub in horseHasWon)
                    {
                        label4.Text += $"Winners are: {dub.ID} ";
                    }
                    break;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}