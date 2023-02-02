using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionAnimationCurvePathDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("nodeReference")] 
		public CHandle<AIArgumentMapping> NodeReference
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("controllersSetupName")] 
		public CHandle<AIArgumentMapping> ControllersSetupName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("useStart")] 
		public CHandle<AIArgumentMapping> UseStart
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("useStop")] 
		public CHandle<AIArgumentMapping> UseStop
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("blendTime")] 
		public CHandle<AIArgumentMapping> BlendTime
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("globalInBlendTime")] 
		public CHandle<AIArgumentMapping> GlobalInBlendTime
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("globalOutBlendTime")] 
		public CHandle<AIArgumentMapping> GlobalOutBlendTime
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CHandle<AIArgumentMapping> TurnCharacterToMatchVelocity
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("customStartAnimationName")] 
		public CHandle<AIArgumentMapping> CustomStartAnimationName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("customMainAnimationName")] 
		public CHandle<AIArgumentMapping> CustomMainAnimationName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(11)] 
		[RED("customStopAnimationName")] 
		public CHandle<AIArgumentMapping> CustomStopAnimationName
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(12)] 
		[RED("startSnapToTerrain")] 
		public CHandle<AIArgumentMapping> StartSnapToTerrain
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(13)] 
		[RED("mainSnapToTerrain")] 
		public CHandle<AIArgumentMapping> MainSnapToTerrain
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(14)] 
		[RED("stopSnapToTerrain")] 
		public CHandle<AIArgumentMapping> StopSnapToTerrain
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(15)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CHandle<AIArgumentMapping> StartSnapToTerrainBlendTime
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(16)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CHandle<AIArgumentMapping> StopSnapToTerrainBlendTime
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionAnimationCurvePathDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
