using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameResourceEvent : gameCallbackSystemEvent
	{
		[Ordinal(1)] 
		[RED("resource")] 
		public CHandle<CResource> Resource
		{
			get => GetPropertyValue<CHandle<CResource>>();
			set => SetPropertyValue<CHandle<CResource>>(value);
		}

		public gameResourceEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
