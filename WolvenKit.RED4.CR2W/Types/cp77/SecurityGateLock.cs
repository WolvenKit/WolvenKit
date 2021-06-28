using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLock : InteractiveDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _enteringArea;
		private CHandle<gameStaticTriggerAreaComponent> _centeredArea;
		private CHandle<gameStaticTriggerAreaComponent> _leavingArea;

		[Ordinal(96)] 
		[RED("enteringArea")] 
		public CHandle<gameStaticTriggerAreaComponent> EnteringArea
		{
			get => GetProperty(ref _enteringArea);
			set => SetProperty(ref _enteringArea, value);
		}

		[Ordinal(97)] 
		[RED("centeredArea")] 
		public CHandle<gameStaticTriggerAreaComponent> CenteredArea
		{
			get => GetProperty(ref _centeredArea);
			set => SetProperty(ref _centeredArea, value);
		}

		[Ordinal(98)] 
		[RED("leavingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> LeavingArea
		{
			get => GetProperty(ref _leavingArea);
			set => SetProperty(ref _leavingArea, value);
		}

		public SecurityGateLock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
