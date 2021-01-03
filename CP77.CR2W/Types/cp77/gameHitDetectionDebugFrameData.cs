using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameData : CVariable
	{
		[Ordinal(0)]  [RED("apes")] public CArray<gameHitDetectionDebugFrameDataShapeEntry> Apes { get; set; }
		[Ordinal(1)]  [RED("mponent")] public wCHandle<gameHitRepresentationComponent> Mponent { get; set; }
		[Ordinal(2)]  [RED("t")] public CBool T { get; set; }
		[Ordinal(3)]  [RED("tTime")] public netTime TTime { get; set; }

		public gameHitDetectionDebugFrameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
