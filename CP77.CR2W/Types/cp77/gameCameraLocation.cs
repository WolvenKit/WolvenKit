using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCameraLocation : CVariable
	{
		[Ordinal(0)]  [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(1)]  [RED("rotation")] public EulerAngles Rotation { get; set; }

		public gameCameraLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
