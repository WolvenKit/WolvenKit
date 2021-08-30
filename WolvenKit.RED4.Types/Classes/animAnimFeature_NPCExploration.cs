using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_NPCExploration : animAnimFeature
	{
		private CInt32 _explorationType;
		private CInt32 _state;
		private CInt32 _movementType;
		private CBool _isEvenLoop;

		[Ordinal(0)] 
		[RED("explorationType")] 
		public CInt32 ExplorationType
		{
			get => GetProperty(ref _explorationType);
			set => SetProperty(ref _explorationType, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("movementType")] 
		public CInt32 MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(3)] 
		[RED("isEvenLoop")] 
		public CBool IsEvenLoop
		{
			get => GetProperty(ref _isEvenLoop);
			set => SetProperty(ref _isEvenLoop, value);
		}

		public animAnimFeature_NPCExploration()
		{
			_isEvenLoop = true;
		}
	}
}
