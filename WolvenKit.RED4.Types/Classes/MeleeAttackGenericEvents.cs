using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeAttackGenericEvents : MeleeEventsTransition
	{
		private CHandle<gameEffectInstance> _effect;
		private CBool _attackCreated;
		private CBool _blockImpulseCreation;
		private CBool _standUpSend;
		private CBool _trailCreated;
		private CUInt32 _textLayer;
		private CBool _rumblePlayed;
		private CBool _shouldBlockImpulseUpdate;

		[Ordinal(0)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(1)] 
		[RED("attackCreated")] 
		public CBool AttackCreated
		{
			get => GetProperty(ref _attackCreated);
			set => SetProperty(ref _attackCreated, value);
		}

		[Ordinal(2)] 
		[RED("blockImpulseCreation")] 
		public CBool BlockImpulseCreation
		{
			get => GetProperty(ref _blockImpulseCreation);
			set => SetProperty(ref _blockImpulseCreation, value);
		}

		[Ordinal(3)] 
		[RED("standUpSend")] 
		public CBool StandUpSend
		{
			get => GetProperty(ref _standUpSend);
			set => SetProperty(ref _standUpSend, value);
		}

		[Ordinal(4)] 
		[RED("trailCreated")] 
		public CBool TrailCreated
		{
			get => GetProperty(ref _trailCreated);
			set => SetProperty(ref _trailCreated, value);
		}

		[Ordinal(5)] 
		[RED("textLayer")] 
		public CUInt32 TextLayer
		{
			get => GetProperty(ref _textLayer);
			set => SetProperty(ref _textLayer, value);
		}

		[Ordinal(6)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetProperty(ref _rumblePlayed);
			set => SetProperty(ref _rumblePlayed, value);
		}

		[Ordinal(7)] 
		[RED("shouldBlockImpulseUpdate")] 
		public CBool ShouldBlockImpulseUpdate
		{
			get => GetProperty(ref _shouldBlockImpulseUpdate);
			set => SetProperty(ref _shouldBlockImpulseUpdate, value);
		}
	}
}
