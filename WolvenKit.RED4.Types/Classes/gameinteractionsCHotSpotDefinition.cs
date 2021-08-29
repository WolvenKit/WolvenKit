using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsCHotSpotDefinition : RedBaseClass
	{
		private CBool _suppressor;
		private CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> _layersDefinition;

		[Ordinal(0)] 
		[RED("suppressor")] 
		public CBool Suppressor
		{
			get => GetProperty(ref _suppressor);
			set => SetProperty(ref _suppressor, value);
		}

		[Ordinal(1)] 
		[RED("layersDefinition")] 
		public CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> LayersDefinition
		{
			get => GetProperty(ref _layersDefinition);
			set => SetProperty(ref _layersDefinition, value);
		}
	}
}
