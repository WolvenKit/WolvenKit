using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MovableQuestTrigger : gameObject
	{
		[Ordinal(36)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("onlyDetectsPlayer")] 
		public CBool OnlyDetectsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MovableQuestTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
