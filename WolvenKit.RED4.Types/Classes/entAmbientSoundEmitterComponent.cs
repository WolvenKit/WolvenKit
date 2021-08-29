using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAmbientSoundEmitterComponent : entIPlacedComponent
	{
		private CHandle<audioAmbientAreaSettings> _settings;
		private CBool _usePhysicsObstruction;
		private CBool _occlusionEnabled;
		private CBool _repositionEnabled;
		private CFloat _obstructionChangeTime;

		[Ordinal(5)] 
		[RED("Settings")] 
		public CHandle<audioAmbientAreaSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(6)] 
		[RED("usePhysicsObstruction")] 
		public CBool UsePhysicsObstruction
		{
			get => GetProperty(ref _usePhysicsObstruction);
			set => SetProperty(ref _usePhysicsObstruction, value);
		}

		[Ordinal(7)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetProperty(ref _occlusionEnabled);
			set => SetProperty(ref _occlusionEnabled, value);
		}

		[Ordinal(8)] 
		[RED("repositionEnabled")] 
		public CBool RepositionEnabled
		{
			get => GetProperty(ref _repositionEnabled);
			set => SetProperty(ref _repositionEnabled, value);
		}

		[Ordinal(9)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetProperty(ref _obstructionChangeTime);
			set => SetProperty(ref _obstructionChangeTime, value);
		}
	}
}
