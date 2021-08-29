using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResourceLibraryComponent : gameScriptableComponent
	{
		private CArray<FxResourceMapData> _resources;

		[Ordinal(5)] 
		[RED("resources")] 
		public CArray<FxResourceMapData> Resources
		{
			get => GetProperty(ref _resources);
			set => SetProperty(ref _resources, value);
		}
	}
}
