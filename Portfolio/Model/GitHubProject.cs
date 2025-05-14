namespace Portfolio.Model
{
    public class GitHubProject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stargazers_Count { get; set; }
        public int Forks_Count { get; set; }
        public string Language { get; set; }
        public string Html_Url { get; set; }

        public GitHubProject() { }

        public GitHubProject(string name, string description, int stargazers_Count, int forks_Count, string language, string html_Url)
        {
            Name = name;
            Description = description;
            Stargazers_Count = stargazers_Count;
            Forks_Count = forks_Count;
            Language = language;
            Html_Url = html_Url;
        }
    }
}
