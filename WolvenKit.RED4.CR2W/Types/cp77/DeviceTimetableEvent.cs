using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceTimetableEvent : redEvent
	{
		private CEnum<EDeviceStatus> _state;
		private entEntityID _requesterID;
		private CBool _restorePower;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		[Ordinal(2)] 
		[RED("restorePower")] 
		public CBool RestorePower
		{
			get => GetProperty(ref _restorePower);
			set => SetProperty(ref _restorePower, value);
		}

		public DeviceTimetableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
