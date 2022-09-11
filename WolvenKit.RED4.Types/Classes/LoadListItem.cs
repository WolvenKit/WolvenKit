using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoadListItem : AnimatedListItemController
	{
		[Ordinal(30)] 
		[RED("imageReplacement")] 
		public inkImageWidgetReference ImageReplacement
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("type")] 
		public inkTextWidgetReference Type
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("quest")] 
		public inkTextWidgetReference Quest
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("cloudStatus")] 
		public inkImageWidgetReference CloudStatus
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
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
		[RED("gameVersion")] 
		public inkTextWidgetReference GameVersion
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("emptySlotWrapper")] 
		public inkWidgetReference EmptySlotWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("versionParams")] 
		public CHandle<textTextParameterSet> VersionParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(45)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(46)] 
		[RED("emptySlot")] 
		public CBool EmptySlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("validSlot")] 
		public CBool ValidSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("initialLoadingID")] 
		public CUInt64 InitialLoadingID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(49)] 
		[RED("metadata")] 
		public CHandle<inkSaveMetadataInfo> Metadata
		{
			get => GetPropertyValue<CHandle<inkSaveMetadataInfo>>();
			set => SetPropertyValue<CHandle<inkSaveMetadataInfo>>(value);
		}

		[Ordinal(50)] 
		[RED("defaultAtlasPath")] 
		public redResourceReferenceScriptToken DefaultAtlasPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public LoadListItem()
		{
			ImageReplacement = new();
			Label = new();
			LabelDate = new();
			Type = new();
			Quest = new();
			Level = new();
			Lifepath = new();
			CloudStatus = new();
			PlayTime = new();
			CharacterLevel = new();
			CharacterLevelLabel = new();
			GameVersion = new();
			EmptySlotWrapper = new();
			Wrapper = new();
			DefaultAtlasPath = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
