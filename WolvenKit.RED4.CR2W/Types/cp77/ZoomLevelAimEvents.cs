using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoomLevelAimEvents : ZoomEventsTransition
	{
		private CBool _isAmingWithWeapon;

		[Ordinal(0)] 
		[RED("isAmingWithWeapon")] 
		public CBool IsAmingWithWeapon
		{
			get
			{
				if (_isAmingWithWeapon == null)
				{
					_isAmingWithWeapon = (CBool) CR2WTypeManager.Create("Bool", "isAmingWithWeapon", cr2w, this);
				}
				return _isAmingWithWeapon;
			}
			set
			{
				if (_isAmingWithWeapon == value)
				{
					return;
				}
				_isAmingWithWeapon = value;
				PropertySet(this);
			}
		}

		public ZoomLevelAimEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
