using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeSound : RedBaseClass
	{
		private CArray<audioMeleeEvent> _events;

		[Ordinal(0)] 
		[RED("events")] 
		public CArray<audioMeleeEvent> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}
	}
}
