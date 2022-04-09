using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCpoArmouryItem : gameObject
	{
		[Ordinal(35)] 
		[RED("armouryItemID")] 
		public TweakDBID ArmouryItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameCpoArmouryItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
