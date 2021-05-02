using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionBonds : meshMeshParameter
	{
		private CArray<meshDestructionBond> _bonds;

		[Ordinal(0)] 
		[RED("bonds")] 
		public CArray<meshDestructionBond> Bonds
		{
			get => GetProperty(ref _bonds);
			set => SetProperty(ref _bonds, value);
		}

		public meshMeshParamDestructionBonds(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
