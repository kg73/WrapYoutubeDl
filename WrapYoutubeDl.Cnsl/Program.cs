﻿using System;
using System.IO;

namespace WrapYoutubeDl.Cnsl
{
	class song
	{
		public string name { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{

			var mp3OutputFolder = Path.Combine(Directory.GetCurrentDirectory(), "Audio");

			var downloader = new AudioDownloader(Path.Combine(Directory.GetCurrentDirectory(), "Binaries"), "https://www.youtube.com/watch?v=enBllfqkMEw", Guid.NewGuid().ToString(), mp3OutputFolder);
			downloader.ProcessObject = new song();
			downloader.ProgressDownload += downloader_ProgressDownload;
			downloader.FinishedDownload += downloader_FinishedDownload;
			downloader.Download();


			Console.ReadLine();
		}

		static void downloader_FinishedDownload(object sender, DownloadEventArgs e)
		{
			var song = e.ProcessObject as song;
			Console.WriteLine("Finished {0}", song.name);
		}

		static void downloader_ProgressDownload(object sender, ProgressEventArgs e)
		{
			Console.WriteLine("[progress {0}]", e.Percentage);
		}

	}
}
