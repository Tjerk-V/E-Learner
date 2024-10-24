namespace ADR_Cursus
{
    public partial class ADRcursus : Form
    {

        Page CurrentPage;

        private List<Page> Pages;
        private int currentPageIndex = 0;

        public ADRcursus()
        {
            InitializeComponent();
            Pages = PagesCollector.GetPagesFromJson();

            foreach (var page in Pages)
            {
                page.AnswerChanged += (sender, e) =>
                {
                    CheckAllQuestionsAnswered();
                };
            }

            ShowCurrentPage();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            currentPageIndex--;
            if (currentPageIndex < 0)
                currentPageIndex = 0;
            ShowCurrentPage();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            currentPageIndex++;
            if (currentPageIndex > Pages.Count - 1)
            {
                currentPageIndex = Pages.Count - 1;
                SendForm sendForm = new(Pages);
                if(sendForm.ShowDialog(this) == DialogResult.Continue)
                {
                    Close();
                }
            }
            ShowCurrentPage();
        }

        private void ShowCurrentPage()
        {
            CurrentPage = Pages[currentPageIndex];

            ClearPageContainer();
            AddCurrentPageToContainer();
            CheckAllQuestionsAnswered();
        }

        
        private void ClearPageContainer()
        {
            pageContainer.Controls.Clear();
        }

        private void AddCurrentPageToContainer()
        {
            CurrentPage.Dock = DockStyle.Fill;
            pageContainer.Controls.Add(CurrentPage);
        }

        private void CheckAllQuestionsAnswered()
        {
            Next.Enabled = CurrentPage.AreAllQuestionsAnswered;
        }
    }
}