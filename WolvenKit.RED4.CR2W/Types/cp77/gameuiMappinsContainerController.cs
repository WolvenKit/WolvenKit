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
			get
			{
				if (_psmVision == null)
				{
					_psmVision = (CEnum<gamePSMVision>) CR2WTypeManager.Create("gamePSMVision", "psmVision", cr2w, this);
				}
				return _psmVision;
			}
			set
			{
				if (_psmVision == value)
				{
					return;
				}
				_psmVision = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("psmCombat")] 
		public CEnum<gamePSMCombat> PsmCombat
		{
			get
			{
				if (_psmCombat == null)
				{
					_psmCombat = (CEnum<gamePSMCombat>) CR2WTypeManager.Create("gamePSMCombat", "psmCombat", cr2w, this);
				}
				return _psmCombat;
			}
			set
			{
				if (_psmCombat == value)
				{
					return;
				}
				_psmCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("psmZone")] 
		public CEnum<gamePSMZones> PsmZone
		{
			get
			{
				if (_psmZone == null)
				{
					_psmZone = (CEnum<gamePSMZones>) CR2WTypeManager.Create("gamePSMZones", "psmZone", cr2w, this);
				}
				return _psmZone;
			}
			set
			{
				if (_psmZone == value)
				{
					return;
				}
				_psmZone = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (CEnum<GameplayTier>) CR2WTypeManager.Create("GameplayTier", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("spawnContainerPath")] 
		public inkWidgetPath SpawnContainerPath
		{
			get
			{
				if (_spawnContainerPath == null)
				{
					_spawnContainerPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "spawnContainerPath", cr2w, this);
				}
				return _spawnContainerPath;
			}
			set
			{
				if (_spawnContainerPath == value)
				{
					return;
				}
				_spawnContainerPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("gpsQuestPathWidget")] 
		public inkLinePatternWidgetReference GpsQuestPathWidget
		{
			get
			{
				if (_gpsQuestPathWidget == null)
				{
					_gpsQuestPathWidget = (inkLinePatternWidgetReference) CR2WTypeManager.Create("inkLinePatternWidgetReference", "gpsQuestPathWidget", cr2w, this);
				}
				return _gpsQuestPathWidget;
			}
			set
			{
				if (_gpsQuestPathWidget == value)
				{
					return;
				}
				_gpsQuestPathWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("gpsPlayerTrackedPathWidget")] 
		public inkLinePatternWidgetReference GpsPlayerTrackedPathWidget
		{
			get
			{
				if (_gpsPlayerTrackedPathWidget == null)
				{
					_gpsPlayerTrackedPathWidget = (inkLinePatternWidgetReference) CR2WTypeManager.Create("inkLinePatternWidgetReference", "gpsPlayerTrackedPathWidget", cr2w, this);
				}
				return _gpsPlayerTrackedPathWidget;
			}
			set
			{
				if (_gpsPlayerTrackedPathWidget == value)
				{
					return;
				}
				_gpsPlayerTrackedPathWidget = value;
				PropertySet(this);
			}
		}

		public gameuiMappinsContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
