using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackTargetSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("showDirectionalIndicator")] 
		public CBool ShowDirectionalIndicator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isRevealPositionAction")] 
		public CBool IsRevealPositionAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("skipBeingHackedSetUp")] 
		public CBool SkipBeingHackedSetUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("HUDData")] 
		public HUDProgressBarData HUDData
		{
			get => GetPropertyValue<HUDProgressBarData>();
			set => SetPropertyValue<HUDProgressBarData>(value);
		}

		public HackTargetSettings()
		{
			ShowDirectionalIndicator = true;
			HUDData = new HUDProgressBarData { BottomText = "LocKey#22169", CompletedText = "LocKey#15455", FailedText = "LocKey#15353" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
