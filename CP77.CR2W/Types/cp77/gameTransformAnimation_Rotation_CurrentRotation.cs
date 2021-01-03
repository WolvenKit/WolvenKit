using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Rotation_CurrentRotation : gameTransformAnimation_Rotation
	{
		[Ordinal(0)]  [RED("offset")] public Quaternion Offset { get; set; }

		public gameTransformAnimation_Rotation_CurrentRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
