using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugFilterSetting_MeshResource : worldEditorDebugFilterSettings
	{
		private CArray<CString> _resourcePaths;

		[Ordinal(0)] 
		[RED("resourcePaths")] 
		public CArray<CString> ResourcePaths
		{
			get => GetProperty(ref _resourcePaths);
			set => SetProperty(ref _resourcePaths, value);
		}
	}
}
