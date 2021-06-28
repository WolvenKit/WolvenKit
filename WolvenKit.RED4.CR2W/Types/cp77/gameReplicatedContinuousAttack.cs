using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedContinuousAttack : CVariable
	{
		private netTime _startTimeStamp;
		private netTime _stopTimeStamp;
		private TweakDBID _attackId;

		[Ordinal(0)] 
		[RED("startTimeStamp")] 
		public netTime StartTimeStamp
		{
			get => GetProperty(ref _startTimeStamp);
			set => SetProperty(ref _startTimeStamp, value);
		}

		[Ordinal(1)] 
		[RED("stopTimeStamp")] 
		public netTime StopTimeStamp
		{
			get => GetProperty(ref _stopTimeStamp);
			set => SetProperty(ref _stopTimeStamp, value);
		}

		[Ordinal(2)] 
		[RED("attackId")] 
		public TweakDBID AttackId
		{
			get => GetProperty(ref _attackId);
			set => SetProperty(ref _attackId, value);
		}

		public gameReplicatedContinuousAttack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
