using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoadListGroup : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("playTimeLabel")] 
		public inkTextWidgetReference PlayTimeLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("lastSaveLabel")] 
		public inkTextWidgetReference LastSaveLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("lifePathText")] 
		public inkTextWidgetReference LifePathText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("characterLevel")] 
		public inkTextWidgetReference CharacterLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("characterLevelLabel")] 
		public inkTextWidgetReference CharacterLevelLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("expandIcon")] 
		public inkImageWidgetReference ExpandIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("expandIconBackground")] 
		public inkImageWidgetReference ExpandIconBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("frame")] 
		public inkImageWidgetReference Frame
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("sep1")] 
		public inkWidgetReference Sep1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("sep2")] 
		public inkWidgetReference Sep2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("background")] 
		public inkImageWidgetReference Background
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("metadata")] 
		public CHandle<SaveGroupInfo> Metadata
		{
			get => GetPropertyValue<CHandle<SaveGroupInfo>>();
			set => SetPropertyValue<CHandle<SaveGroupInfo>>(value);
		}

		[Ordinal(49)] 
		[RED("defaultAtlasPath")] 
		public redResourceReferenceScriptToken DefaultAtlasPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(50)] 
		[RED("isExpanded")] 
		public CBool IsExpanded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("tranistionAnimProxy")] 
		public CHandle<inkanimProxy> TranistionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(52)] 
		[RED("playthroughID")] 
		public CString PlaythroughID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(53)] 
		[RED("refocus")] 
		public CBool Refocus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("ensuredVisiblitiy")] 
		public CBool EnsuredVisiblitiy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("loadGameMenuController")] 
		public CWeakHandle<LoadGameMenuGameController> LoadGameMenuController
		{
			get => GetPropertyValue<CWeakHandle<LoadGameMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<LoadGameMenuGameController>>(value);
		}

		[Ordinal(56)] 
		[RED("buttonToRefocus")] 
		public CWeakHandle<inkWidget> ButtonToRefocus
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public LoadListGroup()
		{
			Lifepath = new inkImageWidgetReference();
			PlayTime = new inkTextWidgetReference();
			PlayTimeLabel = new inkTextWidgetReference();
			LabelDate = new inkTextWidgetReference();
			LastSaveLabel = new inkTextWidgetReference();
			LifePathText = new inkTextWidgetReference();
			CharacterLevel = new inkTextWidgetReference();
			CharacterLevelLabel = new inkTextWidgetReference();
			Wrapper = new inkWidgetReference();
			ExpandIcon = new inkImageWidgetReference();
			ExpandIconBackground = new inkImageWidgetReference();
			Frame = new inkImageWidgetReference();
			Sep1 = new inkWidgetReference();
			Sep2 = new inkWidgetReference();
			Background = new inkImageWidgetReference();
			DefaultAtlasPath = new redResourceReferenceScriptToken { Resource = new CResourceAsyncReference<CResource>(@"base\gameplay\gui\fullscreen\load_game\save_game.inkatlas") };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
