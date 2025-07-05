using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("definitionResource")] 
		public CResourceReference<gameinteractionsInteractionDescriptorResource> DefinitionResource
		{
			get => GetPropertyValue<CResourceReference<gameinteractionsInteractionDescriptorResource>>();
			set => SetPropertyValue<CResourceReference<gameinteractionsInteractionDescriptorResource>>(value);
		}

		[Ordinal(6)] 
		[RED("interactionRootOffset")] 
		public Vector3 InteractionRootOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("layerOverrides")] 
		public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverrides
		{
			get => GetPropertyValue<CArray<gameinteractionsInteractionDefinitionOverrider>>();
			set => SetPropertyValue<CArray<gameinteractionsInteractionDefinitionOverrider>>(value);
		}

		[Ordinal(8)] 
		[RED("layerOverridesTemp")] 
		public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverridesTemp
		{
			get => GetPropertyValue<CArray<gameinteractionsInteractionDefinitionOverrider>>();
			set => SetPropertyValue<CArray<gameinteractionsInteractionDefinitionOverrider>>(value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinteractionsComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			InteractionRootOffset = new Vector3();
			LayerOverrides = new();
			LayerOverridesTemp = new();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
