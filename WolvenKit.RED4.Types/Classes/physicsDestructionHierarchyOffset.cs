using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsDestructionHierarchyOffset : RedBaseClass
	{
		private CUInt32 _combined;

		[Ordinal(0)] 
		[RED("combined")] 
		public CUInt32 Combined
		{
			get => GetProperty(ref _combined);
			set => SetProperty(ref _combined, value);
		}
	}
}
