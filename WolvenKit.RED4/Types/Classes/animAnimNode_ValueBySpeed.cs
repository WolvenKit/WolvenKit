using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ValueBySpeed : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("clampType")] 
		public CEnum<animClampType> ClampType
		{
			get => GetPropertyValue<CEnum<animClampType>>();
			set => SetPropertyValue<CEnum<animClampType>>(value);
		}

		[Ordinal(3)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("speed")] 
		public animFloatLink Speed
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_ValueBySpeed()
		{
			Id = uint.MaxValue;
			ClampType = Enums.animClampType.Clamp;
			RangeMax = 1.000000F;
			ResetOnActivation = true;
			Speed = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
