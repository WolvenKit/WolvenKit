using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterPostionEvent : BlackBoardRequestEvent
	{
		private CBool _start;

		[Ordinal(3)] 
		[RED("start")] 
		public CBool Start
		{
			get
			{
				if (_start == null)
				{
					_start = (CBool) CR2WTypeManager.Create("Bool", "start", cr2w, this);
				}
				return _start;
			}
			set
			{
				if (_start == value)
				{
					return;
				}
				_start = value;
				PropertySet(this);
			}
		}

		public RegisterPostionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
