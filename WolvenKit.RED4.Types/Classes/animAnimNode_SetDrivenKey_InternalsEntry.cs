using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetDrivenKey_InternalsEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("curve")] 
		public CLegacySingleChannelCurve<CFloat> Curve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("inChannelName")] 
		public CName InChannelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("outChannelName")] 
		public CName OutChannelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("inChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> InChanelType
		{
			get => GetPropertyValue<CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType>>();
			set => SetPropertyValue<CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType>>(value);
		}

		[Ordinal(4)] 
		[RED("outChanelType")] 
		public CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType> OutChanelType
		{
			get => GetPropertyValue<CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType>>();
			set => SetPropertyValue<CEnum<animAnimNode_SetDrivenKey_InternalsEChannelType>>(value);
		}

		public animAnimNode_SetDrivenKey_InternalsEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
