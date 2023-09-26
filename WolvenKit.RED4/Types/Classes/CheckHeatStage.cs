using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckHeatStage : PreventionConditionAbstract
	{
		[Ordinal(0)] 
		[RED("heatStageToCompare")] 
		public CHandle<AIArgumentMapping> HeatStageToCompare
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("heatStageToCompareAsInteger")] 
		public CInt32 HeatStageToCompareAsInteger
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("currentHeatStageAsInteger")] 
		public CInt32 CurrentHeatStageAsInteger
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("system")] 
		public CHandle<PreventionSystem> System
		{
			get => GetPropertyValue<CHandle<PreventionSystem>>();
			set => SetPropertyValue<CHandle<PreventionSystem>>(value);
		}

		public CheckHeatStage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
