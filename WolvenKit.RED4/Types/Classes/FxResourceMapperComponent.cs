using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FxResourceMapperComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("areaEffectsData")] 
		public CArray<SAreaEffectData> AreaEffectsData
		{
			get => GetPropertyValue<CArray<SAreaEffectData>>();
			set => SetPropertyValue<CArray<SAreaEffectData>>(value);
		}

		[Ordinal(6)] 
		[RED("areaEffectsInFocusMode")] 
		public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode
		{
			get => GetPropertyValue<CArray<SAreaEffectTargetData>>();
			set => SetPropertyValue<CArray<SAreaEffectTargetData>>(value);
		}

		[Ordinal(7)] 
		[RED("areaEffectData")] 
		public CArray<CHandle<AreaEffectData>> AreaEffectData
		{
			get => GetPropertyValue<CArray<CHandle<AreaEffectData>>>();
			set => SetPropertyValue<CArray<CHandle<AreaEffectData>>>(value);
		}

		[Ordinal(8)] 
		[RED("investigationSlotOffsetMultiplier")] 
		public CFloat InvestigationSlotOffsetMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("areaEffectInFocusMode")] 
		public CArray<CHandle<AreaEffectTargetData>> AreaEffectInFocusMode
		{
			get => GetPropertyValue<CArray<CHandle<AreaEffectTargetData>>>();
			set => SetPropertyValue<CArray<CHandle<AreaEffectTargetData>>>(value);
		}

		[Ordinal(10)] 
		[RED("DEBUG_copiedDataFromEntity")] 
		public CBool DEBUG_copiedDataFromEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("DEBUG_copiedDataFromFXStruct")] 
		public CBool DEBUG_copiedDataFromFXStruct
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FxResourceMapperComponent()
		{
			AreaEffectsData = new();
			AreaEffectsInFocusMode = new();
			AreaEffectData = new();
			InvestigationSlotOffsetMultiplier = 1.000000F;
			AreaEffectInFocusMode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
