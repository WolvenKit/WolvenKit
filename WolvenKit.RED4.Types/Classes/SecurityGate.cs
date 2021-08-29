using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGate : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _sideA;
		private CHandle<gameStaticTriggerAreaComponent> _sideB;
		private CHandle<gameStaticTriggerAreaComponent> _scanningArea;
		private CArray<TrespasserEntry> _trespassersDataList;

		[Ordinal(97)] 
		[RED("sideA")] 
		public CHandle<gameStaticTriggerAreaComponent> SideA
		{
			get => GetProperty(ref _sideA);
			set => SetProperty(ref _sideA, value);
		}

		[Ordinal(98)] 
		[RED("sideB")] 
		public CHandle<gameStaticTriggerAreaComponent> SideB
		{
			get => GetProperty(ref _sideB);
			set => SetProperty(ref _sideB, value);
		}

		[Ordinal(99)] 
		[RED("scanningArea")] 
		public CHandle<gameStaticTriggerAreaComponent> ScanningArea
		{
			get => GetProperty(ref _scanningArea);
			set => SetProperty(ref _scanningArea, value);
		}

		[Ordinal(100)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get => GetProperty(ref _trespassersDataList);
			set => SetProperty(ref _trespassersDataList, value);
		}
	}
}
