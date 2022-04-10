using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPuppetPreview_ReadyToBeDisplayed : redEvent
	{
		[Ordinal(0)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPuppetPreview_ReadyToBeDisplayed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
