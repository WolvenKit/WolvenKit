using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimSetAnimNames : CVariable
	{
		private CArray<CName> _animationNames;

		[Ordinal(0)] 
		[RED("animationNames")] 
		public CArray<CName> AnimationNames
		{
			get => GetProperty(ref _animationNames);
			set => SetProperty(ref _animationNames, value);
		}

		public scnAnimSetAnimNames(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
