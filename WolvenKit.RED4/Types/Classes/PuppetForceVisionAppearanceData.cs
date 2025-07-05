using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetForceVisionAppearanceData : IScriptable
	{
		[Ordinal(0)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetPropertyValue<CEnum<EFocusForcedHighlightType>>();
			set => SetPropertyValue<CEnum<EFocusForcedHighlightType>>(value);
		}

		[Ordinal(1)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get => GetPropertyValue<CEnum<EFocusOutlineType>>();
			set => SetPropertyValue<CEnum<EFocusOutlineType>>(value);
		}

		[Ordinal(2)] 
		[RED("stimRecord")] 
		public CWeakHandle<gamedataStim_Record> StimRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataStim_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStim_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetPropertyValue<CEnum<EPriority>>();
			set => SetPropertyValue<CEnum<EPriority>>(value);
		}

		[Ordinal(5)] 
		[RED("targets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> Targets
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(6)] 
		[RED("highlightedTargets")] 
		public CArray<CWeakHandle<ScriptedPuppet>> HighlightedTargets
		{
			get => GetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ScriptedPuppet>>>(value);
		}

		[Ordinal(7)] 
		[RED("investigationSlots")] 
		public CInt32 InvestigationSlots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("sourceHighlighted")] 
		public CBool SourceHighlighted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("effectName")] 
		public CString EffectName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public PuppetForceVisionAppearanceData()
		{
			HighlightType = Enums.EFocusForcedHighlightType.INVALID;
			TransitionTime = 0.500000F;
			Priority = Enums.EPriority.VeryHigh;
			Targets = new();
			HighlightedTargets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
