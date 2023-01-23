using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSelectedCoversData : IScriptable
	{
		[Ordinal(0)] 
		[RED("selectedCovers")] 
		public CArray<CUInt64> SelectedCovers
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(1)] 
		[RED("coverRingTypes")] 
		public CArray<CEnum<gamedataAIRingType>> CoverRingTypes
		{
			get => GetPropertyValue<CArray<CEnum<gamedataAIRingType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataAIRingType>>>(value);
		}

		[Ordinal(2)] 
		[RED("coversUseLOS")] 
		public CArray<CBool> CoversUseLOS
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(3)] 
		[RED("sourcePresetName")] 
		public CArray<CName> SourcePresetName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public AIbehaviorSelectedCoversData()
		{
			SelectedCovers = new();
			CoverRingTypes = new();
			CoversUseLOS = new();
			SourcePresetName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
