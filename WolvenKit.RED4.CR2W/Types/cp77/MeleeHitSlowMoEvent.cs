using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeHitSlowMoEvent : redEvent
	{
		private CBool _isStrongAttack;

		[Ordinal(0)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get
			{
				if (_isStrongAttack == null)
				{
					_isStrongAttack = (CBool) CR2WTypeManager.Create("Bool", "isStrongAttack", cr2w, this);
				}
				return _isStrongAttack;
			}
			set
			{
				if (_isStrongAttack == value)
				{
					return;
				}
				_isStrongAttack = value;
				PropertySet(this);
			}
		}

		public MeleeHitSlowMoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
