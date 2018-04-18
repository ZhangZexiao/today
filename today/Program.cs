namespace today
{
	class Program
	{
		[System.STAThread]
		static void Main(string[]args)
		{
			System.Windows.Clipboard.SetText(System.DateTime.Now.ToString("yyyyMMdd"));
		}
	}
}
