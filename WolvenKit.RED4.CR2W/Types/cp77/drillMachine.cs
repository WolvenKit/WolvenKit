using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class drillMachine : gameweaponObject
	{
		private CHandle<RewireComponent> _rewireComponent;
		private wCHandle<gameObject> _player;
		private CHandle<DrillMachineScanManager> _scanManager;
		private CHandle<entIVisualComponent> _screen_postprocess;
		private CHandle<entIVisualComponent> _screen_backside;
		private CBool _isScanning;
		private CBool _isActive;
		private wCHandle<gameObject> _targetDevice;

		[Ordinal(57)] 
		[RED("rewireComponent")] 
		public CHandle<RewireComponent> RewireComponent
		{
			get => GetProperty(ref _rewireComponent);
			set => SetProperty(ref _rewireComponent, value);
		}

		[Ordinal(58)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(59)] 
		[RED("scanManager")] 
		public CHandle<DrillMachineScanManager> ScanManager
		{
			get => GetProperty(ref _scanManager);
			set => SetProperty(ref _scanManager, value);
		}

		[Ordinal(60)] 
		[RED("screen_postprocess")] 
		public CHandle<entIVisualComponent> Screen_postprocess
		{
			get => GetProperty(ref _screen_postprocess);
			set => SetProperty(ref _screen_postprocess, value);
		}

		[Ordinal(61)] 
		[RED("screen_backside")] 
		public CHandle<entIVisualComponent> Screen_backside
		{
			get => GetProperty(ref _screen_backside);
			set => SetProperty(ref _screen_backside, value);
		}

		[Ordinal(62)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetProperty(ref _isScanning);
			set => SetProperty(ref _isScanning, value);
		}

		[Ordinal(63)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(64)] 
		[RED("targetDevice")] 
		public wCHandle<gameObject> TargetDevice
		{
			get => GetProperty(ref _targetDevice);
			set => SetProperty(ref _targetDevice, value);
		}

		public drillMachine(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
