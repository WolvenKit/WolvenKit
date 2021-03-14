using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CentaurShieldController : AICustomComponents
	{
		private CBool _startWithShieldActive;
		private gameEffectRef _explosionAttack;
		private CName _animFeatureName;
		private CName _shieldDestroyedModifierName;
		private CEnum<ECentaurShieldState> _shieldState;
		private CHandle<gameIBlackboard> _centaurBlackboard;

		[Ordinal(5)] 
		[RED("startWithShieldActive")] 
		public CBool StartWithShieldActive
		{
			get
			{
				if (_startWithShieldActive == null)
				{
					_startWithShieldActive = (CBool) CR2WTypeManager.Create("Bool", "startWithShieldActive", cr2w, this);
				}
				return _startWithShieldActive;
			}
			set
			{
				if (_startWithShieldActive == value)
				{
					return;
				}
				_startWithShieldActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("explosionAttack")] 
		public gameEffectRef ExplosionAttack
		{
			get
			{
				if (_explosionAttack == null)
				{
					_explosionAttack = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "explosionAttack", cr2w, this);
				}
				return _explosionAttack;
			}
			set
			{
				if (_explosionAttack == value)
				{
					return;
				}
				_explosionAttack = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get
			{
				if (_animFeatureName == null)
				{
					_animFeatureName = (CName) CR2WTypeManager.Create("CName", "animFeatureName", cr2w, this);
				}
				return _animFeatureName;
			}
			set
			{
				if (_animFeatureName == value)
				{
					return;
				}
				_animFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("shieldDestroyedModifierName")] 
		public CName ShieldDestroyedModifierName
		{
			get
			{
				if (_shieldDestroyedModifierName == null)
				{
					_shieldDestroyedModifierName = (CName) CR2WTypeManager.Create("CName", "shieldDestroyedModifierName", cr2w, this);
				}
				return _shieldDestroyedModifierName;
			}
			set
			{
				if (_shieldDestroyedModifierName == value)
				{
					return;
				}
				_shieldDestroyedModifierName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("shieldState")] 
		public CEnum<ECentaurShieldState> ShieldState
		{
			get
			{
				if (_shieldState == null)
				{
					_shieldState = (CEnum<ECentaurShieldState>) CR2WTypeManager.Create("ECentaurShieldState", "shieldState", cr2w, this);
				}
				return _shieldState;
			}
			set
			{
				if (_shieldState == value)
				{
					return;
				}
				_shieldState = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		public CentaurShieldController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
