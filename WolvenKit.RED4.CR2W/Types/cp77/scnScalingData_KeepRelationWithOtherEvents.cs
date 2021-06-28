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
			get => GetProperty(ref _groupRfrncNdspaceStarttime);
			set => SetProperty(ref _groupRfrncNdspaceStarttime, value);
		}

		[Ordinal(1)] 
		[RED("groupRfrncNdspaceEndtime")] 
		public scnSceneTime GroupRfrncNdspaceEndtime
		{
			get => GetProperty(ref _groupRfrncNdspaceEndtime);
			set => SetProperty(ref _groupRfrncNdspaceEndtime, value);
		}

		public scnScalingData_KeepRelationWithOtherEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
