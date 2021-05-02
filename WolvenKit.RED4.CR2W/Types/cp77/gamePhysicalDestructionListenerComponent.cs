using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhysicalDestructionListenerComponent : entIComponent
	{
		private CName _physicalDestructionComponentName;
		private CArray<CFloat> _thresholdLevels;

		[Ordinal(3)] 
		[RED("physicalDestructionComponentName")] 
		public CName PhysicalDestructionComponentName
		{
			get => GetProperty(ref _physicalDestructionComponentName);
			set => SetProperty(ref _physicalDestructionComponentName, value);
		}

		[Ordinal(4)] 
		[RED("thresholdLevels")] 
		public CArray<CFloat> ThresholdLevels
		{
			get => GetProperty(ref _thresholdLevels);
			set => SetProperty(ref _thresholdLevels, value);
		}

		public gamePhysicalDestructionListenerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
