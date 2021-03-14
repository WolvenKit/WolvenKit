using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsTargetDamageEvent : gameeventsTargetHitEvent
	{
		private CFloat _damage;

		[Ordinal(12)] 
		[RED("damage")] 
		public CFloat Damage
		{
			get
			{
				if (_damage == null)
				{
					_damage = (CFloat) CR2WTypeManager.Create("Float", "damage", cr2w, this);
				}
				return _damage;
			}
			set
			{
				if (_damage == value)
				{
					return;
				}
				_damage = value;
				PropertySet(this);
			}
		}

		public gameeventsTargetDamageEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
