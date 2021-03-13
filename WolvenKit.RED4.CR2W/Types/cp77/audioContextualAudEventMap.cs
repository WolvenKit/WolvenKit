using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualAudEventMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("contextualAudEventMapItems")] public CArray<audioContextualAudEventMapItem> ContextualAudEventMapItems { get; set; }

		public audioContextualAudEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
