using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioRigMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("positionBones")] public CArray<CName> PositionBones { get; set; }
		[Ordinal(1)]  [RED("defaultBone")] public CName DefaultBone { get; set; }

		public audioRigMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
