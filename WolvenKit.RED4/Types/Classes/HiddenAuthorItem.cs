using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HiddenAuthorItem : MutedItemCosmetic
	{
		[Ordinal(20)] 
		[RED("checkboxCanvas")] 
		public inkWidgetReference CheckboxCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("authorNameText")] 
		public inkTextWidgetReference AuthorNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("authorInfo")] 
		public inkModAuthorInfo AuthorInfo
		{
			get => GetPropertyValue<inkModAuthorInfo>();
			set => SetPropertyValue<inkModAuthorInfo>(value);
		}

		[Ordinal(23)] 
		[RED("managerRef")] 
		public CWeakHandle<HiddenModManager> ManagerRef
		{
			get => GetPropertyValue<CWeakHandle<HiddenModManager>>();
			set => SetPropertyValue<CWeakHandle<HiddenModManager>>(value);
		}

		[Ordinal(24)] 
		[RED("isHiddenState")] 
		public CBool IsHiddenState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HiddenAuthorItem()
		{
			CheckboxCanvas = new inkWidgetReference();
			AuthorNameText = new inkTextWidgetReference();
			AuthorInfo = new inkModAuthorInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
