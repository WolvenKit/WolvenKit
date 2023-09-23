using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class drillMachine : gameweaponObject
	{
		[Ordinal(66)] 
		[RED("rewireComponent")] 
		public CHandle<RewireComponent> RewireComponent
		{
			get => GetPropertyValue<CHandle<RewireComponent>>();
			set => SetPropertyValue<CHandle<RewireComponent>>(value);
		}

		[Ordinal(67)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(68)] 
		[RED("scanManager")] 
		public CHandle<DrillMachineScanManager> ScanManager
		{
			get => GetPropertyValue<CHandle<DrillMachineScanManager>>();
			set => SetPropertyValue<CHandle<DrillMachineScanManager>>(value);
		}

		[Ordinal(69)] 
		[RED("screen_postprocess")] 
		public CHandle<entIVisualComponent> Screen_postprocess
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		[Ordinal(70)] 
		[RED("screen_backside")] 
		public CHandle<entIVisualComponent> Screen_backside
		{
			get => GetPropertyValue<CHandle<entIVisualComponent>>();
			set => SetPropertyValue<CHandle<entIVisualComponent>>(value);
		}

		[Ordinal(71)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("targetDevice")] 
		public CWeakHandle<gameObject> TargetDevice
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public drillMachine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
