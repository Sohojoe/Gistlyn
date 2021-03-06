﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Gistlyn.ServiceModel.Types
{
    [Serializable]
    public class NugetPackageInfo
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlAttribute("targetFramework")]
        public string TargetFramework { get; set; }

        public List<AssemblyReference> Assemblies { get; set; }
    }
}

