using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioSoundComponentBase : entIPlacedComponent
	{
		private CName _audioName;
		private CBool _applyObstruction;
		private CBool _applyAcousticOcclusion;
		private CBool _applyAcousticRepositioning;
		private CFloat _obstructionChangeTime;
		private CFloat _maxPlayDistance;

		[Ordinal(5)] 
		[RED("audioName")] 
		public CName AudioName
		{
			get => GetProperty(ref _audioName);
			set => SetProperty(ref _audioName, value);
		}

		[Ordinal(6)] 
		[RED("applyObstruction")] 
		public CBool ApplyObstruction
		{
			get => GetProperty(ref _applyObstruction);
			set => SetProperty(ref _applyObstruction, value);
		}

		[Ordinal(7)] 
		[RED("applyAcousticOcclusion")] 
		public CBool ApplyAcousticOcclusion
		{
			get => GetProperty(ref _applyAcousticOcclusion);
			set => SetProperty(ref _applyAcousticOcclusion, value);
		}

		[Ordinal(8)] 
		[RED("applyAcousticRepositioning")] 
		public CBool ApplyAcousticRepositioning
		{
			get => GetProperty(ref _applyAcousticRepositioning);
			set => SetProperty(ref _applyAcousticRepositioning, value);
		}

		[Ordinal(9)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetProperty(ref _obstructionChangeTime);
			set => SetProperty(ref _obstructionChangeTime, value);
		}

		[Ordinal(10)] 
		[RED("maxPlayDistance")] 
		public CFloat MaxPlayDistance
		{
			get => GetProperty(ref _maxPlayDistance);
			set => SetProperty(ref _maxPlayDistance, value);
		}
	}
}
