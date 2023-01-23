using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsDestructionHierarchyOffset : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("combined")] 
		public CUInt32 Combined
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public physicsDestructionHierarchyOffset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
