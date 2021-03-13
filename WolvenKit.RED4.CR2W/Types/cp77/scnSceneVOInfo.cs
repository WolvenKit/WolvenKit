using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneVOInfo : CVariable
	{
		[Ordinal(0)] [RED("inVoTrigger")] public CName InVoTrigger { get; set; }
		[Ordinal(1)] [RED("outVoTrigger")] public CName OutVoTrigger { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("id")] public CUInt16 Id { get; set; }

		public scnSceneVOInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
