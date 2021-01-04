using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpMeatBag : gameObject
	{
		[Ordinal(0)]  [RED("bagBodyBoneName")] public CName BagBodyBoneName { get; set; }
		[Ordinal(1)]  [RED("bagDestroyComponentName")] public CName BagDestroyComponentName { get; set; }
		[Ordinal(2)]  [RED("bagHitComponentName")] public CName BagHitComponentName { get; set; }
		[Ordinal(3)]  [RED("destructionEffectName")] public CName DestructionEffectName { get; set; }
		[Ordinal(4)]  [RED("jiggleEffectName")] public CName JiggleEffectName { get; set; }
		[Ordinal(5)]  [RED("kinematicBodyBoneName")] public CName KinematicBodyBoneName { get; set; }
		[Ordinal(6)]  [RED("physicalComponentName")] public CName PhysicalComponentName { get; set; }
		[Ordinal(7)]  [RED("rotationLerpFactor")] public CFloat RotationLerpFactor { get; set; }

		public cpMeatBag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
