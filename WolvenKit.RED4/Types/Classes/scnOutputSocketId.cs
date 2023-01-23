using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOutputSocketId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(1)] 
		[RED("osockStamp")] 
		public scnOutputSocketStamp OsockStamp
		{
			get => GetPropertyValue<scnOutputSocketStamp>();
			set => SetPropertyValue<scnOutputSocketStamp>(value);
		}

		public scnOutputSocketId()
		{
			NodeId = new() { Id = 4294967295 };
			OsockStamp = new() { Name = 65535, Ordinal = 65535 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
