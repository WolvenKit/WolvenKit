using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SingleCooldownManager : inkWidgetLogicController
	{
		private inkImageWidgetReference _sprite;
		private inkImageWidgetReference _spriteBg;
		private inkImageWidgetReference _icon;
		private CEnum<ECooldownGameControllerMode> _type;
		private inkTextWidgetReference _name;
		private inkTextWidgetReference _desc;
		private inkTextWidgetReference _timeRemaining;
		private inkTextWidgetReference _stackCount;
		private inkRectangleWidgetReference _fill;
		private CFloat _outroDuration;
		private Vector2 _fullSizeValue;
		private CFloat _initialDuration;
		private CEnum<ECooldownIndicatorState> _state;
		private inkCompoundWidgetReference _pool;
		private inkCompoundWidgetReference _grid;
		private CHandle<inkanimProxy> _currentAnimProxy;
		private UIBuffInfo _buffData;
		private CString _defaultTimeRemainingText;
		private TweakDBID _excludedStatusEffect;
		private CString _c_EXCLUDED_STATUS_EFFECT_NAME;

		[Ordinal(1)] 
		[RED("sprite")] 
		public inkImageWidgetReference Sprite
		{
			get
			{
				if (_sprite == null)
				{
					_sprite = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "sprite", cr2w, this);
				}
				return _sprite;
			}
			set
			{
				if (_sprite == value)
				{
					return;
				}
				_sprite = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spriteBg")] 
		public inkImageWidgetReference SpriteBg
		{
			get
			{
				if (_spriteBg == null)
				{
					_spriteBg = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "spriteBg", cr2w, this);
				}
				return _spriteBg;
			}
			set
			{
				if (_spriteBg == value)
				{
					return;
				}
				_spriteBg = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<ECooldownGameControllerMode> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<ECooldownGameControllerMode>) CR2WTypeManager.Create("ECooldownGameControllerMode", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("name")] 
		public inkTextWidgetReference Name
		{
			get
			{
				if (_name == null)
				{
					_name = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get
			{
				if (_desc == null)
				{
					_desc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc", cr2w, this);
				}
				return _desc;
			}
			set
			{
				if (_desc == value)
				{
					return;
				}
				_desc = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timeRemaining")] 
		public inkTextWidgetReference TimeRemaining
		{
			get
			{
				if (_timeRemaining == null)
				{
					_timeRemaining = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timeRemaining", cr2w, this);
				}
				return _timeRemaining;
			}
			set
			{
				if (_timeRemaining == value)
				{
					return;
				}
				_timeRemaining = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stackCount")] 
		public inkTextWidgetReference StackCount
		{
			get
			{
				if (_stackCount == null)
				{
					_stackCount = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "stackCount", cr2w, this);
				}
				return _stackCount;
			}
			set
			{
				if (_stackCount == value)
				{
					return;
				}
				_stackCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("fill")] 
		public inkRectangleWidgetReference Fill
		{
			get
			{
				if (_fill == null)
				{
					_fill = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "fill", cr2w, this);
				}
				return _fill;
			}
			set
			{
				if (_fill == value)
				{
					return;
				}
				_fill = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("outroDuration")] 
		public CFloat OutroDuration
		{
			get
			{
				if (_outroDuration == null)
				{
					_outroDuration = (CFloat) CR2WTypeManager.Create("Float", "outroDuration", cr2w, this);
				}
				return _outroDuration;
			}
			set
			{
				if (_outroDuration == value)
				{
					return;
				}
				_outroDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("fullSizeValue")] 
		public Vector2 FullSizeValue
		{
			get
			{
				if (_fullSizeValue == null)
				{
					_fullSizeValue = (Vector2) CR2WTypeManager.Create("Vector2", "fullSizeValue", cr2w, this);
				}
				return _fullSizeValue;
			}
			set
			{
				if (_fullSizeValue == value)
				{
					return;
				}
				_fullSizeValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("initialDuration")] 
		public CFloat InitialDuration
		{
			get
			{
				if (_initialDuration == null)
				{
					_initialDuration = (CFloat) CR2WTypeManager.Create("Float", "initialDuration", cr2w, this);
				}
				return _initialDuration;
			}
			set
			{
				if (_initialDuration == value)
				{
					return;
				}
				_initialDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("state")] 
		public CEnum<ECooldownIndicatorState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ECooldownIndicatorState>) CR2WTypeManager.Create("ECooldownIndicatorState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("pool")] 
		public inkCompoundWidgetReference Pool
		{
			get
			{
				if (_pool == null)
				{
					_pool = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "pool", cr2w, this);
				}
				return _pool;
			}
			set
			{
				if (_pool == value)
				{
					return;
				}
				_pool = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("grid")] 
		public inkCompoundWidgetReference Grid
		{
			get
			{
				if (_grid == null)
				{
					_grid = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "grid", cr2w, this);
				}
				return _grid;
			}
			set
			{
				if (_grid == value)
				{
					return;
				}
				_grid = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("currentAnimProxy")] 
		public CHandle<inkanimProxy> CurrentAnimProxy
		{
			get
			{
				if (_currentAnimProxy == null)
				{
					_currentAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "currentAnimProxy", cr2w, this);
				}
				return _currentAnimProxy;
			}
			set
			{
				if (_currentAnimProxy == value)
				{
					return;
				}
				_currentAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("buffData")] 
		public UIBuffInfo BuffData
		{
			get
			{
				if (_buffData == null)
				{
					_buffData = (UIBuffInfo) CR2WTypeManager.Create("UIBuffInfo", "buffData", cr2w, this);
				}
				return _buffData;
			}
			set
			{
				if (_buffData == value)
				{
					return;
				}
				_buffData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("defaultTimeRemainingText")] 
		public CString DefaultTimeRemainingText
		{
			get
			{
				if (_defaultTimeRemainingText == null)
				{
					_defaultTimeRemainingText = (CString) CR2WTypeManager.Create("String", "defaultTimeRemainingText", cr2w, this);
				}
				return _defaultTimeRemainingText;
			}
			set
			{
				if (_defaultTimeRemainingText == value)
				{
					return;
				}
				_defaultTimeRemainingText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("excludedStatusEffect")] 
		public TweakDBID ExcludedStatusEffect
		{
			get
			{
				if (_excludedStatusEffect == null)
				{
					_excludedStatusEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "excludedStatusEffect", cr2w, this);
				}
				return _excludedStatusEffect;
			}
			set
			{
				if (_excludedStatusEffect == value)
				{
					return;
				}
				_excludedStatusEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("C_EXCLUDED_STATUS_EFFECT_NAME")] 
		public CString C_EXCLUDED_STATUS_EFFECT_NAME
		{
			get
			{
				if (_c_EXCLUDED_STATUS_EFFECT_NAME == null)
				{
					_c_EXCLUDED_STATUS_EFFECT_NAME = (CString) CR2WTypeManager.Create("String", "C_EXCLUDED_STATUS_EFFECT_NAME", cr2w, this);
				}
				return _c_EXCLUDED_STATUS_EFFECT_NAME;
			}
			set
			{
				if (_c_EXCLUDED_STATUS_EFFECT_NAME == value)
				{
					return;
				}
				_c_EXCLUDED_STATUS_EFFECT_NAME = value;
				PropertySet(this);
			}
		}

		public SingleCooldownManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
