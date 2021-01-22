using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInteractionShapeParams : ISerializable
	{
		[Ordinal(0)]  [RED("activationBaseLength")] public CFloat ActivationBaseLength { get; set; }
		[Ordinal(1)]  [RED("activationHeight")] public CFloat ActivationHeight { get; set; }
		[Ordinal(2)]  [RED("activationYawLimit")] public CFloat ActivationYawLimit { get; set; }
		[Ordinal(3)]  [RED("customActivationRange")] public CFloat CustomActivationRange { get; set; }
		[Ordinal(4)]  [RED("customIndicationRange")] public CFloat CustomIndicationRange { get; set; }
		[Ordinal(5)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(6)]  [RED("preset")] public CEnum<scnChoiceNodeNsSizePreset> Preset { get; set; }
		[Ordinal(7)]  [RED("rotation")] public Quaternion Rotation { get; set; }

		public scnInteractionShapeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
