# Code explanation
Page là class trống
Các class: SkillsPage,EducationPage,ExperiencePage,IntroductionPage,ResultsPage,ConclusionPage,
SummaryPage,BibliographyPage
Document là một abstract class, có abstract method CreatePages (implementation not yet)
Report and Resume là 2 method kế thừa từ Document, and override CreatePages:
- Report có page bao gồm: IntroductionPage,ResultsPage,ConclusionPage,SummaryPage,BibliographyPage
- Resume có page bao gồm: SkillsPage,EducationPage,ExperiencePage
Hiển nhiên khi thực thi một Array kiểu Document -> chi tiết thưc thi của method CreatePages có thể khác nhau dựa vào Document được
implement bởi Ressume or Report