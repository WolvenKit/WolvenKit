using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAppearanceStatusEvent : redEvent
	{
		private CEnum<entAppearanceStatus> _status;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<entAppearanceStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		public entAppearanceStatusEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
