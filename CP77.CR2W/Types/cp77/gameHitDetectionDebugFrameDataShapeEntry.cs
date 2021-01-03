using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameDataShapeEntry : CVariable
	{
		[Ordinal(0)]  [RED("ansformWS")] public WorldTransform AnsformWS { get; set; }

		public gameHitDetectionDebugFrameDataShapeEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
