using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HiddenModItem : MutedItemCosmetic
	{
		[Ordinal(20)] 
		[RED("checkboxCanvas")] 
		public inkWidgetReference CheckboxCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("modNametext")] 
		public inkTextWidgetReference ModNametext
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("modAuthorName")] 
		public inkTextWidgetReference ModAuthorName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("logoWidget")] 
		public inkImageWidgetReference LogoWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("isHiddenState")] 
		public CBool IsHiddenState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("modInfo")] 
		public inkModioModInfos ModInfo
		{
			get => GetPropertyValue<inkModioModInfos>();
			set => SetPropertyValue<inkModioModInfos>(value);
		}

		[Ordinal(26)] 
		[RED("managerRef")] 
		public CWeakHandle<HiddenModManager> ManagerRef
		{
			get => GetPropertyValue<CWeakHandle<HiddenModManager>>();
			set => SetPropertyValue<CWeakHandle<HiddenModManager>>(value);
		}

		public HiddenModItem()
		{
			CheckboxCanvas = new inkWidgetReference();
			ModNametext = new inkTextWidgetReference();
			ModAuthorName = new inkTextWidgetReference();
			LogoWidget = new inkImageWidgetReference();
			ModInfo = new inkModioModInfos();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
