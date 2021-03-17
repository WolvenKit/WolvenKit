using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinsContainerController : gameuiProjectedHUDGameController
	{
		private CEnum<gamePSMVision> _psmVision;
		private CEnum<gamePSMCombat> _psmCombat;
		private CEnum<gamePSMZones> _psmZone;
		private CEnum<GameplayTier> _tier;
		private inkWidgetPath _spawnContainerPath;
		private inkLinePatternWidgetReference _gpsQuestPathWidget;
		private inkLinePatternWidgetReference _gpsPlayerTrackedPathWidget;

		[Ordinal(9)] 
		[RED("psmVision")] 
		public CEnum<gamePSMVision> PsmVision
		{
			get => GetProperty(ref _psmVision);
			set => SetProperty(ref _psmVision, value);
		}

		[Ordinal(10)] 
		[RED("psmCombat")] 
		public CEnum<gamePSMCombat> PsmCombat
		{
			get => GetProperty(ref _psmCombat);
			set => SetProperty(ref _psmCombat, value);
		}

		[Ordinal(11)] 
		[RED("psmZone")] 
		public CEnum<gamePSMZones> PsmZone
		{
			get => GetProperty(ref _psmZone);
			set => SetProperty(ref _psmZone, value);
		}

		[Ordinal(12)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(13)] 
		[RED("spawnContainerPath")] 
		public inkWidgetPath SpawnContainerPath
		{
			get => GetProperty(ref _spawnContainerPath);
			set => SetProperty(ref _spawnContainerPath, value);
		}

		[Ordinal(14)] 
		[RED("gpsQuestPathWidget")] 
		public inkLinePatternWidgetReference GpsQuestPathWidget
		{
			get => GetProperty(ref _gpsQuestPathWidget);
			set => SetProperty(ref _gpsQuestPathWidget, value);
		}

		[Ordinal(15)] 
		[RED("gpsPlayerTrackedPathWidget")] 
		public inkLinePatternWidgetReference GpsPlayerTrackedPathWidget
		{
			get => GetProperty(ref _gpsPlayerTrackedPathWidget);
			set => SetProperty(ref _gpsPlayerTrackedPathWidget, value);
		}

		public gameuiMappinsContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
