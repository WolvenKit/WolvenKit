using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAdditionalSpeakers : CVariable
	{
		[Ordinal(0)]  [RED("executionTag")] public CUInt8 ExecutionTag { get; set; }
		[Ordinal(1)]  [RED("role")] public CEnum<scnAdditionalSpeakerRole> Role { get; set; }
		[Ordinal(2)]  [RED("speakers")] public CArray<scnAdditionalSpeaker> Speakers { get; set; }

		public scnAdditionalSpeakers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
