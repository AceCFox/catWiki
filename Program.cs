Console.WriteLine("Hello, World!");

return await Bootstrapper
  .Factory
  .CreateDocs(args)
  .RunAsync();
