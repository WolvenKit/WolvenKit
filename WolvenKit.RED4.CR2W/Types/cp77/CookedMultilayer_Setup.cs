using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CookedMultilayer_Setup : CResource
	{
		private CArray<rRef<Multilayer_Setup>> _dependencies;

		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<rRef<Multilayer_Setup>> Dependencies
		{
			get => GetProperty(ref _dependencies);
			set => SetProperty(ref _dependencies, value);
		}

		public CookedMultilayer_Setup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
