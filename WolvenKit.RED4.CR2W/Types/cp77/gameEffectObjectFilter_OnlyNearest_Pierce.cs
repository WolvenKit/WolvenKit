using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearest_Pierce : gameEffectObjectFilter_OnlyNearest
	{
		private CBool _alwaysApplyFullWeaponCharge;

		[Ordinal(1)] 
		[RED("alwaysApplyFullWeaponCharge")] 
		public CBool AlwaysApplyFullWeaponCharge
		{
			get
			{
				if (_alwaysApplyFullWeaponCharge == null)
				{
					_alwaysApplyFullWeaponCharge = (CBool) CR2WTypeManager.Create("Bool", "alwaysApplyFullWeaponCharge", cr2w, this);
				}
				return _alwaysApplyFullWeaponCharge;
			}
			set
			{
				if (_alwaysApplyFullWeaponCharge == value)
				{
					return;
				}
				_alwaysApplyFullWeaponCharge = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectFilter_OnlyNearest_Pierce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
