using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDynamicMeshNode : worldMeshNode
	{
		[Ordinal(16)] 
		[RED("startAsleep")] 
		public CBool StartAsleep
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("isDebris")] 
		public CBool IsDebris
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("initialGuess")] 
		public CBool InitialGuess
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get => GetPropertyValue<TrafficGenDynamicTrafficSetting>();
			set => SetPropertyValue<TrafficGenDynamicTrafficSetting>(value);
		}

		[Ordinal(20)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(21)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldDynamicMeshNode()
		{
			IsDebris = true;
			InitialGuess = true;
			DynamicTrafficSetting = new();
			NavigationSetting = new() { NavmeshImpact = Enums.NavGenNavmeshImpact.Blocking };
			UseMeshNavmeshSettings = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
