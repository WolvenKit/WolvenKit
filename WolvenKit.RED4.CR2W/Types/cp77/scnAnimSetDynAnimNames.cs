using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimSetDynAnimNames : CVariable
	{
		private CStatic<CName> _animVariable;
		private CArray<CName> _animNames;

		[Ordinal(0)] 
		[RED("animVariable", 1)] 
		public CStatic<CName> AnimVariable
		{
			get => GetProperty(ref _animVariable);
			set => SetProperty(ref _animVariable, value);
		}

		[Ordinal(1)] 
		[RED("animNames")] 
		public CArray<CName> AnimNames
		{
			get => GetProperty(ref _animNames);
			set => SetProperty(ref _animNames, value);
		}

		public scnAnimSetDynAnimNames(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
