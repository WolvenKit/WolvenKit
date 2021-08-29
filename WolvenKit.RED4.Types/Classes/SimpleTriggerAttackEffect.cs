using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleTriggerAttackEffect : gameEffector
	{
		private CWeakHandle<gameObject> _owner;
		private TweakDBID _attackTDBID;
		private CBool _shouldDelay;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetProperty(ref _attackTDBID);
			set => SetProperty(ref _attackTDBID, value);
		}

		[Ordinal(2)] 
		[RED("shouldDelay")] 
		public CBool ShouldDelay
		{
			get => GetProperty(ref _shouldDelay);
			set => SetProperty(ref _shouldDelay, value);
		}
	}
}
