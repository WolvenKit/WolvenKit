using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ContinueGameTooltip : TrophyTooltipController
	{
		[Ordinal(2)] 
		[RED("mainContainer")] 
		public inkWidgetReference MainContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("imageReplacement")] 
		public inkImageWidgetReference ImageReplacement
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("networkStatusError")] 
		public inkWidgetReference NetworkStatusError
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("networkSyncingIndicator")] 
		public inkWidgetReference NetworkSyncingIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("location")] 
		public inkTextWidgetReference Location
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("quest")] 
		public inkTextWidgetReference Quest
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("cloudStatus")] 
		public inkImageWidgetReference CloudStatus
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("moddedStatus")] 
		public inkImageWidgetReference ModdedStatus
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("trophyStatus")] 
		public inkImageWidgetReference TrophyStatus
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("saveMetaDataBlock")] 
		public inkWidgetReference SaveMetaDataBlock
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("dividerModVerification")] 
		public inkWidgetReference DividerModVerification
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("modVerificationContent")] 
		public inkWidgetReference ModVerificationContent
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("saveFileStatus")] 
		public CEnum<inkSaveStatus> SaveFileStatus
		{
			get => GetPropertyValue<CEnum<inkSaveStatus>>();
			set => SetPropertyValue<CEnum<inkSaveStatus>>(value);
		}

		[Ordinal(20)] 
		[RED("cloudSaveStatus")] 
		public CEnum<servicesCloudSavesQueryStatus> CloudSaveStatus
		{
			get => GetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>();
			set => SetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>(value);
		}

		[Ordinal(21)] 
		[RED("metaDataLoaded")] 
		public CBool MetaDataLoaded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("defaultAtlasPath")] 
		public redResourceReferenceScriptToken DefaultAtlasPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(24)] 
		[RED("isModded")] 
		public CBool IsModded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ContinueGameTooltip()
		{
			MainContainer = new inkWidgetReference();
			ImageReplacement = new inkImageWidgetReference();
			NetworkStatusError = new inkWidgetReference();
			NetworkSyncingIndicator = new inkWidgetReference();
			Label = new inkTextWidgetReference();
			LabelDate = new inkTextWidgetReference();
			Location = new inkTextWidgetReference();
			Quest = new inkTextWidgetReference();
			Level = new inkTextWidgetReference();
			Lifepath = new inkImageWidgetReference();
			CloudStatus = new inkImageWidgetReference();
			ModdedStatus = new inkImageWidgetReference();
			TrophyStatus = new inkImageWidgetReference();
			SaveMetaDataBlock = new inkWidgetReference();
			DividerModVerification = new inkWidgetReference();
			ModVerificationContent = new inkWidgetReference();
			PlayTime = new inkTextWidgetReference();
			DefaultAtlasPath = new redResourceReferenceScriptToken { Resource = new CResourceAsyncReference<CResource>(@"base\gameplay\gui\fullscreen\load_game\save_game.inkatlas") };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
