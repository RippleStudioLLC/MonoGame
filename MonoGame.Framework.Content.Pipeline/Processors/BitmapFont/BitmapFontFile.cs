// --------------------------------------------------------------------
//                             BitmapFontFile.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System.Collections.Generic;
using System.Xml.Serialization;

namespace DarzasDominion.Content.Pipeline
{
	[XmlRoot("font")]
	public class BitmapFontFile
	{
		[XmlElement("info")] public BitmapFontInfo Info { get; set; }

		[XmlElement("common")] public BitmapFontCommon Common { get; set; }

		[XmlArray("pages")]
		[XmlArrayItem("page")]
		public List<BitmapFontPage> Pages { get; set; }

		[XmlArray("chars")]
		[XmlArrayItem("char")]
		public List<BitmapFontChar> Chars { get; set; }

		[XmlArray("kernings")]
		[XmlArrayItem("kerning")]
		public List<BitmapFontKerning> Kernings { get; set; }
	}
}