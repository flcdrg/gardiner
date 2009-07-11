﻿using System;
using System.Xml.Schema;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace NCoverDora
{
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot("coverage")]
    public partial class Coverage
    {
        /// <remarks/>
        [XmlElement("module", Form = XmlSchemaForm.Unqualified)]
        public Module[] Modules { get; set; }

        /// <remarks/>
        [XmlAttribute("profilerVersion")]
        public string ProfilerVersion { get; set; }

        /// <remarks/>
        [XmlAttribute("driverVersion")]
        public string DriverVersion { get; set; }

        /// <remarks/>
        [XmlAttribute("startTime")]
        public string StartTime { get; set; }

        /// <remarks/>
        [XmlAttribute("measureTime")]
        public string MeasureTime { get; set; }
    }
}