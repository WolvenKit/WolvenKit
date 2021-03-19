using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetScanningBlockedEvent : redEvent
	{
		private CBool _isBlocked;

		[Ordinal(0)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetProperty(ref _isBlocked);
			set => SetProperty(ref _isBlocked, value);
		}

		public gameSetScanningBlockedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
