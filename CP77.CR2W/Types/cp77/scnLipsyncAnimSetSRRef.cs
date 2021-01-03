using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnLipsyncAnimSetSRRef : CVariable
	{
		[Ordinal(0)]  [RED("asyncRefLipsyncAnimSet")] public raRef<animAnimSet> AsyncRefLipsyncAnimSet { get; set; }
		[Ordinal(1)]  [RED("lipsyncAnimSet")] public rRef<animAnimSet> LipsyncAnimSet { get; set; }

		public scnLipsyncAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
