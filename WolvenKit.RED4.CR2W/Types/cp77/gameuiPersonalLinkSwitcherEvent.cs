using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPersonalLinkSwitcherEvent : redEvent
	{
		private CBool _isAdvanced;

		[Ordinal(0)] 
		[RED("isAdvanced")] 
		public CBool IsAdvanced
		{
			get
			{
				if (_isAdvanced == null)
				{
					_isAdvanced = (CBool) CR2WTypeManager.Create("Bool", "isAdvanced", cr2w, this);
				}
				return _isAdvanced;
			}
			set
			{
				if (_isAdvanced == value)
				{
					return;
				}
				_isAdvanced = value;
				PropertySet(this);
			}
		}

		public gameuiPersonalLinkSwitcherEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
