// --------------------------------------------------------------------
//                             BitmapFontWriter.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

namespace DarzasDominion.Content.Pipeline
{
	[ContentTypeWriter]
	public class BitmapFontWriter : ContentTypeWriter<BitmapFontProcessorResult>
	{
		protected internal override void Write(ContentWriter writer, BitmapFontProcessorResult result)
		{
			writer.Write(result.TextureAssets.Count);

			foreach (BitmapFontPage page in result.TextureAssets)
			{
				writer.Write(page.File);
				writer.Write(page.OffsetX);
				writer.Write(page.OffsetY);
			}

			BitmapFontFile fontFile = result.FontFile;
			writer.Write(fontFile.Common.LineHeight);
			writer.Write(fontFile.Chars.Count);

			foreach (BitmapFontChar c in fontFile.Chars)
			{
				writer.Write(c.Id);
				writer.Write(c.Page);
				writer.Write(c.X);
				writer.Write(c.Y);
				writer.Write(c.Width);
				writer.Write(c.Height);
				writer.Write(c.XOffset);
				writer.Write(c.YOffset);
				writer.Write(c.XAdvance);
			}

			writer.Write(fontFile.Kernings.Count);
			foreach (BitmapFontKerning k in fontFile.Kernings)
			{
				writer.Write(k.First);
				writer.Write(k.Second);
				writer.Write(k.Amount);
			}
		}

		public override string GetRuntimeType(TargetPlatform targetPlatform)
		{
			return "DarzasDominion.BitmapFonts.BitmapFont, DarzasDominion";
		}

		public override string GetRuntimeReader(TargetPlatform targetPlatform)
		{
			return "DarzasDominion.BitmapFonts.BitmapFontReader, DarzasDominion";
		}
	}
}
