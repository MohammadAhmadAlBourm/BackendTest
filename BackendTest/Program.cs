using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CommandLine;
using BackendTest.Models;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                try
                {
                    using (var reader = new StreamReader(options.FilePath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<Record>();

                        foreach (var record in records)
                        {
                            var columnValue = record.GetColumnValue(options.ColumnNumber);
                            if (columnValue.Equals(options.SearchKey, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(record.ToString());
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            });
    }
}