using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteBrushCategory : audioAudioMetadata
	{
		[Ordinal(1)] [RED("brushes")] public CHandle<audioAmbientPaletteBrushDictionary> Brushes { get; set; }

		public audioAmbientPaletteBrushCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
