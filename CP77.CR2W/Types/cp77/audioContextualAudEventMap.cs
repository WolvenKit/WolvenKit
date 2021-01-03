using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioContextualAudEventMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("contextualAudEventMapItems")] public CArray<audioContextualAudEventMapItem> ContextualAudEventMapItems { get; set; }

		public audioContextualAudEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
