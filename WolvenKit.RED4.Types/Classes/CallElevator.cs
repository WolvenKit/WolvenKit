using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CallElevator : ActionBool
	{
		private CInt32 _destination;

		[Ordinal(25)] 
		[RED("destination")] 
		public CInt32 Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}
	}
}
