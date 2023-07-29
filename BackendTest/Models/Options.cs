using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTest.Models
{
    public class Options
    {
        [Value(0, Required = true, MetaName = "FilePath", HelpText = "Path to the CSV file.")]
        public string FilePath { get; set; }

        [Value(1, Required = true, MetaName = "ColumnNumber", HelpText = "Column number to search in.")]
        public int ColumnNumber { get; set; }

        [Value(2, Required = true, MetaName = "SearchKey", HelpText = "Search key.")]
        public string SearchKey { get; set; }
    }
}
