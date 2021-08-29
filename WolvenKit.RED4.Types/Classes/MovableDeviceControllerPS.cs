using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private MovableDeviceSetup _movableDeviceSetup;
		private CHandle<DemolitionContainer> _movableDeviceSkillChecks;

		[Ordinal(104)] 
		[RED("MovableDeviceSetup")] 
		public MovableDeviceSetup MovableDeviceSetup
		{
			get => GetProperty(ref _movableDeviceSetup);
			set => SetProperty(ref _movableDeviceSetup, value);
		}

		[Ordinal(105)] 
		[RED("movableDeviceSkillChecks")] 
		public CHandle<DemolitionContainer> MovableDeviceSkillChecks
		{
			get => GetProperty(ref _movableDeviceSkillChecks);
			set => SetProperty(ref _movableDeviceSkillChecks, value);
		}
	}
}
