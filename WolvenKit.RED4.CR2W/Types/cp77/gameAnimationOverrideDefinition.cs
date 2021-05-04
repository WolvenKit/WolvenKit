using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimationOverrideDefinition : CVariable
	{
		private raRef<animAnimSet> _animset;
		private CArray<CName> _variables;

		[Ordinal(0)] 
		[RED("animset")] 
		public raRef<animAnimSet> Animset
		{
			get => GetProperty(ref _animset);
			set => SetProperty(ref _animset, value);
		}

		[Ordinal(1)] 
		[RED("variables")] 
		public CArray<CName> Variables
		{
			get => GetProperty(ref _variables);
			set => SetProperty(ref _variables, value);
		}

		public gameAnimationOverrideDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
