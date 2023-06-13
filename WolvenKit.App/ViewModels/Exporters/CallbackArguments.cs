using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.App.ViewModels.Exporters;

public record class CallbackArguments(ImportExportArgs Arg, string PropertyName);
