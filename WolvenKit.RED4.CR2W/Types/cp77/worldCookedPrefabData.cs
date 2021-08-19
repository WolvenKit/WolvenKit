using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCookedPrefabData : CResource
	{
		private CArray<raRef<CResource>> _precookedDependencies;
		private CArray<rRef<CResource>> _dependencies;

		[Ordinal(1)] 
		[RED("precookedDependencies")] 
		public CArray<raRef<CResource>> PrecookedDependencies
		{
			get => GetProperty(ref _precookedDependencies);
			set => SetProperty(ref _precookedDependencies, value);
		}

		[Ordinal(2)] 
		[RED("dependencies")] 
		public CArray<rRef<CResource>> Dependencies
		{
			get => GetProperty(ref _dependencies);
			set => SetProperty(ref _dependencies, value);
		}

		public worldCookedPrefabData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
