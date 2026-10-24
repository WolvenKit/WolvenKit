using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatCumulative : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("clamp")] 
		public CBool Clamp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("normalize180")] 
		public CBool Normalize180
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("resetExternalEventName")] 
		public CName ResetExternalEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(7)] 
		[RED("minValue")] 
		public animFloatLink MinValue
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(8)] 
		[RED("maxValue")] 
		public animFloatLink MaxValue
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(9)] 
		[RED("resetSpeed")] 
		public animFloatLink ResetSpeed
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(10)] 
		[RED("override")] 
		public animBoolLink Override
		{
			get => GetPropertyValue<animBoolLink>();
			set => SetPropertyValue<animBoolLink>(value);
		}

		[Ordinal(11)] 
		[RED("curValue")] 
		public animFloatLink CurValue
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(12)] 
		[RED("normalize180Input")] 
		public animBoolLink Normalize180Input
		{
			get => GetPropertyValue<animBoolLink>();
			set => SetPropertyValue<animBoolLink>(value);
		}

		public animAnimNode_FloatCumulative()
		{
			Id = uint.MaxValue;
			Clamp = true;
			Normalize180 = true;
			InputNode = new animFloatLink();
			MinValue = new animFloatLink();
			MaxValue = new animFloatLink();
			ResetSpeed = new animFloatLink();
			Override = new animBoolLink();
			CurValue = new animFloatLink();
			Normalize180Input = new animBoolLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
