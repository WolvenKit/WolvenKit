using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotomodeSetActiveLightEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isLightTabActive")] 
		public CBool IsLightTabActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isCurrentLightEnabled")] 
		public CBool IsCurrentLightEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("lightIndex")] 
		public CInt32 LightIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiPhotomodeSetActiveLightEvent()
		{
			LightIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
