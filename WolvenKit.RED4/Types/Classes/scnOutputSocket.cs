using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOutputSocket : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stamp")] 
		public scnOutputSocketStamp Stamp
		{
			get => GetPropertyValue<scnOutputSocketStamp>();
			set => SetPropertyValue<scnOutputSocketStamp>(value);
		}

		[Ordinal(1)] 
		[RED("destinations")] 
		public CArray<scnInputSocketId> Destinations
		{
			get => GetPropertyValue<CArray<scnInputSocketId>>();
			set => SetPropertyValue<CArray<scnInputSocketId>>(value);
		}

		public scnOutputSocket()
		{
			Stamp = new scnOutputSocketStamp { Name = ushort.MaxValue, Ordinal = ushort.MaxValue };
			Destinations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
