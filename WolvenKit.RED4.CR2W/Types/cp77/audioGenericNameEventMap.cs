using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGenericNameEventMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("eventOverrides")] public CHandle<audioGenericNameEventDictionary> EventOverrides { get; set; }

		public audioGenericNameEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
