using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnOwnerEffect : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private TweakDBID _attackTDBID;
		private CBool _playerAsInstigator;
		private CBool _triggerHitReaction;
		private CName _attackPositionSlotName;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
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
		[RED("playerAsInstigator")] 
		public CBool PlayerAsInstigator
		{
			get => GetProperty(ref _playerAsInstigator);
			set => SetProperty(ref _playerAsInstigator, value);
		}

		[Ordinal(3)] 
		[RED("triggerHitReaction")] 
		public CBool TriggerHitReaction
		{
			get => GetProperty(ref _triggerHitReaction);
			set => SetProperty(ref _triggerHitReaction, value);
		}

		[Ordinal(4)] 
		[RED("attackPositionSlotName")] 
		public CName AttackPositionSlotName
		{
			get => GetProperty(ref _attackPositionSlotName);
			set => SetProperty(ref _attackPositionSlotName, value);
		}

		public TriggerAttackOnOwnerEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
