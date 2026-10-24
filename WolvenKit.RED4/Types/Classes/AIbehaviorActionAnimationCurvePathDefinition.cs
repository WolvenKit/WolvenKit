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
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };
			NodeReference = new AIArgumentMapping { Type = Enums.AIArgumentType.NodeRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "NodeRef" };
			ControllersSetupName = new AIArgumentMapping { Type = Enums.AIArgumentType.CName, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "CName" };
			UseStart = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			UseStop = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			BlendTime = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			GlobalInBlendTime = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			GlobalOutBlendTime = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			TurnCharacterToMatchVelocity = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			CustomStartAnimationName = new AIArgumentMapping { Type = Enums.AIArgumentType.CName, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "CName" };
			CustomMainAnimationName = new AIArgumentMapping { Type = Enums.AIArgumentType.CName, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "CName" };
			CustomStopAnimationName = new AIArgumentMapping { Type = Enums.AIArgumentType.CName, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "CName" };
			StartSnapToTerrain = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			MainSnapToTerrain = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			StopSnapToTerrain = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			StartSnapToTerrainBlendTime = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			StopSnapToTerrainBlendTime = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
