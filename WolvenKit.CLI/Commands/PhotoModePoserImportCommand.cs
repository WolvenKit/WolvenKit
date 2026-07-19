using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4.Tools;

namespace CP77Tools.Commands;

internal sealed class PhotoModePoserImportCommand : CommandBase
{
    public PhotoModePoserImportCommand() : base(
        "import-poser",
        "Import a PhotoMode Poser pose-pack JSON into one .anims file per target rig.")
    {
        AddArgument(new Argument<FileInfo>("path", "Input PhotoMode Poser pose-pack JSON."));
        AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output root. A pose-pack folder is created inside it. Defaults to the JSON file's directory."));

        SetInternalHandler(CommandHandler.Create<FileInfo, DirectoryInfo, IHost>(Action));
    }

    private static int Action(FileInfo path, DirectoryInfo outpath, IHost host)
    {
        var logger = host.Services.GetRequiredService<ILoggerService>();
        if (path is null || !path.Exists)
        {
            logger.Error("Please provide an existing PhotoMode Poser pose-pack JSON file.");
            return ConsoleFunctions.ERROR_BAD_ARGUMENTS;
        }

        try
        {
            var importer = host.Services.GetRequiredService<PhotoModePoserImportTools>();
            var outputDirectory = outpath ?? path.Directory ?? new DirectoryInfo(Directory.GetCurrentDirectory());
            importer.Import(path, outputDirectory);
            return 0;
        }
        catch (Exception exception)
        {
            logger.Error(exception.Message);
            return ConsoleFunctions.ERROR_GENERAL_ERROR;
        }
    }
}
