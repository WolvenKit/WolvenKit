using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeActionAnimationCurvePathDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] 
		[RED("nodeReference")] 
		public LibTreeDefNodeRef NodeReference
		{
			get => GetPropertyValue<LibTreeDefNodeRef>();
			set => SetPropertyValue<LibTreeDefNodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("controllersSetupName")] 
		public LibTreeDefCName ControllersSetupName
		{
			get => GetPropertyValue<LibTreeDefCName>();
			set => SetPropertyValue<LibTreeDefCName>(value);
		}

		[Ordinal(3)] 
		[RED("useStart")] 
		public LibTreeDefBool UseStart
		{
			get => GetPropertyValue<LibTreeDefBool>();
			set => SetPropertyValue<LibTreeDefBool>(value);
		}

		[Ordinal(4)] 
		[RED("useStop")] 
		public LibTreeDefBool UseStop
		{
			get => GetPropertyValue<LibTreeDefBool>();
			set => SetPropertyValue<LibTreeDefBool>(value);
		}

		[Ordinal(5)] 
		[RED("blendTime")] 
		public LibTreeDefFloat BlendTime
		{
			get => GetPropertyValue<LibTreeDefFloat>();
			set => SetPropertyValue<LibTreeDefFloat>(value);
		}

		[Ordinal(6)] 
		[RED("globalInBlendTime")] 
		public LibTreeDefFloat GlobalInBlendTime
		{
			get => GetPropertyValue<LibTreeDefFloat>();
			set => SetPropertyValue<LibTreeDefFloat>(value);
		}

		[Ordinal(7)] 
		[RED("globalOutBlendTime")] 
		public LibTreeDefFloat GlobalOutBlendTime
		{
			get => GetPropertyValue<LibTreeDefFloat>();
			set => SetPropertyValue<LibTreeDefFloat>(value);
		}

		[Ordinal(8)] 
		[RED("turnCharacterToMatchVelocity")] 
		public LibTreeDefBool TurnCharacterToMatchVelocity
		{
			get => GetPropertyValue<LibTreeDefBool>();
			set => SetPropertyValue<LibTreeDefBool>(value);
		}

		[Ordinal(9)] 
		[RED("customStartAnimationName")] 
		public LibTreeDefCName CustomStartAnimationName
		{
			get => GetPropertyValue<LibTreeDefCName>();
			set => SetPropertyValue<LibTreeDefCName>(value);
		}

		[Ordinal(10)] 
		[RED("customMainAnimationName")] 
		public LibTreeDefCName CustomMainAnimationName
		{
			get => GetPropertyValue<LibTreeDefCName>();
			set => SetPropertyValue<LibTreeDefCName>(value);
		}

		[Ordinal(11)] 
		[RED("customStopAnimationName")] 
		public LibTreeDefCName CustomStopAnimationName
		{
			get => GetPropertyValue<LibTreeDefCName>();
			set => SetPropertyValue<LibTreeDefCName>(value);
		}

		[Ordinal(12)] 
		[RED("startSnapToTerrain")] 
		public LibTreeDefBool StartSnapToTerrain
		{
			get => GetPropertyValue<LibTreeDefBool>();
			set => SetPropertyValue<LibTreeDefBool>(value);
		}

		[Ordinal(13)] 
		[RED("mainSnapToTerrain")] 
		public LibTreeDefBool MainSnapToTerrain
		{
			get => GetPropertyValue<LibTreeDefBool>();
			set => SetPropertyValue<LibTreeDefBool>(value);
		}

		[Ordinal(14)] 
		[RED("stopSnapToTerrain")] 
		public LibTreeDefBool StopSnapToTerrain
		{
			get => GetPropertyValue<LibTreeDefBool>();
			set => SetPropertyValue<LibTreeDefBool>(value);
		}

		[Ordinal(15)] 
		[RED("startSnapToTerrainBlendTime")] 
		public LibTreeDefFloat StartSnapToTerrainBlendTime
		{
			get => GetPropertyValue<LibTreeDefFloat>();
			set => SetPropertyValue<LibTreeDefFloat>(value);
		}

		[Ordinal(16)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public LibTreeDefFloat StopSnapToTerrainBlendTime
		{
			get => GetPropertyValue<LibTreeDefFloat>();
			set => SetPropertyValue<LibTreeDefFloat>(value);
		}

		public AICTreeNodeActionAnimationCurvePathDefinition()
		{
			NodeReference = new LibTreeDefNodeRef();
			ControllersSetupName = new LibTreeDefCName();
			UseStart = new LibTreeDefBool();
			UseStop = new LibTreeDefBool();
			BlendTime = new LibTreeDefFloat();
			GlobalInBlendTime = new LibTreeDefFloat();
			GlobalOutBlendTime = new LibTreeDefFloat();
			TurnCharacterToMatchVelocity = new LibTreeDefBool();
			CustomStartAnimationName = new LibTreeDefCName();
			CustomMainAnimationName = new LibTreeDefCName();
			CustomStopAnimationName = new LibTreeDefCName();
			StartSnapToTerrain = new LibTreeDefBool();
			MainSnapToTerrain = new LibTreeDefBool();
			StopSnapToTerrain = new LibTreeDefBool();
			StartSnapToTerrainBlendTime = new LibTreeDefFloat();
			StopSnapToTerrainBlendTime = new LibTreeDefFloat();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
