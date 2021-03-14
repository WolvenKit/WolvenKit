using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddStatusEffectToAttackEffector : ModifyAttackEffector
	{
		private CBool _isRandom;
		private CFloat _applicationChance;
		private SHitStatusEffect _statusEffect;
		private CFloat _stacks;

		[Ordinal(0)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get
			{
				if (_isRandom == null)
				{
					_isRandom = (CBool) CR2WTypeManager.Create("Bool", "isRandom", cr2w, this);
				}
				return _isRandom;
			}
			set
			{
				if (_isRandom == value)
				{
					return;
				}
				_isRandom = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get
			{
				if (_applicationChance == null)
				{
					_applicationChance = (CFloat) CR2WTypeManager.Create("Float", "applicationChance", cr2w, this);
				}
				return _applicationChance;
			}
			set
			{
				if (_applicationChance == value)
				{
					return;
				}
				_applicationChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statusEffect")] 
		public SHitStatusEffect StatusEffect
		{
			get
			{
				if (_statusEffect == null)
				{
					_statusEffect = (SHitStatusEffect) CR2WTypeManager.Create("SHitStatusEffect", "statusEffect", cr2w, this);
				}
				return _statusEffect;
			}
			set
			{
				if (_statusEffect == value)
				{
					return;
				}
				_statusEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stacks")] 
		public CFloat Stacks
		{
			get
			{
				if (_stacks == null)
				{
					_stacks = (CFloat) CR2WTypeManager.Create("Float", "stacks", cr2w, this);
				}
				return _stacks;
			}
			set
			{
				if (_stacks == value)
				{
					return;
				}
				_stacks = value;
				PropertySet(this);
			}
		}

		public AddStatusEffectToAttackEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
