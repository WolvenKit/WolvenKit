using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugFilterSetting_MeshResource : worldEditorDebugFilterSettings
	{
		private CArray<CString> _resourcePaths;

		[Ordinal(0)] 
		[RED("resourcePaths")] 
		public CArray<CString> ResourcePaths
		{
			get => GetProperty(ref _resourcePaths);
			set => SetProperty(ref _resourcePaths, value);
		}

		public worldDebugFilterSetting_MeshResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
