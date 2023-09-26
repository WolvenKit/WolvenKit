using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FxResourceMapperComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("areaEffectData")] 
		public CArray<CHandle<AreaEffectData>> AreaEffectData
		{
			get => GetPropertyValue<CArray<CHandle<AreaEffectData>>>();
			set => SetPropertyValue<CArray<CHandle<AreaEffectData>>>(value);
		}

		[Ordinal(6)] 
		[RED("investigationSlotOffsetMultiplier")] 
		public CFloat InvestigationSlotOffsetMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("areaEffectInFocusMode")] 
		public CArray<CHandle<AreaEffectTargetData>> AreaEffectInFocusMode
		{
			get => GetPropertyValue<CArray<CHandle<AreaEffectTargetData>>>();
			set => SetPropertyValue<CArray<CHandle<AreaEffectTargetData>>>(value);
		}

		[Ordinal(8)] 
		[RED("optionalAreaEffectData")] 
		public CArray<CHandle<OptionalAreaEffectData>> OptionalAreaEffectData
		{
			get => GetPropertyValue<CArray<CHandle<OptionalAreaEffectData>>>();
			set => SetPropertyValue<CArray<CHandle<OptionalAreaEffectData>>>(value);
		}

		[Ordinal(9)] 
		[RED("DEBUG_copiedDataFromEntity")] 
		public CBool DEBUG_copiedDataFromEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("DEBUG_copiedDataFromFXStruct")] 
		public CBool DEBUG_copiedDataFromFXStruct
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FxResourceMapperComponent()
		{
			AreaEffectData = new();
			InvestigationSlotOffsetMultiplier = 1.000000F;
			AreaEffectInFocusMode = new();
			OptionalAreaEffectData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
