using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Position_InitialPosition : gameTransformAnimation_Position
	{
		[Ordinal(0)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(1)]  [RED("offsetInWorldSpace")] public CBool OffsetInWorldSpace { get; set; }

		public gameTransformAnimation_Position_InitialPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
