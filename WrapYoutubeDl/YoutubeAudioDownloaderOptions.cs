using System;
using System.Collections.Generic;
using System.Text;

namespace WrapYoutubeDl
{
	// string binaryPath, string url, string outputName, string outputfolder
	public class YoutubeAudioDownloaderOptions
	{
		public string BinaryPath { get; set; }
		public string Url { get; set; }
		public string OutputName { get; set; }
		public string OutputFolder { get; set; }
	}
}
