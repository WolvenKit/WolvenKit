using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneVOInfo : CVariable
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("id")] public CUInt16 Id { get; set; }
		[Ordinal(2)]  [RED("inVoTrigger")] public CName InVoTrigger { get; set; }
		[Ordinal(3)]  [RED("outVoTrigger")] public CName OutVoTrigger { get; set; }

		public scnSceneVOInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
