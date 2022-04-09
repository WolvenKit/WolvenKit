using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questScene_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questScene_NodeType()
		{
			EntityReference = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
