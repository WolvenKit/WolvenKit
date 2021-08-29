using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioContextualAudEventMapItem : audioAudioMetadata
	{
		private CName _context;
		private CName _event;

		[Ordinal(1)] 
		[RED("context")] 
		public CName Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(2)] 
		[RED("event")] 
		public CName Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}
	}
}
