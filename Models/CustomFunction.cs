﻿using System.Xml.Linq;
using FuryTech.OdataTypescriptServiceGenerator.Abstracts;

namespace FuryTech.OdataTypescriptServiceGenerator.Models
{
    public class CustomFunction : CustomEventAbstract
    {
        public CustomFunction(XElement xElement) : base(xElement)
        {
        }
    }
}
