using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnOutputSocket : RedBaseClass
	{
		private scnOutputSocketStamp _stamp;
		private CArray<scnInputSocketId> _destinations;

		[Ordinal(0)] 
		[RED("stamp")] 
		public scnOutputSocketStamp Stamp
		{
			get => GetProperty(ref _stamp);
			set => SetProperty(ref _stamp, value);
		}

		[Ordinal(1)] 
		[RED("destinations")] 
		public CArray<scnInputSocketId> Destinations
		{
			get => GetProperty(ref _destinations);
			set => SetProperty(ref _destinations, value);
		}
	}
}
