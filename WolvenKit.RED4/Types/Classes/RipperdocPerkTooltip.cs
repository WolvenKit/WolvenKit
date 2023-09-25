using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocPerkTooltip : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("perkName")] 
		public inkTextWidgetReference PerkName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("skeletonPerkLocKey")] 
		public CName SkeletonPerkLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("handsPerkLocKey")] 
		public CName HandsPerkLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("skeletonPerkIconName")] 
		public CName SkeletonPerkIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("handsPerkIconName")] 
		public CName HandsPerkIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public RipperdocPerkTooltip()
		{
			PerkName = new inkTextWidgetReference();
			PerkIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
