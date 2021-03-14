using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterAttack_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _attackerRef;
		private gameEntityReference _targetRef;
		private CBool _isTargetPlayer;

		[Ordinal(0)] 
		[RED("attackerRef")] 
		public gameEntityReference AttackerRef
		{
			get
			{
				if (_attackerRef == null)
				{
					_attackerRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "attackerRef", cr2w, this);
				}
				return _attackerRef;
			}
			set
			{
				if (_attackerRef == value)
				{
					return;
				}
				_attackerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("isTargetPlayer")] 
		public CBool IsTargetPlayer
		{
			get
			{
				if (_isTargetPlayer == null)
				{
					_isTargetPlayer = (CBool) CR2WTypeManager.Create("Bool", "isTargetPlayer", cr2w, this);
				}
				return _isTargetPlayer;
			}
			set
			{
				if (_isTargetPlayer == value)
				{
					return;
				}
				_isTargetPlayer = value;
				PropertySet(this);
			}
		}

		public questCharacterAttack_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
