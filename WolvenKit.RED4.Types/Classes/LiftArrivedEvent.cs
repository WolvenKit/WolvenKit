using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LiftArrivedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("floor")] 
		public CString Floor
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public LiftArrivedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
