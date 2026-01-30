using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace ColorschemeUtils;

public class Program
{
	public static void Main()
	{
		string riderJsonFilepath = "/mnt/Rikai/Projects/Programming/Colorschemes/Moonlight/Moonlight.theme.json";
		
		PublishRiderJson(riderJsonFilepath);
	}

	static void PublishRiderJson(string filePath)
	{
		using (StreamWriter sw = new StreamWriter(filePath))
		{
			sw.Write(ThemeTranslator.RiderJson(ColorScheme.Rider));
		}
	}
}