using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnAdditionalSpeaker : CVariable
	{
		[Ordinal(0)] [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<scnAdditionalSpeakerType> Type { get; set; }

		public scnAdditionalSpeaker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
