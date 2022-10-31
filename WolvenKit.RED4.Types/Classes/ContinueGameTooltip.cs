using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ContinueGameTooltip : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("mainContainer")] 
		public inkWidgetReference MainContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("imageReplacement")] 
		public inkImageWidgetReference ImageReplacement
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("networkStatusError")] 
		public inkWidgetReference NetworkStatusError
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("networkSyncingIndicator")] 
		public inkWidgetReference NetworkSyncingIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("location")] 
		public inkTextWidgetReference Location
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("quest")] 
		public inkTextWidgetReference Quest
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("cloudStatus")] 
		public inkImageWidgetReference CloudStatus
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("saveFileStatus")] 
		public CEnum<inkSaveStatus> SaveFileStatus
		{
			get => GetPropertyValue<CEnum<inkSaveStatus>>();
			set => SetPropertyValue<CEnum<inkSaveStatus>>(value);
		}

		[Ordinal(14)] 
		[RED("cloudSaveStatus")] 
		public CEnum<servicesCloudSavesQueryStatus> CloudSaveStatus
		{
			get => GetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>();
			set => SetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>(value);
		}

		[Ordinal(15)] 
		[RED("metaDataLoaded")] 
		public CBool MetaDataLoaded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("defaultAtlasPath")] 
		public redResourceReferenceScriptToken DefaultAtlasPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public ContinueGameTooltip()
		{
			MainContainer = new();
			ImageReplacement = new();
			NetworkStatusError = new();
			NetworkSyncingIndicator = new();
			Label = new();
			LabelDate = new();
			Location = new();
			Quest = new();
			Level = new();
			Lifepath = new();
			CloudStatus = new();
			PlayTime = new();
			DefaultAtlasPath = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
