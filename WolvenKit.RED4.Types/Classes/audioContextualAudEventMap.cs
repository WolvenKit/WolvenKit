using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioContextualAudEventMap : audioAudioMetadata
	{
		private CArray<audioContextualAudEventMapItem> _contextualAudEventMapItems;

		[Ordinal(1)] 
		[RED("contextualAudEventMapItems")] 
		public CArray<audioContextualAudEventMapItem> ContextualAudEventMapItems
		{
			get => GetProperty(ref _contextualAudEventMapItems);
			set => SetProperty(ref _contextualAudEventMapItems, value);
		}
	}
}
