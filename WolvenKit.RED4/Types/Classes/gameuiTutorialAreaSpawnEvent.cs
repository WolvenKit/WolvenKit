using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTutorialAreaSpawnEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("areaID")] 
		public CUInt32 AreaID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public gameuiTutorialAreaSpawnEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
