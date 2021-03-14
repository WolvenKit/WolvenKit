using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminaTransition : DefaultTransition
	{
		private CBool _staminaChangeToggle;

		[Ordinal(0)] 
		[RED("staminaChangeToggle")] 
		public CBool StaminaChangeToggle
		{
			get
			{
				if (_staminaChangeToggle == null)
				{
					_staminaChangeToggle = (CBool) CR2WTypeManager.Create("Bool", "staminaChangeToggle", cr2w, this);
				}
				return _staminaChangeToggle;
			}
			set
			{
				if (_staminaChangeToggle == value)
				{
					return;
				}
				_staminaChangeToggle = value;
				PropertySet(this);
			}
		}

		public StaminaTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
