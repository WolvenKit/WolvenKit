using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAdaptiveLookAtParams : scnChoiceNodeNsLookAtParams
	{
		[Ordinal(0)] [RED("nearbySlotName")] public CName NearbySlotName { get; set; }
		[Ordinal(1)] [RED("distantSlotName")] public CName DistantSlotName { get; set; }
		[Ordinal(2)] [RED("blendLimit")] public CFloat BlendLimit { get; set; }
		[Ordinal(3)] [RED("referencePointFullEffectAngle")] public CFloat ReferencePointFullEffectAngle { get; set; }
		[Ordinal(4)] [RED("referencePointNoEffectAngle")] public CFloat ReferencePointNoEffectAngle { get; set; }
		[Ordinal(5)] [RED("referencePointFullEffectDistance")] public CFloat ReferencePointFullEffectDistance { get; set; }
		[Ordinal(6)] [RED("referencePointNoEffectDistance")] public CFloat ReferencePointNoEffectDistance { get; set; }
		[Ordinal(7)] [RED("referencePoints")] public CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint> ReferencePoints { get; set; }
		[Ordinal(8)] [RED("auxiliaryRelativePoint")] public Vector3 AuxiliaryRelativePoint { get; set; }

		public scnChoiceNodeNsAdaptiveLookAtParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
