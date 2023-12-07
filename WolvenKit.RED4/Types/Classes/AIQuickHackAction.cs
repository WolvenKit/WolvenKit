using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIQuickHackAction : PuppetAction
	{
		[Ordinal(39)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(40)] 
		[RED("scaleUploadTime")] 
		public CBool ScaleUploadTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("HUDData")] 
		public HUDProgressBarData HUDData
		{
			get => GetPropertyValue<HUDProgressBarData>();
			set => SetPropertyValue<HUDProgressBarData>(value);
		}

		public AIQuickHackAction()
		{
			ScaleUploadTime = true;
			HUDData = new HUDProgressBarData { BottomText = "LocKey#22169", CompletedText = "LocKey#15455", FailedText = "LocKey#15353" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
