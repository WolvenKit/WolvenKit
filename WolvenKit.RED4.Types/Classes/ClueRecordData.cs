using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClueRecordData : RedBaseClass
	{
		private TweakDBID _clueRecord;
		private CFloat _percentage;
		private CArray<SFactOperationData> _facts;
		private CBool _wasInspected;

		[Ordinal(0)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get => GetProperty(ref _clueRecord);
			set => SetProperty(ref _clueRecord, value);
		}

		[Ordinal(1)] 
		[RED("percentage")] 
		public CFloat Percentage
		{
			get => GetProperty(ref _percentage);
			set => SetProperty(ref _percentage, value);
		}

		[Ordinal(2)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetProperty(ref _facts);
			set => SetProperty(ref _facts, value);
		}

		[Ordinal(3)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetProperty(ref _wasInspected);
			set => SetProperty(ref _wasInspected, value);
		}
	}
}
