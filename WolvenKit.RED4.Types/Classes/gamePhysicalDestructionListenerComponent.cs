using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhysicalDestructionListenerComponent : entIComponent
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
	}
}
