using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		private CFloat _maxDistanceForSharedIndicators;
		private inkImageWidgetReference _arrowFrontWidget;
		private CFloat _damageThreshold;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _animProxy;
		private CFloat _damageTaken;
		private CBool _continuous;

		[Ordinal(3)] 
		[RED("maxDistanceForSharedIndicators")] 
		public CFloat MaxDistanceForSharedIndicators
		{
			get
			{
				if (_maxDistanceForSharedIndicators == null)
				{
					_maxDistanceForSharedIndicators = (CFloat) CR2WTypeManager.Create("Float", "maxDistanceForSharedIndicators", cr2w, this);
				}
				return _maxDistanceForSharedIndicators;
			}
			set
			{
				if (_maxDistanceForSharedIndicators == value)
				{
					return;
				}
				_maxDistanceForSharedIndicators = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("arrowFrontWidget")] 
		public inkImageWidgetReference ArrowFrontWidget
		{
			get
			{
				if (_arrowFrontWidget == null)
				{
					_arrowFrontWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrowFrontWidget", cr2w, this);
				}
				return _arrowFrontWidget;
			}
			set
			{
				if (_arrowFrontWidget == value)
				{
					return;
				}
				_arrowFrontWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get
			{
				if (_damageThreshold == null)
				{
					_damageThreshold = (CFloat) CR2WTypeManager.Create("Float", "damageThreshold", cr2w, this);
				}
				return _damageThreshold;
			}
			set
			{
				if (_damageThreshold == value)
				{
					return;
				}
				_damageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("damageTaken")] 
		public CFloat DamageTaken
		{
			get
			{
				if (_damageTaken == null)
				{
					_damageTaken = (CFloat) CR2WTypeManager.Create("Float", "damageTaken", cr2w, this);
				}
				return _damageTaken;
			}
			set
			{
				if (_damageTaken == value)
				{
					return;
				}
				_damageTaken = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("continuous")] 
		public CBool Continuous
		{
			get
			{
				if (_continuous == null)
				{
					_continuous = (CBool) CR2WTypeManager.Create("Bool", "continuous", cr2w, this);
				}
				return _continuous;
			}
			set
			{
				if (_continuous == value)
				{
					return;
				}
				_continuous = value;
				PropertySet(this);
			}
		}

		public gameuiDamageIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
