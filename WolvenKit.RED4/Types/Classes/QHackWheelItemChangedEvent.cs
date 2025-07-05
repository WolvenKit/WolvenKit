using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QHackWheelItemChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("commandData")] 
		public CHandle<QuickhackData> CommandData
		{
			get => GetPropertyValue<CHandle<QuickhackData>>();
			set => SetPropertyValue<CHandle<QuickhackData>>(value);
		}

		[Ordinal(1)] 
		[RED("currentEmpty")] 
		public CBool CurrentEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QHackWheelItemChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
