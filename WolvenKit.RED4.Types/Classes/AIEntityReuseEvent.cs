using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEntityReuseEvent : AIAIEvent
	{
		private worldGlobalNodeID _destination;

		[Ordinal(2)] 
		[RED("destination")] 
		public worldGlobalNodeID Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}
	}
}
