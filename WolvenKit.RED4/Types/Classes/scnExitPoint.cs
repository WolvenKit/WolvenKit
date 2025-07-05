using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnExitPoint : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		public scnExitPoint()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
