using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkDebugLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] 
		[RED("entries")] 
		public CArray<inkDebugLayerEntry> Entries
		{
			get => GetPropertyValue<CArray<inkDebugLayerEntry>>();
			set => SetPropertyValue<CArray<inkDebugLayerEntry>>(value);
		}

		public inkDebugLayerDefinition()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
