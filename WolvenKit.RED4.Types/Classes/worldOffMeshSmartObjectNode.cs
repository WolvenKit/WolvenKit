using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldOffMeshSmartObjectNode : worldOffMeshConnectionNode
	{
		[Ordinal(13)] 
		[RED("object")] 
		public CHandle<gameSmartObjectDefinition> Object
		{
			get => GetPropertyValue<CHandle<gameSmartObjectDefinition>>();
			set => SetPropertyValue<CHandle<gameSmartObjectDefinition>>(value);
		}

		public worldOffMeshSmartObjectNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
