using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameChangeDestination : gameActionInternalEvent
	{
		private Vector4 _destination;

		[Ordinal(0)] 
		[RED("destination")] 
		public Vector4 Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}
	}
}
