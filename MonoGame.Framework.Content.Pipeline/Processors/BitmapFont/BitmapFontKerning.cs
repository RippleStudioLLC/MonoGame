// --------------------------------------------------------------------
//                             BitmapFontKerning.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System.Xml.Serialization;

namespace DarzasDominion.Content.Pipeline
{
	public class BitmapFontKerning
	{
		[XmlAttribute("first")] public int First { get; set; }

		[XmlAttribute("second")] public int Second { get; set; }

		[XmlAttribute("amount")] public int Amount { get; set; }
	}
}