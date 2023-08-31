// See https://aka.ms/new-console-template for more information
using LSPApp;

Console.WriteLine("Hello, World!");

SqlFileService fileService = new();
fileService.ReadFromFile(new SqlFile { FilePath = @"read-only-file.sql" });
fileService.WriteIntoFile(new SqlFile { FilePath = @"write-only-file.sql" }, "data");
