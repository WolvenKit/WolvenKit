using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkFullscreenCompositionResource : CResource
	{
		[Ordinal(0)]  [RED("compositionPresets")] public CArray<inkCompositionPreset> CompositionPresets { get; set; }
		[Ordinal(1)]  [RED("previewSettings")] public CHandle<inkCompositionPreviewSettings> PreviewSettings { get; set; }

		public inkFullscreenCompositionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
