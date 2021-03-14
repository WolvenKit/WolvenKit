using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerUnauthorized : ActionBool
	{
		private CBool _isLiftDoor;

		[Ordinal(25)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get
			{
				if (_isLiftDoor == null)
				{
					_isLiftDoor = (CBool) CR2WTypeManager.Create("Bool", "isLiftDoor", cr2w, this);
				}
				return _isLiftDoor;
			}
			set
			{
				if (_isLiftDoor == value)
				{
					return;
				}
				_isLiftDoor = value;
				PropertySet(this);
			}
		}

		public PlayerUnauthorized(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
