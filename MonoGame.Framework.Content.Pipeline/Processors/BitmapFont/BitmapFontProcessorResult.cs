// --------------------------------------------------------------------
//                             BitmapFontProcessorResult.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System.Collections.Generic;

namespace DarzasDominion.Content.Pipeline
{
	public class BitmapFontProcessorResult
	{
		public List<BitmapFontPage> TextureAssets { get; }
		public BitmapFontFile FontFile { get; }

		public BitmapFontProcessorResult(BitmapFontFile fontFile)
		{
			FontFile = fontFile;
			TextureAssets = new List<BitmapFontPage>();
		}
	}
}