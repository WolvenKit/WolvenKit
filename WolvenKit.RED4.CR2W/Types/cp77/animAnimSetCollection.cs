using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetCollection : CVariable
	{
		private CArray<raRef<animAnimSet>> _animSets;
		private CArray<animOverrideAnimSetRef> _overrideAnimSets;
		private CArray<animAnimWrapperVariableDescription> _animWrapperVariables;

		[Ordinal(0)] 
		[RED("animSets")] 
		public CArray<raRef<animAnimSet>> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}

		[Ordinal(1)] 
		[RED("overrideAnimSets")] 
		public CArray<animOverrideAnimSetRef> OverrideAnimSets
		{
			get => GetProperty(ref _overrideAnimSets);
			set => SetProperty(ref _overrideAnimSets, value);
		}

		[Ordinal(2)] 
		[RED("animWrapperVariables")] 
		public CArray<animAnimWrapperVariableDescription> AnimWrapperVariables
		{
			get => GetProperty(ref _animWrapperVariables);
			set => SetProperty(ref _animWrapperVariables, value);
		}

		public animAnimSetCollection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
