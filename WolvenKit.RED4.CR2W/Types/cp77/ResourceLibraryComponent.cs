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
			get
			{
				if (_resources == null)
				{
					_resources = (CArray<FxResourceMapData>) CR2WTypeManager.Create("array:FxResourceMapData", "resources", cr2w, this);
				}
				return _resources;
			}
			set
			{
				if (_resources == value)
				{
					return;
				}
				_resources = value;
				PropertySet(this);
			}
		}

		public ResourceLibraryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
