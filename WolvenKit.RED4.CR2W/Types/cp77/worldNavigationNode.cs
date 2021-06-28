using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationNode : worldNode
	{
		private raRef<worldNavigationTileResource> _navigationTileResource;

		[Ordinal(4)] 
		[RED("navigationTileResource")] 
		public raRef<worldNavigationTileResource> NavigationTileResource
		{
			get => GetProperty(ref _navigationTileResource);
			set => SetProperty(ref _navigationTileResource, value);
		}

		public worldNavigationNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
