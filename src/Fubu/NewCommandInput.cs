﻿using System.ComponentModel;
using FubuCore.CommandLine;

namespace Fubu
{
    public class NewCommandInput
    {
        [FlagAlias("z")]
        [Description("A zip file containing a FubuMVC project template")]
        public string ZipFlag { get; set; }

        [FlagAlias("g")]
        [Description("A git repository containing a FubuMVC project template")]
        public string GitFlag { get; set; }

        [FlagAlias("o")]
        [Description("The output directory if different than the project name")]
        public string OutputFlag { get; set; }

        [FlagAlias("s")]
        [Description("The Visual Studio solution file to modify to include templated projects")]
        public string SolutionFlag { get; set; }

        [Description("The name and destination folder of the new FubuMVC project")]
        public string ProjectName { get; set; }
    }
}