using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectedCoversData : IScriptable
	{
		private CArray<CUInt64> _selectedCovers;
		private CArray<CEnum<gamedataAIRingType>> _coverRingTypes;
		private CArray<CBool> _coversUseLOS;
		private CArray<CName> _sourcePresetName;

		[Ordinal(0)] 
		[RED("selectedCovers")] 
		public CArray<CUInt64> SelectedCovers
		{
			get => GetProperty(ref _selectedCovers);
			set => SetProperty(ref _selectedCovers, value);
		}

		[Ordinal(1)] 
		[RED("coverRingTypes")] 
		public CArray<CEnum<gamedataAIRingType>> CoverRingTypes
		{
			get => GetProperty(ref _coverRingTypes);
			set => SetProperty(ref _coverRingTypes, value);
		}

		[Ordinal(2)] 
		[RED("coversUseLOS")] 
		public CArray<CBool> CoversUseLOS
		{
			get => GetProperty(ref _coversUseLOS);
			set => SetProperty(ref _coversUseLOS, value);
		}

		[Ordinal(3)] 
		[RED("sourcePresetName")] 
		public CArray<CName> SourcePresetName
		{
			get => GetProperty(ref _sourcePresetName);
			set => SetProperty(ref _sourcePresetName, value);
		}

		public AIbehaviorSelectedCoversData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
