namespace Security_Final_project
{
	public static class Program
	{

		[STAThread]
		static void Main()
		{

			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
	}
}