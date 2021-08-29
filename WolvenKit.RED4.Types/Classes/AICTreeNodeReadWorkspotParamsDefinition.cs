using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeReadWorkspotParamsDefinition : AICTreeNodeDecoratorDefinition
	{
		private CName _workspotNodeVarName;
		private CName _prevWorkspotNodeVarName;
		private CName _splineNodeVarName;
		private CName _workspotEntryAnimVar;
		private CName _animControllerVarName;
		private CName _splineStartAnimVarName;
		private CName _splineStopAnimVarName;
		private CName _moveTargetVarName;

		[Ordinal(1)] 
		[RED("workspotNodeVarName")] 
		public CName WorkspotNodeVarName
		{
			get => GetProperty(ref _workspotNodeVarName);
			set => SetProperty(ref _workspotNodeVarName, value);
		}

		[Ordinal(2)] 
		[RED("prevWorkspotNodeVarName")] 
		public CName PrevWorkspotNodeVarName
		{
			get => GetProperty(ref _prevWorkspotNodeVarName);
			set => SetProperty(ref _prevWorkspotNodeVarName, value);
		}

		[Ordinal(3)] 
		[RED("splineNodeVarName")] 
		public CName SplineNodeVarName
		{
			get => GetProperty(ref _splineNodeVarName);
			set => SetProperty(ref _splineNodeVarName, value);
		}

		[Ordinal(4)] 
		[RED("workspotEntryAnimVar")] 
		public CName WorkspotEntryAnimVar
		{
			get => GetProperty(ref _workspotEntryAnimVar);
			set => SetProperty(ref _workspotEntryAnimVar, value);
		}

		[Ordinal(5)] 
		[RED("animControllerVarName")] 
		public CName AnimControllerVarName
		{
			get => GetProperty(ref _animControllerVarName);
			set => SetProperty(ref _animControllerVarName, value);
		}

		[Ordinal(6)] 
		[RED("splineStartAnimVarName")] 
		public CName SplineStartAnimVarName
		{
			get => GetProperty(ref _splineStartAnimVarName);
			set => SetProperty(ref _splineStartAnimVarName, value);
		}

		[Ordinal(7)] 
		[RED("splineStopAnimVarName")] 
		public CName SplineStopAnimVarName
		{
			get => GetProperty(ref _splineStopAnimVarName);
			set => SetProperty(ref _splineStopAnimVarName, value);
		}

		[Ordinal(8)] 
		[RED("moveTargetVarName")] 
		public CName MoveTargetVarName
		{
			get => GetProperty(ref _moveTargetVarName);
			set => SetProperty(ref _moveTargetVarName, value);
		}
	}
}
