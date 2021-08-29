using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiSound : RedBaseClass
	{
		private CArray<CName> _events;

		[Ordinal(0)] 
		[RED("events")] 
		public CArray<CName> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}
	}
}
