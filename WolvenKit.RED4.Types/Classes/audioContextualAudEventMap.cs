using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioContextualAudEventMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("contextualAudEventMapItems")] 
		public CArray<audioContextualAudEventMapItem> ContextualAudEventMapItems
		{
			get => GetPropertyValue<CArray<audioContextualAudEventMapItem>>();
			set => SetPropertyValue<CArray<audioContextualAudEventMapItem>>(value);
		}

		public audioContextualAudEventMap()
		{
			ContextualAudEventMapItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
