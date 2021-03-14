using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightConnectionComponentEvent : redEvent
	{
		private CBool _isHighlightON;

		[Ordinal(0)] 
		[RED("IsHighlightON")] 
		public CBool IsHighlightON
		{
			get
			{
				if (_isHighlightON == null)
				{
					_isHighlightON = (CBool) CR2WTypeManager.Create("Bool", "IsHighlightON", cr2w, this);
				}
				return _isHighlightON;
			}
			set
			{
				if (_isHighlightON == value)
				{
					return;
				}
				_isHighlightON = value;
				PropertySet(this);
			}
		}

		public HighlightConnectionComponentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
