using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClueRecordData : CVariable
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

		public ClueRecordData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
