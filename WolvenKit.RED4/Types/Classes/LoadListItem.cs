using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoadListItem : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("imageReplacement")] 
		public inkImageWidgetReference ImageReplacement
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("type")] 
		public inkTextWidgetReference Type
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("quest")] 
		public inkTextWidgetReference Quest
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
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("cloudStatus")] 
		public inkImageWidgetReference CloudStatus
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("characterLevel")] 
		public inkTextWidgetReference CharacterLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("characterLevelLabel")] 
		public inkTextWidgetReference CharacterLevelLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("gameVersion")] 
		public inkTextWidgetReference GameVersion
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("fileSize")] 
		public inkTextWidgetReference FileSize
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("trophyIcon")] 
		public inkImageWidgetReference TrophyIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("modIcon")] 
		public inkImageWidgetReference ModIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("emptySlotWrapper")] 
		public inkWidgetReference EmptySlotWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("versionParams")] 
		public CHandle<textTextParameterSet> VersionParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(51)] 
		[RED("SaveIndex")] 
		public CInt32 SaveIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(52)] 
		[RED("buttonIndex")] 
		public CInt32 ButtonIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(53)] 
		[RED("emptySlot")] 
		public CBool EmptySlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("validSlot")] 
		public CBool ValidSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("initialLoadingID")] 
		public CUInt64 InitialLoadingID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(56)] 
		[RED("metadata")] 
		public CHandle<inkSaveMetadataInfo> Metadata
		{
			get => GetPropertyValue<CHandle<inkSaveMetadataInfo>>();
			set => SetPropertyValue<CHandle<inkSaveMetadataInfo>>(value);
		}

		[Ordinal(57)] 
		[RED("isMetadataSet")] 
		public CBool IsMetadataSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("defaultAtlasPath")] 
		public redResourceReferenceScriptToken DefaultAtlasPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(59)] 
		[RED("tranistionAnimProxy")] 
		public CHandle<inkanimProxy> TranistionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(60)] 
		[RED("tapped")] 
		public CBool Tapped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("ownerMenu")] 
		public CWeakHandle<LoadGameMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<LoadGameMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<LoadGameMenuGameController>>(value);
		}

		public LoadListItem()
		{
			ImageReplacement = new inkImageWidgetReference();
			Label = new inkTextWidgetReference();
			LabelDate = new inkTextWidgetReference();
			Type = new inkTextWidgetReference();
			Quest = new inkTextWidgetReference();
			LifePathText = new inkTextWidgetReference();
			Lifepath = new inkImageWidgetReference();
			CloudStatus = new inkImageWidgetReference();
			PlayTime = new inkTextWidgetReference();
			CharacterLevel = new inkTextWidgetReference();
			CharacterLevelLabel = new inkTextWidgetReference();
			GameVersion = new inkTextWidgetReference();
			FileSize = new inkTextWidgetReference();
			TrophyIcon = new inkImageWidgetReference();
			ModIcon = new inkImageWidgetReference();
			EmptySlotWrapper = new inkWidgetReference();
			Wrapper = new inkWidgetReference();
			DefaultAtlasPath = new redResourceReferenceScriptToken { Resource = new CResourceAsyncReference<CResource>(@"base\gameplay\gui\fullscreen\load_game\save_game.inkatlas") };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
