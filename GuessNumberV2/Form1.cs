namespace GuessNumberV2
{
    public partial class Form1 : Form
    {
        private readonly StateMachine _stateMachine = new();

        public Form1()
        {
            InitializeComponent();
            _stateMachine.OnStart = DoStart;
            _stateMachine.OnGuess = DoGuess;
            _stateMachine.OnWin = DoWin;
            _stateMachine.OnLose = DoLose;
            lblMessageTextBox.Text = "Enter your name";
            btnAction.Text = "Start";
        }

        private void DoStart()
        {
            MessageBox.Show(@$"Let's Rock, {_stateMachine.Player}!");
            RefreshForm();
        }

        private void DoGuess()
        {
            RefreshForm();
        }

        private void DoWin()
        {
            MessageBox.Show($@"Yeah! GG! You Rock, the Magic Number is {_stateMachine.Number}");
            RefreshForm();
        }

        private void DoLose()
        {
            MessageBox.Show($@"Oops! Press 'F' to show respect! The Magic Number is {_stateMachine.Number}");
            RefreshForm();
        }

        private void RefreshForm()
        {
            lblPlayerName.Text = $@"Player: {_stateMachine.Player}";
            lblPoints.Text = $@"Points: {_stateMachine.Points}";
            lblLastGuess.Text = $@"Try: {_stateMachine.Guesses+1}/10";
            lblGameMessage.Text = _stateMachine.Message;
            lblMessageTextBox.Text = @"Guess a number between 1 and 1000";
            btnAction.Text = @"Confirm Guess";
            textBoxInput.Text = "";
            textBoxInput.Focus();
        }



        private void btnAction_Click(object sender, EventArgs e)
        {
            _stateMachine.Update(textBoxInput.Text);
        }
    }
}
