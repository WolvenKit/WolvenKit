using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TVSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("channels")] 
		public CArray<STvChannel> Channels
		{
			get => GetPropertyValue<CArray<STvChannel>>();
			set => SetPropertyValue<CArray<STvChannel>>(value);
		}

		[Ordinal(1)] 
		[RED("initialChannel")] 
		public CInt32 InitialChannel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("initialGlobalTvChannel")] 
		public TweakDBID InitialGlobalTvChannel
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("muteInterface")] 
		public CBool MuteInterface
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isGlobalTvOnly")] 
		public CBool IsGlobalTvOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TVSetup()
		{
			Channels = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
