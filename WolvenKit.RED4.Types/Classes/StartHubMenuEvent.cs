using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StartHubMenuEvent : redEvent
	{
		private CHandle<HubMenuInitData> _initData;

		[Ordinal(0)] 
		[RED("initData")] 
		public CHandle<HubMenuInitData> InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}
	}
}
