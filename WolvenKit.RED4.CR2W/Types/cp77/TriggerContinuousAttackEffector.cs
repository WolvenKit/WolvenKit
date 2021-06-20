using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerContinuousAttackEffector : gameContinuousEffector
	{
		private wCHandle<gameObject> _owner;
		private TweakDBID _attackTDBID;
		private CHandle<gameAttack_GameEffect> _attack;
		private CFloat _delayTime;

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
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}

		[Ordinal(3)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetProperty(ref _delayTime);
			set => SetProperty(ref _delayTime, value);
		}

		public TriggerContinuousAttackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
