using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionTransition : CVariable
	{
		private CName _targetState;
		private CArray<inkCompositionInterpolator> _interpolators;

		[Ordinal(0)] 
		[RED("targetState")] 
		public CName TargetState
		{
			get => GetProperty(ref _targetState);
			set => SetProperty(ref _targetState, value);
		}

		[Ordinal(1)] 
		[RED("interpolators")] 
		public CArray<inkCompositionInterpolator> Interpolators
		{
			get => GetProperty(ref _interpolators);
			set => SetProperty(ref _interpolators, value);
		}

		public inkCompositionTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
