namespace People;

public partial class App : Application
{
    // TODO: Add a public static PersonRepository property
    public static PersonRepository PersonRepo { get; set; }

    public App(PersonRepository personRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();
        PersonRepo = personRepository;
        // TODO: Initialize the PersonRepository property with the PersonRespository singleton object

    }
}
