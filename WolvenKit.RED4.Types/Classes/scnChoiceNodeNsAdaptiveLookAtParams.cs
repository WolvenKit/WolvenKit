using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsAdaptiveLookAtParams : scnChoiceNodeNsLookAtParams
	{
		[Ordinal(0)] 
		[RED("nearbySlotName")] 
		public CName NearbySlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("distantSlotName")] 
		public CName DistantSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("blendLimit")] 
		public CFloat BlendLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("referencePointFullEffectAngle")] 
		public CFloat ReferencePointFullEffectAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("referencePointNoEffectAngle")] 
		public CFloat ReferencePointNoEffectAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("referencePointFullEffectDistance")] 
		public CFloat ReferencePointFullEffectDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("referencePointNoEffectDistance")] 
		public CFloat ReferencePointNoEffectDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("referencePoints")] 
		public CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint> ReferencePoints
		{
			get => GetPropertyValue<CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint>>();
			set => SetPropertyValue<CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint>>(value);
		}

		[Ordinal(8)] 
		[RED("auxiliaryRelativePoint")] 
		public Vector3 AuxiliaryRelativePoint
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public scnChoiceNodeNsAdaptiveLookAtParams()
		{
			ReferencePointNoEffectAngle = 63.000000F;
			ReferencePointFullEffectDistance = 5.000000F;
			ReferencePoints = new();
			AuxiliaryRelativePoint = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
