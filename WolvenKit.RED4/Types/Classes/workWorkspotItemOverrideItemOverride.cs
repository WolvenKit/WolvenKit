using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workWorkspotItemOverrideItemOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prevItemId")] 
		public TweakDBID PrevItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public TweakDBID NewItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public workWorkspotItemOverrideItemOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
