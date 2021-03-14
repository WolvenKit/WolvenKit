using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetQuickHackableMask : redEvent
	{
		private CBool _isQuickHackable;

		[Ordinal(0)] 
		[RED("isQuickHackable")] 
		public CBool IsQuickHackable
		{
			get
			{
				if (_isQuickHackable == null)
				{
					_isQuickHackable = (CBool) CR2WTypeManager.Create("Bool", "isQuickHackable", cr2w, this);
				}
				return _isQuickHackable;
			}
			set
			{
				if (_isQuickHackable == value)
				{
					return;
				}
				_isQuickHackable = value;
				PropertySet(this);
			}
		}

		public gameSetQuickHackableMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
