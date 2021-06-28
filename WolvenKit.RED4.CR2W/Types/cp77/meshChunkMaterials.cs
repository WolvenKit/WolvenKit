using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkMaterials : CVariable
	{
		private CArray<CName> _materialNames;

		[Ordinal(0)] 
		[RED("materialNames")] 
		public CArray<CName> MaterialNames
		{
			get => GetProperty(ref _materialNames);
			set => SetProperty(ref _materialNames, value);
		}

		public meshChunkMaterials(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
