using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetupEntry : CVariable
	{
		private CUInt8 _priority;
		private raRef<animAnimSet> _animSet;
		private CArray<CName> _variableNames;

		[Ordinal(0)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(1)] 
		[RED("animSet")] 
		public raRef<animAnimSet> AnimSet
		{
			get => GetProperty(ref _animSet);
			set => SetProperty(ref _animSet, value);
		}

		[Ordinal(2)] 
		[RED("variableNames")] 
		public CArray<CName> VariableNames
		{
			get => GetProperty(ref _variableNames);
			set => SetProperty(ref _variableNames, value);
		}

		public animAnimSetupEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
