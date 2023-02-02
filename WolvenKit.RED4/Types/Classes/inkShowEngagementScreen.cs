using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkShowEngagementScreen : IScriptable
	{
		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkShowEngagementScreen()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
