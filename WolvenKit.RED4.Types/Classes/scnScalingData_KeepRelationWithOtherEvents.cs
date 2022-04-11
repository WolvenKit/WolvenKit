using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnScalingData_KeepRelationWithOtherEvents : scnIScalingData
	{
		[Ordinal(0)] 
		[RED("groupRfrncNdspaceStarttime")] 
		public scnSceneTime GroupRfrncNdspaceStarttime
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		[Ordinal(1)] 
		[RED("groupRfrncNdspaceEndtime")] 
		public scnSceneTime GroupRfrncNdspaceEndtime
		{
			get => GetPropertyValue<scnSceneTime>();
			set => SetPropertyValue<scnSceneTime>(value);
		}

		public scnScalingData_KeepRelationWithOtherEvents()
		{
			GroupRfrncNdspaceStarttime = new();
			GroupRfrncNdspaceEndtime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
