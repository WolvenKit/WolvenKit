using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLayersResource : CResource
	{
		[Ordinal(1)] 
		[RED("layerDefinitions")] 
		public inkLayerDefinitionCollection LayerDefinitions
		{
			get => GetPropertyValue<inkLayerDefinitionCollection>();
			set => SetPropertyValue<inkLayerDefinitionCollection>(value);
		}

		[Ordinal(2)] 
		[RED("preGameLayerDefinitions")] 
		public inkLayerDefinitionCollection PreGameLayerDefinitions
		{
			get => GetPropertyValue<inkLayerDefinitionCollection>();
			set => SetPropertyValue<inkLayerDefinitionCollection>(value);
		}

		[Ordinal(3)] 
		[RED("permanentLayerDefinitions")] 
		public inkPermanentLayerDefinitionCollection PermanentLayerDefinitions
		{
			get => GetPropertyValue<inkPermanentLayerDefinitionCollection>();
			set => SetPropertyValue<inkPermanentLayerDefinitionCollection>(value);
		}

		[Ordinal(4)] 
		[RED("layerDefinitionsSet")] 
		public inkLayerDefinitionsSet LayerDefinitionsSet
		{
			get => GetPropertyValue<inkLayerDefinitionsSet>();
			set => SetPropertyValue<inkLayerDefinitionsSet>(value);
		}

		public inkLayersResource()
		{
			LayerDefinitions = new inkLayerDefinitionCollection();
			PreGameLayerDefinitions = new inkLayerDefinitionCollection();
			PermanentLayerDefinitions = new inkPermanentLayerDefinitionCollection();
			LayerDefinitionsSet = new inkLayerDefinitionsSet();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
