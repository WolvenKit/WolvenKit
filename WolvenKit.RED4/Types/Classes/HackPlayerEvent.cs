using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackPlayerEvent : redEvent
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
		[RED("showDirectionalIndicator")] 
		public CBool ShowDirectionalIndicator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("revealPositionAction")] 
		public CBool RevealPositionAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HackPlayerEvent()
		{
			NetrunnerID = new();
			TargetID = new();
			ShowDirectionalIndicator = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
