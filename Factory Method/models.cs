namespace Factory_Method
{
    abstract class Page
    {
    }

    class SkillsPage : Page
    {
    }

    class EducationPage : Page
    {
    }

    class ExperiencePage : Page
    {
    }


    class IntroductionPage : Page
    {
    }

    class ResultsPage : Page
    {
    }

    class ConclusionPage : Page
    {
    }


    class SummaryPage : Page
    {
    }


    class BibliographyPage : Page
    {
    }

    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method

        public abstract void CreatePages();
    }


    class Resume : Document
    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    class Report : Document
    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}