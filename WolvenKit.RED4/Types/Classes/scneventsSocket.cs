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
			Id = new scnSceneEventId { Id = long.MaxValue };
			OsockStamp = new scnOutputSocketStamp { Name = ushort.MaxValue, Ordinal = ushort.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
