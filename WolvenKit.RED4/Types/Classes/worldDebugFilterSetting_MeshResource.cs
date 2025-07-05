using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugFilterSetting_MeshResource : worldEditorDebugFilterSettings
	{
		[Ordinal(0)] 
		[RED("resourcePaths")] 
		public CArray<CString> ResourcePaths
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public worldDebugFilterSetting_MeshResource()
		{
			ResourcePaths = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
