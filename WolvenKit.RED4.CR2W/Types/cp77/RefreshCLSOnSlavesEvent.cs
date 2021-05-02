using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshCLSOnSlavesEvent : redEvent
	{
		private CArray<CHandle<gameDeviceComponentPS>> _slaves;
		private CEnum<EDeviceStatus> _state;
		private CBool _restorePower;

		[Ordinal(0)] 
		[RED("slaves")] 
		public CArray<CHandle<gameDeviceComponentPS>> Slaves
		{
			get => GetProperty(ref _slaves);
			set => SetProperty(ref _slaves, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("restorePower")] 
		public CBool RestorePower
		{
			get => GetProperty(ref _restorePower);
			set => SetProperty(ref _restorePower, value);
		}

		public RefreshCLSOnSlavesEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
