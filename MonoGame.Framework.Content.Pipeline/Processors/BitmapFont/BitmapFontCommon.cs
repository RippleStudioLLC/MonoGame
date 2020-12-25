﻿// --------------------------------------------------------------------
//                             BitmapFontCommon.cs
// --------------------------------------------------------------------
// Author: Danny Guardado (Linqx)
// Created: 06/29/2020

using System.Xml.Serialization;

namespace DarzasDominion.Content.Pipeline
{
	public class BitmapFontCommon
	{
		[XmlAttribute("lineHeight")] public int LineHeight { get; set; }

		[XmlAttribute("base")] public int Base { get; set; }

		[XmlAttribute("scaleW")] public int ScaleW { get; set; }

		[XmlAttribute("scaleH")] public int ScaleH { get; set; }

		[XmlAttribute("pages")] public int Pages { get; set; }

		[XmlAttribute("packed")] public int Packed { get; set; }

		[XmlAttribute("alphaChnl")] public int AlphaChannel { get; set; }

		[XmlAttribute("redChnl")] public int RedChannel { get; set; }

		[XmlAttribute("greenChnl")] public int GreenChannel { get; set; }

		[XmlAttribute("blueChnl")] public int BlueChannel { get; set; }
	}
}