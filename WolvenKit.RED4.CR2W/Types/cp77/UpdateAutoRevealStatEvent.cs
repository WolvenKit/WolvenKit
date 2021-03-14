using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateAutoRevealStatEvent : redEvent
	{
		private CBool _hasAutoReveal;

		[Ordinal(0)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get
			{
				if (_hasAutoReveal == null)
				{
					_hasAutoReveal = (CBool) CR2WTypeManager.Create("Bool", "hasAutoReveal", cr2w, this);
				}
				return _hasAutoReveal;
			}
			set
			{
				if (_hasAutoReveal == value)
				{
					return;
				}
				_hasAutoReveal = value;
				PropertySet(this);
			}
		}

		public UpdateAutoRevealStatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
