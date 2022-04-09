using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workActorTagCondition : workIWorkspotCondition
	{
		[Ordinal(2)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workActorTagCondition()
		{
			Equals_ = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
