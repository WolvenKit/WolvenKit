using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLipsyncAnimSetSRRef : CVariable
	{
		[Ordinal(0)] [RED("lipsyncAnimSet")] public rRef<animAnimSet> LipsyncAnimSet { get; set; }
		[Ordinal(1)] [RED("asyncRefLipsyncAnimSet")] public raRef<animAnimSet> AsyncRefLipsyncAnimSet { get; set; }

		public scnLipsyncAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
