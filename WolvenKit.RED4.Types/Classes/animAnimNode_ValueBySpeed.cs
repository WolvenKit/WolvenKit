using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ValueBySpeed : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("clampType")] 
		public CEnum<animClampType> ClampType
		{
			get => GetPropertyValue<CEnum<animClampType>>();
			set => SetPropertyValue<CEnum<animClampType>>(value);
		}

		[Ordinal(13)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("speed")] 
		public animFloatLink Speed
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_ValueBySpeed()
		{
			Id = 4294967295;
			ClampType = Enums.animClampType.Clamp;
			RangeMax = 1.000000F;
			ResetOnActivation = true;
			Speed = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
