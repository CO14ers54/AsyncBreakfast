namespace AsyncBreakfast
{
    public partial class Form1 : Form
    {
        private bool m_parallelProcessingComplete = true;
        private bool m_syncProcessingComplete = true;
        private bool m_asyncProcessingComplete = true;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Parallel_Click(object sender, EventArgs e)
        {
            m_parallelProcessingComplete = false;
            richTextBox_BreakfastProgress.Text = "";
            btn_Sync.Enabled = false;
            btn_Async.Enabled = false;
            btn_Parallel.Enabled = false;
            btn_runAll.Enabled = false;
            await BreakfastLibrary.MakeBreakfastParallelAsync(this);
        }

        private async void btn_RunAll_Click(object sender, EventArgs e)
        {
            m_asyncProcessingComplete = false;
            m_asyncProcessingComplete = false;
            m_asyncProcessingComplete = false;
            richTextBox_BreakfastProgressAsync.Text = "";
            richTextBox_BreakfastProgressSync.Text = "";
            richTextBox_BreakfastProgress.Text = "";
            btn_Sync.Enabled = false;
            btn_Async.Enabled = false;
            btn_Parallel.Enabled = false;
            btn_runAll.Enabled = false;
            BreakfastLibrary.MakeBreakfastSync(this);
            BreakfastLibrary.MakeBreakfastAsync(this);
            BreakfastLibrary.MakeBreakfastParallelAsync(this);
        }

        private void btn_Sync_Click(object sender, EventArgs e)
        {
            m_syncProcessingComplete = false;
            richTextBox_BreakfastProgressSync.Text = "";
            btn_Sync.Enabled = false;
            btn_Async.Enabled = false;
            btn_Parallel.Enabled = false;
            btn_runAll.Enabled = false;
            BreakfastLibrary.MakeBreakfastSync(this);
        }

        public void ProcessingComplete(ProcessingTypeEnum processTypeEnum)
        {
            switch (processTypeEnum)
            {
                case ProcessingTypeEnum.SYNC:
                    m_syncProcessingComplete = true;
                    btn_Sync.Enabled = true;
                    btn_Async.Enabled = true;
                    btn_Parallel.Enabled = true;
                    break;
                case ProcessingTypeEnum.ASYNC:
                    m_asyncProcessingComplete = true;
                    btn_Sync.Enabled= true;
                    btn_Async.Enabled= true;
                    btn_Parallel.Enabled= true;
                    break;
                case ProcessingTypeEnum.PARALLEL:
                    m_parallelProcessingComplete = true;
                    btn_Sync.Enabled = true;
                    btn_Async.Enabled = true;
                    btn_Parallel.Enabled = true;
                    break;
                default:
                    break;
            }

            if (m_asyncProcessingComplete && m_syncProcessingComplete && m_parallelProcessingComplete)
                btn_runAll.Enabled = true;

        }

        public void WriteTextToRichTextBox(RichTextBox richTextBox, string text)
        {
            richTextBox.Text += text;
        }
    }
}