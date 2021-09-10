using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StartHubMenuEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("initData")] 
		public CHandle<HubMenuInitData> InitData
		{
			get => GetPropertyValue<CHandle<HubMenuInitData>>();
			set => SetPropertyValue<CHandle<HubMenuInitData>>(value);
		}
	}
}
