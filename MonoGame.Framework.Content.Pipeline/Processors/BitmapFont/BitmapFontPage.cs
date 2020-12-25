// --------------------------------------------------------------------
//                             BitmapFontPage.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System.Xml.Serialization;

namespace DarzasDominion.Content.Pipeline
{
	public class BitmapFontPage
	{
		[XmlAttribute("id")] public int Id { get; set; }

		[XmlAttribute("file")] public string File { get; set; }

		[XmlAttribute("offsetX")] public int OffsetX { get; set; }

		[XmlAttribute("offsetY")] public int OffsetY { get; set; }
	}
}