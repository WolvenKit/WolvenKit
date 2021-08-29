using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPhysicalDestructionEvent : redEvent
	{
		private CName _componentName;
		private CUInt8 _levelOfDestruction;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("levelOfDestruction")] 
		public CUInt8 LevelOfDestruction
		{
			get => GetProperty(ref _levelOfDestruction);
			set => SetProperty(ref _levelOfDestruction, value);
		}
	}
}
