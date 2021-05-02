using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamImportedSnapPoint : meshMeshParameter
	{
		private CArray<CHandle<meshMeshImportedSnapPoint>> _snapFeatureData;

		[Ordinal(0)] 
		[RED("snapFeatureData")] 
		public CArray<CHandle<meshMeshImportedSnapPoint>> SnapFeatureData
		{
			get => GetProperty(ref _snapFeatureData);
			set => SetProperty(ref _snapFeatureData, value);
		}

		public meshMeshParamImportedSnapPoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
