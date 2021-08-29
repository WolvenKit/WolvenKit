using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnScalingData_KeepRelationWithOtherEvents : scnIScalingData
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
	}
}
