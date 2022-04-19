using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsSocket : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("osockStamp")] 
		public scnOutputSocketStamp OsockStamp
		{
			get => GetPropertyValue<scnOutputSocketStamp>();
			set => SetPropertyValue<scnOutputSocketStamp>(value);
		}

		public scneventsSocket()
		{
			Id = new() { Id = 18446744073709551615 };
			OsockStamp = new() { Name = 65535, Ordinal = 65535 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
