using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPrefabVariantReplicatedInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("variantNameKey")] 
		public CName VariantNameKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPrefabVariantReplicatedInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
