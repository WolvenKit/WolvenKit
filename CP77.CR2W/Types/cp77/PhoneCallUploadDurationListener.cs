using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneCallUploadDurationListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(1)] [RED("requesterPuppet")] public wCHandle<ScriptedPuppet> RequesterPuppet { get; set; }
		[Ordinal(2)] [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(3)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public PhoneCallUploadDurationListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
