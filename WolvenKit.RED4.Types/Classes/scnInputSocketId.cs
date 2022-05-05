using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInputSocketId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(1)] 
		[RED("isockStamp")] 
		public scnInputSocketStamp IsockStamp
		{
			get => GetPropertyValue<scnInputSocketStamp>();
			set => SetPropertyValue<scnInputSocketStamp>(value);
		}

		public scnInputSocketId()
		{
			NodeId = new() { Id = 4294967295 };
			IsockStamp = new() { Name = 65535, Ordinal = 65535 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
