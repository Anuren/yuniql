﻿using CommandLine;

namespace ArdiLabs.Yuniql.CLI
{
    //yuniql erase
    [Verb("erase", HelpText = "Discover all scripts in the _erase directory and executes them in single transaction")]
    public class EraseOption : BaseOption
    {
        //yuniql info -c "<connectiong-string>"
        [Option('c', "connection-string", Required = false, HelpText = "Connection string to target sql server instance")]
        public string ConnectionString { get; set; }

        //yuniql run -d | --debug
        [Option('d', "debug", Required = false, HelpText = "Print debug information including all raw scripts")]
        public bool Debug { get; set; }
    }
}