using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CentaurShieldLookatController : AILookatTask
	{
		private CHandle<entLookAtAddEvent> _mainShieldLookat;
		private CBool _mainShieldlookatActive;
		private wCHandle<gameObject> _currentLookatTarget;
		private wCHandle<gameObject> _shieldTarget;
		private CHandle<gameIBlackboard> _centaurBlackboard;
		private CFloat _shieldTargetTimeStamp;

		[Ordinal(0)] 
		[RED("mainShieldLookat")] 
		public CHandle<entLookAtAddEvent> MainShieldLookat
		{
			get
			{
				if (_mainShieldLookat == null)
				{
					_mainShieldLookat = (CHandle<entLookAtAddEvent>) CR2WTypeManager.Create("handle:entLookAtAddEvent", "mainShieldLookat", cr2w, this);
				}
				return _mainShieldLookat;
			}
			set
			{
				if (_mainShieldLookat == value)
				{
					return;
				}
				_mainShieldLookat = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mainShieldlookatActive")] 
		public CBool MainShieldlookatActive
		{
			get
			{
				if (_mainShieldlookatActive == null)
				{
					_mainShieldlookatActive = (CBool) CR2WTypeManager.Create("Bool", "mainShieldlookatActive", cr2w, this);
				}
				return _mainShieldlookatActive;
			}
			set
			{
				if (_mainShieldlookatActive == value)
				{
					return;
				}
				_mainShieldlookatActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentLookatTarget")] 
		public wCHandle<gameObject> CurrentLookatTarget
		{
			get
			{
				if (_currentLookatTarget == null)
				{
					_currentLookatTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "currentLookatTarget", cr2w, this);
				}
				return _currentLookatTarget;
			}
			set
			{
				if (_currentLookatTarget == value)
				{
					return;
				}
				_currentLookatTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("shieldTarget")] 
		public wCHandle<gameObject> ShieldTarget
		{
			get
			{
				if (_shieldTarget == null)
				{
					_shieldTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "shieldTarget", cr2w, this);
				}
				return _shieldTarget;
			}
			set
			{
				if (_shieldTarget == value)
				{
					return;
				}
				_shieldTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("centaurBlackboard")] 
		public CHandle<gameIBlackboard> CentaurBlackboard
		{
			get
			{
				if (_centaurBlackboard == null)
				{
					_centaurBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "centaurBlackboard", cr2w, this);
				}
				return _centaurBlackboard;
			}
			set
			{
				if (_centaurBlackboard == value)
				{
					return;
				}
				_centaurBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("shieldTargetTimeStamp")] 
		public CFloat ShieldTargetTimeStamp
		{
			get
			{
				if (_shieldTargetTimeStamp == null)
				{
					_shieldTargetTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "shieldTargetTimeStamp", cr2w, this);
				}
				return _shieldTargetTimeStamp;
			}
			set
			{
				if (_shieldTargetTimeStamp == value)
				{
					return;
				}
				_shieldTargetTimeStamp = value;
				PropertySet(this);
			}
		}

		public CentaurShieldLookatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
