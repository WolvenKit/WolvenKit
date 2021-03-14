using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterAim_ConditionType : questICharacterConditionType
	{
		private CBool _isPlayer;
		private CBool _preciseAiming;
		private gameEntityReference _targetRef;

		[Ordinal(0)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("preciseAiming")] 
		public CBool PreciseAiming
		{
			get
			{
				if (_preciseAiming == null)
				{
					_preciseAiming = (CBool) CR2WTypeManager.Create("Bool", "preciseAiming", cr2w, this);
				}
				return _preciseAiming;
			}
			set
			{
				if (_preciseAiming == value)
				{
					return;
				}
				_preciseAiming = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
				PropertySet(this);
			}
		}

		public questCharacterAim_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
