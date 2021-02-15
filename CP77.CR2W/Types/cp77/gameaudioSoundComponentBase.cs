using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponentBase : entIPlacedComponent
	{
		[Ordinal(5)] [RED("audioName")] public CName AudioName { get; set; }
		[Ordinal(6)] [RED("applyObstruction")] public CBool ApplyObstruction { get; set; }
		[Ordinal(7)] [RED("applyAcousticOcclusion")] public CBool ApplyAcousticOcclusion { get; set; }
		[Ordinal(8)] [RED("applyAcousticRepositioning")] public CBool ApplyAcousticRepositioning { get; set; }
		[Ordinal(9)] [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(10)] [RED("maxPlayDistance")] public CFloat MaxPlayDistance { get; set; }

		public gameaudioSoundComponentBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
