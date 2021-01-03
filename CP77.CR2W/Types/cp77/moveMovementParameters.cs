using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class moveMovementParameters : CVariable
	{
		[Ordinal(0)]  [RED("acceleration")] public CFloat Acceleration { get; set; }
		[Ordinal(1)]  [RED("deceleration")] public CFloat Deceleration { get; set; }
		[Ordinal(2)]  [RED("maxSpeed")] public CFloat MaxSpeed { get; set; }
		[Ordinal(3)]  [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(4)]  [RED("type")] public CEnum<moveMovementType> Type { get; set; }

		public moveMovementParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
