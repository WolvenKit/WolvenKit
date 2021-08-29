using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SetDrivenKey_InternalsEntry : RedBaseClass
	{
		private CLegacySingleChannelCurve<CFloat> _curve;
		private CName _inChannelName;
		private CName _outChannelName;
		private CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> _inChanelType;
		private CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> _outChanelType;

		[Ordinal(0)] 
		[RED("curve")] 
		public CLegacySingleChannelCurve<CFloat> Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		[Ordinal(1)] 
		[RED("inChannelName")] 
		public CName InChannelName
		{
			get => GetProperty(ref _inChannelName);
			set => SetProperty(ref _inChannelName, value);
		}

		[Ordinal(2)] 
		[RED("outChannelName")] 
		public CName OutChannelName
		{
			get => GetProperty(ref _outChannelName);
			set => SetProperty(ref _outChannelName, value);
		}

		[Ordinal(3)] 
		[RED("inChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> InChanelType
		{
			get => GetProperty(ref _inChanelType);
			set => SetProperty(ref _inChanelType, value);
		}

		[Ordinal(4)] 
		[RED("outChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> OutChanelType
		{
			get => GetProperty(ref _outChanelType);
			set => SetProperty(ref _outChanelType, value);
		}
	}
}
