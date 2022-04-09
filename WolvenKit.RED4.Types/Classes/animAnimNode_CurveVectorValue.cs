using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_CurveVectorValue : animAnimNode_VectorValue
	{
		[Ordinal(11)] 
		[RED("curveData")] 
		public CLegacySingleChannelCurve<Vector4> CurveData
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector4>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector4>>(value);
		}

		[Ordinal(12)] 
		[RED("argument")] 
		public animFloatLink Argument
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_CurveVectorValue()
		{
			Id = 4294967295;
			Argument = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
