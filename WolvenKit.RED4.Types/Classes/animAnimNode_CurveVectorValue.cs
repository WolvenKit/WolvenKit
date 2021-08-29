using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_CurveVectorValue : animAnimNode_VectorValue
	{
		private CLegacySingleChannelCurve<Vector4> _curveData;
		private animFloatLink _argument;

		[Ordinal(11)] 
		[RED("curveData")] 
		public CLegacySingleChannelCurve<Vector4> CurveData
		{
			get => GetProperty(ref _curveData);
			set => SetProperty(ref _curveData, value);
		}

		[Ordinal(12)] 
		[RED("argument")] 
		public animFloatLink Argument
		{
			get => GetProperty(ref _argument);
			set => SetProperty(ref _argument, value);
		}
	}
}
