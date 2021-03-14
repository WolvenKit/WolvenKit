using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapperComponent : gameScriptableComponent
	{
		private CArray<CHandle<WorkspotMapData>> _workspotsMap;

		[Ordinal(5)] 
		[RED("workspotsMap")] 
		public CArray<CHandle<WorkspotMapData>> WorkspotsMap
		{
			get
			{
				if (_workspotsMap == null)
				{
					_workspotsMap = (CArray<CHandle<WorkspotMapData>>) CR2WTypeManager.Create("array:handle:WorkspotMapData", "workspotsMap", cr2w, this);
				}
				return _workspotsMap;
			}
			set
			{
				if (_workspotsMap == value)
				{
					return;
				}
				_workspotsMap = value;
				PropertySet(this);
			}
		}

		public WorkspotMapperComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
