using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChoiceNodeNsAdaptiveLookAtParams : scnChoiceNodeNsLookAtParams
	{
		private CName _nearbySlotName;
		private CName _distantSlotName;
		private CFloat _blendLimit;
		private CFloat _referencePointFullEffectAngle;
		private CFloat _referencePointNoEffectAngle;
		private CFloat _referencePointFullEffectDistance;
		private CFloat _referencePointNoEffectDistance;
		private CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint> _referencePoints;
		private Vector3 _auxiliaryRelativePoint;

		[Ordinal(0)] 
		[RED("nearbySlotName")] 
		public CName NearbySlotName
		{
			get => GetProperty(ref _nearbySlotName);
			set => SetProperty(ref _nearbySlotName, value);
		}

		[Ordinal(1)] 
		[RED("distantSlotName")] 
		public CName DistantSlotName
		{
			get => GetProperty(ref _distantSlotName);
			set => SetProperty(ref _distantSlotName, value);
		}

		[Ordinal(2)] 
		[RED("blendLimit")] 
		public CFloat BlendLimit
		{
			get => GetProperty(ref _blendLimit);
			set => SetProperty(ref _blendLimit, value);
		}

		[Ordinal(3)] 
		[RED("referencePointFullEffectAngle")] 
		public CFloat ReferencePointFullEffectAngle
		{
			get => GetProperty(ref _referencePointFullEffectAngle);
			set => SetProperty(ref _referencePointFullEffectAngle, value);
		}

		[Ordinal(4)] 
		[RED("referencePointNoEffectAngle")] 
		public CFloat ReferencePointNoEffectAngle
		{
			get => GetProperty(ref _referencePointNoEffectAngle);
			set => SetProperty(ref _referencePointNoEffectAngle, value);
		}

		[Ordinal(5)] 
		[RED("referencePointFullEffectDistance")] 
		public CFloat ReferencePointFullEffectDistance
		{
			get => GetProperty(ref _referencePointFullEffectDistance);
			set => SetProperty(ref _referencePointFullEffectDistance, value);
		}

		[Ordinal(6)] 
		[RED("referencePointNoEffectDistance")] 
		public CFloat ReferencePointNoEffectDistance
		{
			get => GetProperty(ref _referencePointNoEffectDistance);
			set => SetProperty(ref _referencePointNoEffectDistance, value);
		}

		[Ordinal(7)] 
		[RED("referencePoints")] 
		public CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint> ReferencePoints
		{
			get => GetProperty(ref _referencePoints);
			set => SetProperty(ref _referencePoints, value);
		}

		[Ordinal(8)] 
		[RED("auxiliaryRelativePoint")] 
		public Vector3 AuxiliaryRelativePoint
		{
			get => GetProperty(ref _auxiliaryRelativePoint);
			set => SetProperty(ref _auxiliaryRelativePoint, value);
		}
	}
}
