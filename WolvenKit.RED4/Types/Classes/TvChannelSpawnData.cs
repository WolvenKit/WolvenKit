using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TvChannelSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("channelName")] 
		public CName ChannelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("order")] 
		public CInt32 Order
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TvChannelSpawnData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
