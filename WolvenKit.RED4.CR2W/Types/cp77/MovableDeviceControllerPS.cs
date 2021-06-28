using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private MovableDeviceSetup _movableDeviceSetup;
		private CHandle<DemolitionContainer> _movableDeviceSkillChecks;

		[Ordinal(103)] 
		[RED("MovableDeviceSetup")] 
		public MovableDeviceSetup MovableDeviceSetup
		{
			get => GetProperty(ref _movableDeviceSetup);
			set => SetProperty(ref _movableDeviceSetup, value);
		}

		[Ordinal(104)] 
		[RED("movableDeviceSkillChecks")] 
		public CHandle<DemolitionContainer> MovableDeviceSkillChecks
		{
			get => GetProperty(ref _movableDeviceSkillChecks);
			set => SetProperty(ref _movableDeviceSkillChecks, value);
		}

		public MovableDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
