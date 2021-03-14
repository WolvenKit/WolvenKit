using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScalingData_KeepRelationWithOtherEvents : scnIScalingData
	{
		private scnSceneTime _groupRfrncNdspaceStarttime;
		private scnSceneTime _groupRfrncNdspaceEndtime;

		[Ordinal(0)] 
		[RED("groupRfrncNdspaceStarttime")] 
		public scnSceneTime GroupRfrncNdspaceStarttime
		{
			get
			{
				if (_groupRfrncNdspaceStarttime == null)
				{
					_groupRfrncNdspaceStarttime = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "groupRfrncNdspaceStarttime", cr2w, this);
				}
				return _groupRfrncNdspaceStarttime;
			}
			set
			{
				if (_groupRfrncNdspaceStarttime == value)
				{
					return;
				}
				_groupRfrncNdspaceStarttime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("groupRfrncNdspaceEndtime")] 
		public scnSceneTime GroupRfrncNdspaceEndtime
		{
			get
			{
				if (_groupRfrncNdspaceEndtime == null)
				{
					_groupRfrncNdspaceEndtime = (scnSceneTime) CR2WTypeManager.Create("scnSceneTime", "groupRfrncNdspaceEndtime", cr2w, this);
				}
				return _groupRfrncNdspaceEndtime;
			}
			set
			{
				if (_groupRfrncNdspaceEndtime == value)
				{
					return;
				}
				_groupRfrncNdspaceEndtime = value;
				PropertySet(this);
			}
		}

		public scnScalingData_KeepRelationWithOtherEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
