using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIActionLookatParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("useLookat")] 
		public CBool UseLookat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("useLeftHand")] 
		public CBool UseLeftHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("useRightHand")] 
		public CBool UseRightHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("attachRightHandtoLeftHand")] 
		public CBool AttachRightHandtoLeftHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("attachLeftHandtoRightHand")] 
		public CBool AttachLeftHandtoRightHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("lookatStyle")] 
		public CEnum<animLookAtStyle> LookatStyle
		{
			get => GetPropertyValue<CEnum<animLookAtStyle>>();
			set => SetPropertyValue<CEnum<animLookAtStyle>>(value);
		}

		[Ordinal(7)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("outTransitionStyle")] 
		public CEnum<animLookAtStyle> OutTransitionStyle
		{
			get => GetPropertyValue<CEnum<animLookAtStyle>>();
			set => SetPropertyValue<CEnum<animLookAtStyle>>(value);
		}

		[Ordinal(9)] 
		[RED("softLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> SoftLimitDegrees
		{
			get => GetPropertyValue<CEnum<animLookAtLimitDegreesType>>();
			set => SetPropertyValue<CEnum<animLookAtLimitDegreesType>>(value);
		}

		[Ordinal(10)] 
		[RED("hardLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> HardLimitDegrees
		{
			get => GetPropertyValue<CEnum<animLookAtLimitDegreesType>>();
			set => SetPropertyValue<CEnum<animLookAtLimitDegreesType>>(value);
		}

		[Ordinal(11)] 
		[RED("hardLimitDistance")] 
		public CEnum<animLookAtLimitDistanceType> HardLimitDistance
		{
			get => GetPropertyValue<CEnum<animLookAtLimitDistanceType>>();
			set => SetPropertyValue<CEnum<animLookAtLimitDistanceType>>(value);
		}

		[Ordinal(12)] 
		[RED("backLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> BackLimitDegrees
		{
			get => GetPropertyValue<CEnum<animLookAtLimitDegreesType>>();
			set => SetPropertyValue<CEnum<animLookAtLimitDegreesType>>(value);
		}

		[Ordinal(13)] 
		[RED("additionalParts")] 
		public CArray<animLookAtPartRequest> AdditionalParts
		{
			get => GetPropertyValue<CArray<animLookAtPartRequest>>();
			set => SetPropertyValue<CArray<animLookAtPartRequest>>(value);
		}

		public AIActionLookatParams()
		{
			AdditionalParts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
