using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStaticTriggerAreaComponent : gameStaticAreaShapeComponent
	{
		private CUInt32 _includeMask;
		private CUInt32 _excludeMask;

		[Ordinal(8)] 
		[RED("includeMask")] 
		public CUInt32 IncludeMask
		{
			get => GetProperty(ref _includeMask);
			set => SetProperty(ref _includeMask, value);
		}

		[Ordinal(9)] 
		[RED("excludeMask")] 
		public CUInt32 ExcludeMask
		{
			get => GetProperty(ref _excludeMask);
			set => SetProperty(ref _excludeMask, value);
		}
	}
}
