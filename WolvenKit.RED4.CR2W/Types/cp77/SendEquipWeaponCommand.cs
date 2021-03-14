using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendEquipWeaponCommand : AIbehaviortaskScript
	{
		private CBool _secondary;

		[Ordinal(0)] 
		[RED("secondary")] 
		public CBool Secondary
		{
			get
			{
				if (_secondary == null)
				{
					_secondary = (CBool) CR2WTypeManager.Create("Bool", "secondary", cr2w, this);
				}
				return _secondary;
			}
			set
			{
				if (_secondary == value)
				{
					return;
				}
				_secondary = value;
				PropertySet(this);
			}
		}

		public SendEquipWeaponCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
