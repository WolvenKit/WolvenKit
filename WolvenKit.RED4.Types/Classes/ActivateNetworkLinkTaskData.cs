using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivateNetworkLinkTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("linkIndex")] 
		public CInt32 LinkIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ActivateNetworkLinkTaskData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
