using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanPlayerHijackMountedNpcPrereq : gameIScriptablePrereq
	{
		private CName _slotName;
		private CBool _isCheckInverted;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("isCheckInverted")] 
		public CBool IsCheckInverted
		{
			get => GetProperty(ref _isCheckInverted);
			set => SetProperty(ref _isCheckInverted, value);
		}

		public CanPlayerHijackMountedNpcPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
