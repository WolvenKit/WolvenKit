using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMappinsContainerController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("psmVision")] 
		public CEnum<gamePSMVision> PsmVision
		{
			get => GetPropertyValue<CEnum<gamePSMVision>>();
			set => SetPropertyValue<CEnum<gamePSMVision>>(value);
		}

		[Ordinal(10)] 
		[RED("psmCombat")] 
		public CEnum<gamePSMCombat> PsmCombat
		{
			get => GetPropertyValue<CEnum<gamePSMCombat>>();
			set => SetPropertyValue<CEnum<gamePSMCombat>>(value);
		}

		[Ordinal(11)] 
		[RED("psmZone")] 
		public CEnum<gamePSMZones> PsmZone
		{
			get => GetPropertyValue<CEnum<gamePSMZones>>();
			set => SetPropertyValue<CEnum<gamePSMZones>>(value);
		}

		[Ordinal(12)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(13)] 
		[RED("spawnContainerPath")] 
		public inkWidgetPath SpawnContainerPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(14)] 
		[RED("gpsQuestPathWidget")] 
		public inkLinePatternWidgetReference GpsQuestPathWidget
		{
			get => GetPropertyValue<inkLinePatternWidgetReference>();
			set => SetPropertyValue<inkLinePatternWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("gpsPlayerTrackedPathWidget")] 
		public inkLinePatternWidgetReference GpsPlayerTrackedPathWidget
		{
			get => GetPropertyValue<inkLinePatternWidgetReference>();
			set => SetPropertyValue<inkLinePatternWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("gpsDelamainPathWidget")] 
		public inkLinePatternWidgetReference GpsDelamainPathWidget
		{
			get => GetPropertyValue<inkLinePatternWidgetReference>();
			set => SetPropertyValue<inkLinePatternWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("autodrivePathWidget")] 
		public inkLinePatternWidgetReference AutodrivePathWidget
		{
			get => GetPropertyValue<inkLinePatternWidgetReference>();
			set => SetPropertyValue<inkLinePatternWidgetReference>(value);
		}

		public gameuiMappinsContainerController()
		{
			Tier = Enums.GameplayTier.Tier1_FullGameplay;
			SpawnContainerPath = new inkWidgetPath { Names = new() };
			GpsQuestPathWidget = new inkLinePatternWidgetReference();
			GpsPlayerTrackedPathWidget = new inkLinePatternWidgetReference();
			GpsDelamainPathWidget = new inkLinePatternWidgetReference();
			AutodrivePathWidget = new inkLinePatternWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
