using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectPreAction_PreAttack : gameEffectPreAction_Scripted
	{
		private CBool _withFriendlyFire;
		private CBool _withSelfDamage;

		[Ordinal(0)] 
		[RED("withFriendlyFire")] 
		public CBool WithFriendlyFire
		{
			get
			{
				if (_withFriendlyFire == null)
				{
					_withFriendlyFire = (CBool) CR2WTypeManager.Create("Bool", "withFriendlyFire", cr2w, this);
				}
				return _withFriendlyFire;
			}
			set
			{
				if (_withFriendlyFire == value)
				{
					return;
				}
				_withFriendlyFire = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("withSelfDamage")] 
		public CBool WithSelfDamage
		{
			get
			{
				if (_withSelfDamage == null)
				{
					_withSelfDamage = (CBool) CR2WTypeManager.Create("Bool", "withSelfDamage", cr2w, this);
				}
				return _withSelfDamage;
			}
			set
			{
				if (_withSelfDamage == value)
				{
					return;
				}
				_withSelfDamage = value;
				PropertySet(this);
			}
		}

		public EffectPreAction_PreAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
