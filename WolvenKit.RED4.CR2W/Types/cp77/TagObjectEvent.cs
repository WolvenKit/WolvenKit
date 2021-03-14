using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TagObjectEvent : redEvent
	{
		private CBool _isTagged;

		[Ordinal(0)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get
			{
				if (_isTagged == null)
				{
					_isTagged = (CBool) CR2WTypeManager.Create("Bool", "isTagged", cr2w, this);
				}
				return _isTagged;
			}
			set
			{
				if (_isTagged == value)
				{
					return;
				}
				_isTagged = value;
				PropertySet(this);
			}
		}

		public TagObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
