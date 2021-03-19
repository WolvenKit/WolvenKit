using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionAnimationCurvePathDefinition : AICTreeNodeActionDefinition
	{
		private LibTreeDefNodeRef _nodeReference;
		private LibTreeDefCName _controllersSetupName;
		private LibTreeDefBool _useStart;
		private LibTreeDefBool _useStop;
		private LibTreeDefFloat _blendTime;
		private LibTreeDefFloat _globalInBlendTime;
		private LibTreeDefFloat _globalOutBlendTime;
		private LibTreeDefBool _turnCharacterToMatchVelocity;
		private LibTreeDefCName _customStartAnimationName;
		private LibTreeDefCName _customMainAnimationName;
		private LibTreeDefCName _customStopAnimationName;
		private LibTreeDefBool _startSnapToTerrain;
		private LibTreeDefBool _mainSnapToTerrain;
		private LibTreeDefBool _stopSnapToTerrain;
		private LibTreeDefFloat _startSnapToTerrainBlendTime;
		private LibTreeDefFloat _stopSnapToTerrainBlendTime;

		[Ordinal(1)] 
		[RED("nodeReference")] 
		public LibTreeDefNodeRef NodeReference
		{
			get => GetProperty(ref _nodeReference);
			set => SetProperty(ref _nodeReference, value);
		}

		[Ordinal(2)] 
		[RED("controllersSetupName")] 
		public LibTreeDefCName ControllersSetupName
		{
			get => GetProperty(ref _controllersSetupName);
			set => SetProperty(ref _controllersSetupName, value);
		}

		[Ordinal(3)] 
		[RED("useStart")] 
		public LibTreeDefBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(4)] 
		[RED("useStop")] 
		public LibTreeDefBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(5)] 
		[RED("blendTime")] 
		public LibTreeDefFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(6)] 
		[RED("globalInBlendTime")] 
		public LibTreeDefFloat GlobalInBlendTime
		{
			get => GetProperty(ref _globalInBlendTime);
			set => SetProperty(ref _globalInBlendTime, value);
		}

		[Ordinal(7)] 
		[RED("globalOutBlendTime")] 
		public LibTreeDefFloat GlobalOutBlendTime
		{
			get => GetProperty(ref _globalOutBlendTime);
			set => SetProperty(ref _globalOutBlendTime, value);
		}

		[Ordinal(8)] 
		[RED("turnCharacterToMatchVelocity")] 
		public LibTreeDefBool TurnCharacterToMatchVelocity
		{
			get => GetProperty(ref _turnCharacterToMatchVelocity);
			set => SetProperty(ref _turnCharacterToMatchVelocity, value);
		}

		[Ordinal(9)] 
		[RED("customStartAnimationName")] 
		public LibTreeDefCName CustomStartAnimationName
		{
			get => GetProperty(ref _customStartAnimationName);
			set => SetProperty(ref _customStartAnimationName, value);
		}

		[Ordinal(10)] 
		[RED("customMainAnimationName")] 
		public LibTreeDefCName CustomMainAnimationName
		{
			get => GetProperty(ref _customMainAnimationName);
			set => SetProperty(ref _customMainAnimationName, value);
		}

		[Ordinal(11)] 
		[RED("customStopAnimationName")] 
		public LibTreeDefCName CustomStopAnimationName
		{
			get => GetProperty(ref _customStopAnimationName);
			set => SetProperty(ref _customStopAnimationName, value);
		}

		[Ordinal(12)] 
		[RED("startSnapToTerrain")] 
		public LibTreeDefBool StartSnapToTerrain
		{
			get => GetProperty(ref _startSnapToTerrain);
			set => SetProperty(ref _startSnapToTerrain, value);
		}

		[Ordinal(13)] 
		[RED("mainSnapToTerrain")] 
		public LibTreeDefBool MainSnapToTerrain
		{
			get => GetProperty(ref _mainSnapToTerrain);
			set => SetProperty(ref _mainSnapToTerrain, value);
		}

		[Ordinal(14)] 
		[RED("stopSnapToTerrain")] 
		public LibTreeDefBool StopSnapToTerrain
		{
			get => GetProperty(ref _stopSnapToTerrain);
			set => SetProperty(ref _stopSnapToTerrain, value);
		}

		[Ordinal(15)] 
		[RED("startSnapToTerrainBlendTime")] 
		public LibTreeDefFloat StartSnapToTerrainBlendTime
		{
			get => GetProperty(ref _startSnapToTerrainBlendTime);
			set => SetProperty(ref _startSnapToTerrainBlendTime, value);
		}

		[Ordinal(16)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public LibTreeDefFloat StopSnapToTerrainBlendTime
		{
			get => GetProperty(ref _stopSnapToTerrainBlendTime);
			set => SetProperty(ref _stopSnapToTerrainBlendTime, value);
		}

		public AICTreeNodeActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
