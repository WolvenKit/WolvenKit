using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGate : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _sideA;
		private CHandle<gameStaticTriggerAreaComponent> _sideB;
		private CHandle<gameStaticTriggerAreaComponent> _scanningArea;
		private CArray<TrespasserEntry> _trespassersDataList;

		[Ordinal(96)] 
		[RED("sideA")] 
		public CHandle<gameStaticTriggerAreaComponent> SideA
		{
			get => GetProperty(ref _sideA);
			set => SetProperty(ref _sideA, value);
		}

		[Ordinal(97)] 
		[RED("sideB")] 
		public CHandle<gameStaticTriggerAreaComponent> SideB
		{
			get => GetProperty(ref _sideB);
			set => SetProperty(ref _sideB, value);
		}

		[Ordinal(98)] 
		[RED("scanningArea")] 
		public CHandle<gameStaticTriggerAreaComponent> ScanningArea
		{
			get => GetProperty(ref _scanningArea);
			set => SetProperty(ref _scanningArea, value);
		}

		[Ordinal(99)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get => GetProperty(ref _trespassersDataList);
			set => SetProperty(ref _trespassersDataList, value);
		}

		public SecurityGate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
