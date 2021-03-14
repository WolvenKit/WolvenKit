using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetCloseItself : redEvent
	{
		private CBool _automaticallyClosesItself;

		[Ordinal(0)] 
		[RED("automaticallyClosesItself")] 
		public CBool AutomaticallyClosesItself
		{
			get
			{
				if (_automaticallyClosesItself == null)
				{
					_automaticallyClosesItself = (CBool) CR2WTypeManager.Create("Bool", "automaticallyClosesItself", cr2w, this);
				}
				return _automaticallyClosesItself;
			}
			set
			{
				if (_automaticallyClosesItself == value)
				{
					return;
				}
				_automaticallyClosesItself = value;
				PropertySet(this);
			}
		}

		public SetCloseItself(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
