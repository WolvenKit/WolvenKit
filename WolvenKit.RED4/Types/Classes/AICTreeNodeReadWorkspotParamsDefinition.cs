using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeReadWorkspotParamsDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] 
		[RED("workspotNodeVarName")] 
		public CName WorkspotNodeVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("prevWorkspotNodeVarName")] 
		public CName PrevWorkspotNodeVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("splineNodeVarName")] 
		public CName SplineNodeVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("workspotEntryAnimVar")] 
		public CName WorkspotEntryAnimVar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("animControllerVarName")] 
		public CName AnimControllerVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("splineStartAnimVarName")] 
		public CName SplineStartAnimVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("splineStopAnimVarName")] 
		public CName SplineStopAnimVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("moveTargetVarName")] 
		public CName MoveTargetVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AICTreeNodeReadWorkspotParamsDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
