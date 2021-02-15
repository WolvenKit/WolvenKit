using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("customMaterialLookup")] public CName CustomMaterialLookup { get; set; }
		[Ordinal(2)] [RED("isPlayer")] public CBool IsPlayer { get; set; }

		public audioLocomotionEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
