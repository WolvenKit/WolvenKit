using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsComponent : entIPlacedComponent
	{
		private CResourceReference<gameinteractionsInteractionDescriptorResource> _definitionResource;
		private Vector3 _interactionRootOffset;
		private CArray<gameinteractionsInteractionDefinitionOverrider> _layerOverrides;
		private CArray<gameinteractionsInteractionDefinitionOverrider> _layerOverridesTemp;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("definitionResource")] 
		public CResourceReference<gameinteractionsInteractionDescriptorResource> DefinitionResource
		{
			get => GetProperty(ref _definitionResource);
			set => SetProperty(ref _definitionResource, value);
		}

		[Ordinal(6)] 
		[RED("interactionRootOffset")] 
		public Vector3 InteractionRootOffset
		{
			get => GetProperty(ref _interactionRootOffset);
			set => SetProperty(ref _interactionRootOffset, value);
		}

		[Ordinal(7)] 
		[RED("layerOverrides")] 
		public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverrides
		{
			get => GetProperty(ref _layerOverrides);
			set => SetProperty(ref _layerOverrides, value);
		}

		[Ordinal(8)] 
		[RED("layerOverridesTemp")] 
		public CArray<gameinteractionsInteractionDefinitionOverrider> LayerOverridesTemp
		{
			get => GetProperty(ref _layerOverridesTemp);
			set => SetProperty(ref _layerOverridesTemp, value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
