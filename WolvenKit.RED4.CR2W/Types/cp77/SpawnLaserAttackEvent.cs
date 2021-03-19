using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnLaserAttackEvent : redEvent
	{
		private CHandle<gamedataAttack_Record> _attackRecord;
		private CFloat _range;
		private CFloat _duration;
		private CInt32 _index;
		private CBool _playSlotAnimation;

		[Ordinal(0)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(4)] 
		[RED("playSlotAnimation")] 
		public CBool PlaySlotAnimation
		{
			get => GetProperty(ref _playSlotAnimation);
			set => SetProperty(ref _playSlotAnimation, value);
		}

		public SpawnLaserAttackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
