using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Position_LocalPosition : gameTransformAnimation_Position
	{
		[Ordinal(0)]  [RED("position")] public Vector3 Position { get; set; }

		public gameTransformAnimation_Position_LocalPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
