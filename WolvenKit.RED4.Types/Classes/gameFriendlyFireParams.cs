using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFriendlyFireParams : IScriptable
	{
		[Ordinal(0)] 
		[RED("attitude")] 
		public CWeakHandle<gameAttitudeAgent> Attitude
		{
			get => GetPropertyValue<CWeakHandle<gameAttitudeAgent>>();
			set => SetPropertyValue<CWeakHandle<gameAttitudeAgent>>(value);
		}

		[Ordinal(1)] 
		[RED("slots")] 
		public CWeakHandle<entSlotComponent> Slots
		{
			get => GetPropertyValue<CWeakHandle<entSlotComponent>>();
			set => SetPropertyValue<CWeakHandle<entSlotComponent>>(value);
		}

		[Ordinal(2)] 
		[RED("attachmentName")] 
		public CName AttachmentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public CInt32 SlotId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("spread")] 
		public CFloat Spread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxRange")] 
		public CFloat MaxRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameFriendlyFireParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
