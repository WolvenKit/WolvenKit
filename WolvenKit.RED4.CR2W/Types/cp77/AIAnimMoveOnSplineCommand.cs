using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAnimMoveOnSplineCommand : AIMoveCommand
	{
		private NodeRef _spline;
		private CBool _useStart;
		private CBool _useStop;
		private CName _controllerSetupName;
		private CFloat _blendTime;
		private CFloat _globalInBlendTime;
		private CFloat _globalOutBlendTime;
		private CBool _turnCharacterToMatchVelocity;
		private CName _customStartAnimationName;
		private CName _customMainAnimationName;
		private CName _customStopAnimationName;
		private CBool _startSnapToTerrain;
		private CBool _mainSnapToTerrain;
		private CBool _stopSnapToTerrain;
		private CFloat _startSnapToTerrainBlendTime;
		private CFloat _stopSnapToTerrainBlendTime;

		[Ordinal(7)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(8)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(9)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(10)] 
		[RED("controllerSetupName")] 
		public CName ControllerSetupName
		{
			get => GetProperty(ref _controllerSetupName);
			set => SetProperty(ref _controllerSetupName, value);
		}

		[Ordinal(11)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(12)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get => GetProperty(ref _globalInBlendTime);
			set => SetProperty(ref _globalInBlendTime, value);
		}

		[Ordinal(13)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get => GetProperty(ref _globalOutBlendTime);
			set => SetProperty(ref _globalOutBlendTime, value);
		}

		[Ordinal(14)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get => GetProperty(ref _turnCharacterToMatchVelocity);
			set => SetProperty(ref _turnCharacterToMatchVelocity, value);
		}

		[Ordinal(15)] 
		[RED("customStartAnimationName")] 
		public CName CustomStartAnimationName
		{
			get => GetProperty(ref _customStartAnimationName);
			set => SetProperty(ref _customStartAnimationName, value);
		}

		[Ordinal(16)] 
		[RED("customMainAnimationName")] 
		public CName CustomMainAnimationName
		{
			get => GetProperty(ref _customMainAnimationName);
			set => SetProperty(ref _customMainAnimationName, value);
		}

		[Ordinal(17)] 
		[RED("customStopAnimationName")] 
		public CName CustomStopAnimationName
		{
			get => GetProperty(ref _customStopAnimationName);
			set => SetProperty(ref _customStopAnimationName, value);
		}

		[Ordinal(18)] 
		[RED("startSnapToTerrain")] 
		public CBool StartSnapToTerrain
		{
			get => GetProperty(ref _startSnapToTerrain);
			set => SetProperty(ref _startSnapToTerrain, value);
		}

		[Ordinal(19)] 
		[RED("mainSnapToTerrain")] 
		public CBool MainSnapToTerrain
		{
			get => GetProperty(ref _mainSnapToTerrain);
			set => SetProperty(ref _mainSnapToTerrain, value);
		}

		[Ordinal(20)] 
		[RED("stopSnapToTerrain")] 
		public CBool StopSnapToTerrain
		{
			get => GetProperty(ref _stopSnapToTerrain);
			set => SetProperty(ref _stopSnapToTerrain, value);
		}

		[Ordinal(21)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CFloat StartSnapToTerrainBlendTime
		{
			get => GetProperty(ref _startSnapToTerrainBlendTime);
			set => SetProperty(ref _startSnapToTerrainBlendTime, value);
		}

		[Ordinal(22)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CFloat StopSnapToTerrainBlendTime
		{
			get => GetProperty(ref _stopSnapToTerrainBlendTime);
			set => SetProperty(ref _stopSnapToTerrainBlendTime, value);
		}

		public AIAnimMoveOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
