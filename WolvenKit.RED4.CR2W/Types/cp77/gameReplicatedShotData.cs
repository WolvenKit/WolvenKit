using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedShotData : CVariable
	{
		private netTime _timeStamp;
		private TweakDBID _attackId;
		private wCHandle<gameObject> _target;
		private Vector3 _targetLocalOffset;

		[Ordinal(0)] 
		[RED("timeStamp")] 
		public netTime TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(1)] 
		[RED("attackId")] 
		public TweakDBID AttackId
		{
			get => GetProperty(ref _attackId);
			set => SetProperty(ref _attackId, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(3)] 
		[RED("targetLocalOffset")] 
		public Vector3 TargetLocalOffset
		{
			get => GetProperty(ref _targetLocalOffset);
			set => SetProperty(ref _targetLocalOffset, value);
		}

		public gameReplicatedShotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
