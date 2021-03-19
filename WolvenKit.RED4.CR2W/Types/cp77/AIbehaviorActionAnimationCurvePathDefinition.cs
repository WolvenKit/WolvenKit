using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionAnimationCurvePathDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _nodeReference;
		private CHandle<AIArgumentMapping> _controllersSetupName;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _useStop;
		private CHandle<AIArgumentMapping> _blendTime;
		private CHandle<AIArgumentMapping> _globalInBlendTime;
		private CHandle<AIArgumentMapping> _globalOutBlendTime;
		private CHandle<AIArgumentMapping> _turnCharacterToMatchVelocity;
		private CHandle<AIArgumentMapping> _customStartAnimationName;
		private CHandle<AIArgumentMapping> _customMainAnimationName;
		private CHandle<AIArgumentMapping> _customStopAnimationName;
		private CHandle<AIArgumentMapping> _startSnapToTerrain;
		private CHandle<AIArgumentMapping> _mainSnapToTerrain;
		private CHandle<AIArgumentMapping> _stopSnapToTerrain;
		private CHandle<AIArgumentMapping> _startSnapToTerrainBlendTime;
		private CHandle<AIArgumentMapping> _stopSnapToTerrainBlendTime;

		[Ordinal(1)] 
		[RED("nodeReference")] 
		public CHandle<AIArgumentMapping> NodeReference
		{
			get => GetProperty(ref _nodeReference);
			set => SetProperty(ref _nodeReference, value);
		}

		[Ordinal(2)] 
		[RED("controllersSetupName")] 
		public CHandle<AIArgumentMapping> ControllersSetupName
		{
			get => GetProperty(ref _controllersSetupName);
			set => SetProperty(ref _controllersSetupName, value);
		}

		[Ordinal(3)] 
		[RED("useStart")] 
		public CHandle<AIArgumentMapping> UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(4)] 
		[RED("useStop")] 
		public CHandle<AIArgumentMapping> UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(5)] 
		[RED("blendTime")] 
		public CHandle<AIArgumentMapping> BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(6)] 
		[RED("globalInBlendTime")] 
		public CHandle<AIArgumentMapping> GlobalInBlendTime
		{
			get => GetProperty(ref _globalInBlendTime);
			set => SetProperty(ref _globalInBlendTime, value);
		}

		[Ordinal(7)] 
		[RED("globalOutBlendTime")] 
		public CHandle<AIArgumentMapping> GlobalOutBlendTime
		{
			get => GetProperty(ref _globalOutBlendTime);
			set => SetProperty(ref _globalOutBlendTime, value);
		}

		[Ordinal(8)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CHandle<AIArgumentMapping> TurnCharacterToMatchVelocity
		{
			get => GetProperty(ref _turnCharacterToMatchVelocity);
			set => SetProperty(ref _turnCharacterToMatchVelocity, value);
		}

		[Ordinal(9)] 
		[RED("customStartAnimationName")] 
		public CHandle<AIArgumentMapping> CustomStartAnimationName
		{
			get => GetProperty(ref _customStartAnimationName);
			set => SetProperty(ref _customStartAnimationName, value);
		}

		[Ordinal(10)] 
		[RED("customMainAnimationName")] 
		public CHandle<AIArgumentMapping> CustomMainAnimationName
		{
			get => GetProperty(ref _customMainAnimationName);
			set => SetProperty(ref _customMainAnimationName, value);
		}

		[Ordinal(11)] 
		[RED("customStopAnimationName")] 
		public CHandle<AIArgumentMapping> CustomStopAnimationName
		{
			get => GetProperty(ref _customStopAnimationName);
			set => SetProperty(ref _customStopAnimationName, value);
		}

		[Ordinal(12)] 
		[RED("startSnapToTerrain")] 
		public CHandle<AIArgumentMapping> StartSnapToTerrain
		{
			get => GetProperty(ref _startSnapToTerrain);
			set => SetProperty(ref _startSnapToTerrain, value);
		}

		[Ordinal(13)] 
		[RED("mainSnapToTerrain")] 
		public CHandle<AIArgumentMapping> MainSnapToTerrain
		{
			get => GetProperty(ref _mainSnapToTerrain);
			set => SetProperty(ref _mainSnapToTerrain, value);
		}

		[Ordinal(14)] 
		[RED("stopSnapToTerrain")] 
		public CHandle<AIArgumentMapping> StopSnapToTerrain
		{
			get => GetProperty(ref _stopSnapToTerrain);
			set => SetProperty(ref _stopSnapToTerrain, value);
		}

		[Ordinal(15)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CHandle<AIArgumentMapping> StartSnapToTerrainBlendTime
		{
			get => GetProperty(ref _startSnapToTerrainBlendTime);
			set => SetProperty(ref _startSnapToTerrainBlendTime, value);
		}

		[Ordinal(16)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CHandle<AIArgumentMapping> StopSnapToTerrainBlendTime
		{
			get => GetProperty(ref _stopSnapToTerrainBlendTime);
			set => SetProperty(ref _stopSnapToTerrainBlendTime, value);
		}

		public AIbehaviorActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
