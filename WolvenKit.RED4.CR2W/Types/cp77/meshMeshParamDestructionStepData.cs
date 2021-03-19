using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionStepData : meshMeshParameter
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

		public meshMeshParamDestructionStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
