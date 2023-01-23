using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatInterpolation : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("x1")] 
		public CFloat X1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("x2")] 
		public CFloat X2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("y1")] 
		public CFloat Y1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("y2")] 
		public CFloat Y2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("interpolationType")] 
		public CEnum<animEAnimGraphMathInterpolation> InterpolationType
		{
			get => GetPropertyValue<CEnum<animEAnimGraphMathInterpolation>>();
			set => SetPropertyValue<CEnum<animEAnimGraphMathInterpolation>>(value);
		}

		[Ordinal(16)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatInterpolation()
		{
			Id = 4294967295;
			InputNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
