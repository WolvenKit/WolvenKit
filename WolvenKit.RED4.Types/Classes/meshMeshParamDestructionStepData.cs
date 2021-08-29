using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamDestructionStepData : meshMeshParameter
	{
		private CArray<physicsDestructionHierarchyOffset> _offsets;
		private CString _isInstantRemovable;

		[Ordinal(0)] 
		[RED("offsets")] 
		public CArray<physicsDestructionHierarchyOffset> Offsets
		{
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}

		[Ordinal(1)] 
		[RED("isInstantRemovable")] 
		public CString IsInstantRemovable
		{
			get => GetProperty(ref _isInstantRemovable);
			set => SetProperty(ref _isInstantRemovable, value);
		}
	}
}
