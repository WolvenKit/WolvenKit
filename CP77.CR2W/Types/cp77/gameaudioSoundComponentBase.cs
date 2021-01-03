using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponentBase : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("applyAcousticOcclusion")] public CBool ApplyAcousticOcclusion { get; set; }
		[Ordinal(1)]  [RED("applyAcousticRepositioning")] public CBool ApplyAcousticRepositioning { get; set; }
		[Ordinal(2)]  [RED("applyObstruction")] public CBool ApplyObstruction { get; set; }
		[Ordinal(3)]  [RED("audioName")] public CName AudioName { get; set; }
		[Ordinal(4)]  [RED("maxPlayDistance")] public CFloat MaxPlayDistance { get; set; }
		[Ordinal(5)]  [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }

		public gameaudioSoundComponentBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
