using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivateCoverEvents : CoverActionEventsTransition
	{
		private CBool _usingCover;

		[Ordinal(0)] 
		[RED("usingCover")] 
		public CBool UsingCover
		{
			get
			{
				if (_usingCover == null)
				{
					_usingCover = (CBool) CR2WTypeManager.Create("Bool", "usingCover", cr2w, this);
				}
				return _usingCover;
			}
			set
			{
				if (_usingCover == value)
				{
					return;
				}
				_usingCover = value;
				PropertySet(this);
			}
		}

		public ActivateCoverEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
