// --------------------------------------------------------------------
//                             BitmapFontChar.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System.Xml.Serialization;

namespace DarzasDominion.Content.Pipeline
{
	public class BitmapFontChar
	{
		[XmlAttribute("id")] public int Id { get; set; }

		[XmlAttribute("x")] public int X { get; set; }

		[XmlAttribute("y")] public int Y { get; set; }

		[XmlAttribute("width")] public int Width { get; set; }

		[XmlAttribute("height")] public int Height { get; set; }

		[XmlAttribute("xoffset")] public int XOffset { get; set; }

		[XmlAttribute("yoffset")] public int YOffset { get; set; }

		[XmlAttribute("xadvance")] public int XAdvance { get; set; }

		[XmlAttribute("page")] public int Page { get; set; }

		[XmlAttribute("chnl")] public int Channel { get; set; }
	}
}