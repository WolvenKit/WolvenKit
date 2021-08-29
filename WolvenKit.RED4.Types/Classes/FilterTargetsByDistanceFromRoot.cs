using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FilterTargetsByDistanceFromRoot : gameEffectObjectSingleFilter_Scripted
	{
		private CFloat _rootOffset_Z;
		private CFloat _tollerance;

		[Ordinal(0)] 
		[RED("rootOffset_Z")] 
		public CFloat RootOffset_Z
		{
			get => GetProperty(ref _rootOffset_Z);
			set => SetProperty(ref _rootOffset_Z, value);
		}

		[Ordinal(1)] 
		[RED("tollerance")] 
		public CFloat Tollerance
		{
			get => GetProperty(ref _tollerance);
			set => SetProperty(ref _tollerance, value);
		}
	}
}
