using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResourceLibraryComponent : gameScriptableComponent
	{
		private CArray<FxResourceMapData> _resources;

		[Ordinal(5)] 
		[RED("resources")] 
		public CArray<FxResourceMapData> Resources
		{
			get => GetProperty(ref _resources);
			set => SetProperty(ref _resources, value);
		}

		public ResourceLibraryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
