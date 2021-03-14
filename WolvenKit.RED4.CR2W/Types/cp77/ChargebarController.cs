using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargebarController : inkWidgetLogicController
	{
		private inkWidgetReference _foreground;
		private inkWidgetReference _midground;
		private inkWidgetReference _background;
		private CName _maxChargeAnimationName;
		private CHandle<inkanimProxy> _animationMaxCharge;
		private CHandle<gameStatsSystem> _statsSystem;
		private CBool _canFullyCharge;
		private CBool _canOvercharge;
		private CHandle<ChargebarStatsListener> _listenerFullCharge;
		private CHandle<ChargebarStatsListener> _listenerOvercharge;

		[Ordinal(1)] 
		[RED("foreground")] 
		public inkWidgetReference Foreground
		{
			get
			{
				if (_foreground == null)
				{
					_foreground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "foreground", cr2w, this);
				}
				return _foreground;
			}
			set
			{
				if (_foreground == value)
				{
					return;
				}
				_foreground = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("midground")] 
		public inkWidgetReference Midground
		{
			get
			{
				if (_midground == null)
				{
					_midground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "midground", cr2w, this);
				}
				return _midground;
			}
			set
			{
				if (_midground == value)
				{
					return;
				}
				_midground = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxChargeAnimationName")] 
		public CName MaxChargeAnimationName
		{
			get
			{
				if (_maxChargeAnimationName == null)
				{
					_maxChargeAnimationName = (CName) CR2WTypeManager.Create("CName", "maxChargeAnimationName", cr2w, this);
				}
				return _maxChargeAnimationName;
			}
			set
			{
				if (_maxChargeAnimationName == value)
				{
					return;
				}
				_maxChargeAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animationMaxCharge")] 
		public CHandle<inkanimProxy> AnimationMaxCharge
		{
			get
			{
				if (_animationMaxCharge == null)
				{
					_animationMaxCharge = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationMaxCharge", cr2w, this);
				}
				return _animationMaxCharge;
			}
			set
			{
				if (_animationMaxCharge == value)
				{
					return;
				}
				_animationMaxCharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get
			{
				if (_statsSystem == null)
				{
					_statsSystem = (CHandle<gameStatsSystem>) CR2WTypeManager.Create("handle:gameStatsSystem", "statsSystem", cr2w, this);
				}
				return _statsSystem;
			}
			set
			{
				if (_statsSystem == value)
				{
					return;
				}
				_statsSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("canFullyCharge")] 
		public CBool CanFullyCharge
		{
			get
			{
				if (_canFullyCharge == null)
				{
					_canFullyCharge = (CBool) CR2WTypeManager.Create("Bool", "canFullyCharge", cr2w, this);
				}
				return _canFullyCharge;
			}
			set
			{
				if (_canFullyCharge == value)
				{
					return;
				}
				_canFullyCharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("canOvercharge")] 
		public CBool CanOvercharge
		{
			get
			{
				if (_canOvercharge == null)
				{
					_canOvercharge = (CBool) CR2WTypeManager.Create("Bool", "canOvercharge", cr2w, this);
				}
				return _canOvercharge;
			}
			set
			{
				if (_canOvercharge == value)
				{
					return;
				}
				_canOvercharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("listenerFullCharge")] 
		public CHandle<ChargebarStatsListener> ListenerFullCharge
		{
			get
			{
				if (_listenerFullCharge == null)
				{
					_listenerFullCharge = (CHandle<ChargebarStatsListener>) CR2WTypeManager.Create("handle:ChargebarStatsListener", "listenerFullCharge", cr2w, this);
				}
				return _listenerFullCharge;
			}
			set
			{
				if (_listenerFullCharge == value)
				{
					return;
				}
				_listenerFullCharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("listenerOvercharge")] 
		public CHandle<ChargebarStatsListener> ListenerOvercharge
		{
			get
			{
				if (_listenerOvercharge == null)
				{
					_listenerOvercharge = (CHandle<ChargebarStatsListener>) CR2WTypeManager.Create("handle:ChargebarStatsListener", "listenerOvercharge", cr2w, this);
				}
				return _listenerOvercharge;
			}
			set
			{
				if (_listenerOvercharge == value)
				{
					return;
				}
				_listenerOvercharge = value;
				PropertySet(this);
			}
		}

		public ChargebarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
