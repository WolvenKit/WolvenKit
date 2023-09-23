using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsMenuUserData : inkUserData
	{
		[Ordinal(0)] 
		[RED("menuVisited")] 
		public CBool MenuVisited
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StatsMenuUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
