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
			get => GetProperty(ref _isAdvanced);
			set => SetProperty(ref _isAdvanced, value);
		}

		public gameuiPersonalLinkSwitcherEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
