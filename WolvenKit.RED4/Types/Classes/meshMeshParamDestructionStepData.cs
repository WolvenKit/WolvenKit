using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamDestructionStepData : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("offsets")] 
		public CArray<physicsDestructionHierarchyOffset> Offsets
		{
			get => GetPropertyValue<CArray<physicsDestructionHierarchyOffset>>();
			set => SetPropertyValue<CArray<physicsDestructionHierarchyOffset>>(value);
		}

		[Ordinal(1)] 
		[RED("isInstantRemovable")] 
		public CString IsInstantRemovable
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public meshMeshParamDestructionStepData()
		{
			Offsets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
