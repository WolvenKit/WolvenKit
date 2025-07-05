using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AlarmEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameDelayID ID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public AlarmEvent()
		{
			ID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
