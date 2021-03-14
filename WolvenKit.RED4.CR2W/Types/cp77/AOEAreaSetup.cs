using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEAreaSetup : CVariable
	{
		private TweakDBID _areaEffect;
		private TweakDBID _actionName;
		private CBool _blocksVisibility;
		private CBool _isDangerous;
		private CBool _activateOnStartup;
		private CBool _effectsOnlyActiveInArea;
		private CFloat _duration;
		private TweakDBID _actionWidgetRecord;
		private TweakDBID _deviceWidgetRecord;
		private TweakDBID _thumbnailWidgetRecord;

		[Ordinal(0)] 
		[RED("areaEffect")] 
		public TweakDBID AreaEffect
		{
			get
			{
				if (_areaEffect == null)
				{
					_areaEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "areaEffect", cr2w, this);
				}
				return _areaEffect;
			}
			set
			{
				if (_areaEffect == value)
				{
					return;
				}
				_areaEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public TweakDBID ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blocksVisibility")] 
		public CBool BlocksVisibility
		{
			get
			{
				if (_blocksVisibility == null)
				{
					_blocksVisibility = (CBool) CR2WTypeManager.Create("Bool", "blocksVisibility", cr2w, this);
				}
				return _blocksVisibility;
			}
			set
			{
				if (_blocksVisibility == value)
				{
					return;
				}
				_blocksVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isDangerous")] 
		public CBool IsDangerous
		{
			get
			{
				if (_isDangerous == null)
				{
					_isDangerous = (CBool) CR2WTypeManager.Create("Bool", "isDangerous", cr2w, this);
				}
				return _isDangerous;
			}
			set
			{
				if (_isDangerous == value)
				{
					return;
				}
				_isDangerous = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("activateOnStartup")] 
		public CBool ActivateOnStartup
		{
			get
			{
				if (_activateOnStartup == null)
				{
					_activateOnStartup = (CBool) CR2WTypeManager.Create("Bool", "activateOnStartup", cr2w, this);
				}
				return _activateOnStartup;
			}
			set
			{
				if (_activateOnStartup == value)
				{
					return;
				}
				_activateOnStartup = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("effectsOnlyActiveInArea")] 
		public CBool EffectsOnlyActiveInArea
		{
			get
			{
				if (_effectsOnlyActiveInArea == null)
				{
					_effectsOnlyActiveInArea = (CBool) CR2WTypeManager.Create("Bool", "effectsOnlyActiveInArea", cr2w, this);
				}
				return _effectsOnlyActiveInArea;
			}
			set
			{
				if (_effectsOnlyActiveInArea == value)
				{
					return;
				}
				_effectsOnlyActiveInArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("actionWidgetRecord")] 
		public TweakDBID ActionWidgetRecord
		{
			get
			{
				if (_actionWidgetRecord == null)
				{
					_actionWidgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionWidgetRecord", cr2w, this);
				}
				return _actionWidgetRecord;
			}
			set
			{
				if (_actionWidgetRecord == value)
				{
					return;
				}
				_actionWidgetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get
			{
				if (_deviceWidgetRecord == null)
				{
					_deviceWidgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "deviceWidgetRecord", cr2w, this);
				}
				return _deviceWidgetRecord;
			}
			set
			{
				if (_deviceWidgetRecord == value)
				{
					return;
				}
				_deviceWidgetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("thumbnailWidgetRecord")] 
		public TweakDBID ThumbnailWidgetRecord
		{
			get
			{
				if (_thumbnailWidgetRecord == null)
				{
					_thumbnailWidgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "thumbnailWidgetRecord", cr2w, this);
				}
				return _thumbnailWidgetRecord;
			}
			set
			{
				if (_thumbnailWidgetRecord == value)
				{
					return;
				}
				_thumbnailWidgetRecord = value;
				PropertySet(this);
			}
		}

		public AOEAreaSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
