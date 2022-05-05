using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatCumulative : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("clamp")] 
		public CBool Clamp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("normalize180")] 
		public CBool Normalize180
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("resetExternalEventName")] 
		public CName ResetExternalEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(17)] 
		[RED("minValue")] 
		public animFloatLink MinValue
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(18)] 
		[RED("maxValue")] 
		public animFloatLink MaxValue
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(19)] 
		[RED("resetSpeed")] 
		public animFloatLink ResetSpeed
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(20)] 
		[RED("override")] 
		public animBoolLink Override
		{
			get => GetPropertyValue<animBoolLink>();
			set => SetPropertyValue<animBoolLink>(value);
		}

		[Ordinal(21)] 
		[RED("curValue")] 
		public animFloatLink CurValue
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(22)] 
		[RED("normalize180Input")] 
		public animBoolLink Normalize180Input
		{
			get => GetPropertyValue<animBoolLink>();
			set => SetPropertyValue<animBoolLink>(value);
		}

		public animAnimNode_FloatCumulative()
		{
			Id = 4294967295;
			Clamp = true;
			Normalize180 = true;
			InputNode = new();
			MinValue = new();
			MaxValue = new();
			ResetSpeed = new();
			Override = new();
			CurValue = new();
			Normalize180Input = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
