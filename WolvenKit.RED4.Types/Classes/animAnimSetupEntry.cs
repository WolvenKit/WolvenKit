using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimSetupEntry : RedBaseClass
	{
		private CUInt8 _priority;
		private CResourceAsyncReference<animAnimSet> _animSet;
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
		public CResourceAsyncReference<animAnimSet> AnimSet
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

		public animAnimSetupEntry()
		{
			_priority = 128;
		}
	}
}
