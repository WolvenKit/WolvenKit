using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDebug_MeshComponent : entMeshComponent
	{
		private CString _filterName;

		[Ordinal(24)] 
		[RED("filterName")] 
		public CString FilterName
		{
			get => GetProperty(ref _filterName);
			set => SetProperty(ref _filterName, value);
		}

		public entDebug_MeshComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
