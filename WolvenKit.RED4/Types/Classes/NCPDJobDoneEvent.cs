using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NCPDJobDoneEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("levelXPAwarded")] 
		public CInt32 LevelXPAwarded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("streetCredXPAwarded")] 
		public CInt32 StreetCredXPAwarded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NCPDJobDoneEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
