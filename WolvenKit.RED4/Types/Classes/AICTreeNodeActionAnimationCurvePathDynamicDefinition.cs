using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeActionAnimationCurvePathDynamicDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] 
		[RED("targetSplineVarName")] 
		public CName TargetSplineVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("controlerVarName")] 
		public CName ControlerVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("startAnimVarName")] 
		public CName StartAnimVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("stopAnimVarName")] 
		public CName StopAnimVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("startSnapToTerrain")] 
		public CBool StartSnapToTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("mainSnapToTerrain")] 
		public CBool MainSnapToTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("stopSnapToTerrain")] 
		public CBool StopSnapToTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CFloat StartSnapToTerrainBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CFloat StopSnapToTerrainBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AICTreeNodeActionAnimationCurvePathDynamicDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
