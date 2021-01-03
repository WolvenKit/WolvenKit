using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animOverrideBlendTrackInfo : CVariable
	{
		[Ordinal(0)]  [RED("track")] public animNamedTrackIndex Track { get; set; }
		[Ordinal(1)]  [RED("weight")] public CFloat Weight { get; set; }

		public animOverrideBlendTrackInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
