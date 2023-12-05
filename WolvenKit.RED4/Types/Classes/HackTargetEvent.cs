using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackTargetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("objectRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("settings")] 
		public HackTargetSettings Settings
		{
			get => GetPropertyValue<HackTargetSettings>();
			set => SetPropertyValue<HackTargetSettings>(value);
		}

		public HackTargetEvent()
		{
			NetrunnerID = new entEntityID();
			TargetID = new entEntityID();
			Settings = new HackTargetSettings { ShowDirectionalIndicator = true, HUDData = new HUDProgressBarData { BottomText = "LocKey#22169", CompletedText = "LocKey#15455", FailedText = "LocKey#15353" } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
