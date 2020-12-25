// --------------------------------------------------------------------
//                             BitmapFontImporter.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System.IO;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace DarzasDominion.Content.Pipeline
{
	[ContentImporter(".fnt", DefaultProcessor = "BitmapFontProcessor",
		DisplayName = "Font Importer - Darza's Dominion")]
	public class BitmapFontImporter : ContentImporter<BitmapFontFile>
	{
		public override BitmapFontFile Import(string filename, ContentImporterContext context)
		{
			context.Logger.LogMessage("Importing XML file: {0}", filename);

			using (StreamReader streamReader = new StreamReader(filename))
			{
				XmlSerializer deserializer = new XmlSerializer(typeof(BitmapFontFile));
				return (BitmapFontFile) deserializer.Deserialize(streamReader);
			}
		}
	}

}
