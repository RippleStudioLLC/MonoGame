// --------------------------------------------------------------------
//                             BitmapFontProcessor.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System;
using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace DarzasDominion.Content.Pipeline
{
	[ContentProcessor(DisplayName = "Font Processor - Darza's Dominion")]
	public class BitmapFontProcessor : ContentProcessor<BitmapFontFile, BitmapFontProcessorResult>
	{
		public override BitmapFontProcessorResult Process(BitmapFontFile bitmapFontFile,
			ContentProcessorContext context)
		{
			try
			{
				context.Logger.LogMessage("Processing Font");
				BitmapFontProcessorResult result = new BitmapFontProcessorResult(bitmapFontFile);

				foreach (BitmapFontPage fontPage in bitmapFontFile.Pages)
				{
					string assetName = Path.GetFileNameWithoutExtension(fontPage.File);
					context.Logger.LogMessage("Expected texture asset: {0}", assetName);
					result.TextureAssets.Add(new BitmapFontPage
					{
						Id = fontPage.Id,
						File = assetName,
						OffsetX = fontPage.OffsetX,
						OffsetY = fontPage.OffsetY
					});
				}

				return result;
			}
			catch (Exception ex)
			{
				context.Logger.LogMessage("Error {0}", ex);
				throw;
			}
		}
	}
}
