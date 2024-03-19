using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DynamicData.Kernel;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4;

public partial class ModTools
{
	private static readonly Regex TypeExtensionMatcher = new(
		$"\\w+\\.(?<typeExtension>{ string.Join("|", Enum.GetNames<GltfImportAsFormat>().Select((n) => n.ToLower())) })\\.(glb|gltf)$",
		RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.NonBacktracking
	);

    private static readonly Func<string, string> InternalExtForType = (internalType) =>
		internalType switch {
			"meshwithrig" => ".mesh",
			_ => $" "
		};

    /// <summary>
    /// Will match any potential type extension before the .glb/gltf
    /// </summary>
    private static readonly Func<string, Optional<string>> TypeFromFileExt = (path) =>
		TypeExtensionMatcher.Match(path).Groups["typeExtension"].Value switch {
			string matched when !string.IsNullOrWhiteSpace(matched) => Optional.Some(matched.ToLower()),
			_ => Optional.None<string>()
		};

    public static GltfImportAsFormat? GltfImportAsFormatFromFileExt(string path)
    {
	    var internalExtension = TypeFromFileExt(path).ToString() ?? "_";
	    var importFormatString = char.ToUpper(internalExtension[0]) + internalExtension.Substring(1);

	    return Enum.TryParse<GltfImportAsFormat>(importFormatString, out var importFormat) ? importFormat : null;
    }

	private static readonly Func<string, GltfImportAsFormat> ImportFormatFor = (type) =>
		type switch {
			"anims" => GltfImportAsFormat.Anims,
			"mesh" => GltfImportAsFormat.Mesh,
			"morphtarget" => GltfImportAsFormat.Morphtarget,
			"rig" => GltfImportAsFormat.Rig,
			"meshwithrig" => GltfImportAsFormat.MeshWithRig,
			"physicalscene" => GltfImportAsFormat.PhysicalScene,
			_ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unknown extension, probably shouldn't be calling this function")
		};
}