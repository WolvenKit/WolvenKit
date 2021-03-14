using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetIgnoreAutoDoorCloseEvent : redEvent
	{
		private CBool _set;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get
			{
				if (_set == null)
				{
					_set = (CBool) CR2WTypeManager.Create("Bool", "set", cr2w, this);
				}
				return _set;
			}
			set
			{
				if (_set == value)
				{
					return;
				}
				_set = value;
				PropertySet(this);
			}
		}

		public SetIgnoreAutoDoorCloseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
