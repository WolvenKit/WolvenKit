using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSnapToTerrainIkRequest : CVariable
	{
		[Ordinal(0)]  [RED("ikChain")] public CName IkChain { get; set; }
		[Ordinal(1)]  [RED("footTransformIndex")] public animTransformIndex FootTransformIndex { get; set; }
		[Ordinal(2)]  [RED("poleVectorRefTransformIndex")] public animTransformIndex PoleVectorRefTransformIndex { get; set; }
		[Ordinal(3)]  [RED("enableFootLockFloatTrack")] public animNamedTrackIndex EnableFootLockFloatTrack { get; set; }

		public animSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
