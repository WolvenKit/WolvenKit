using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageHistoryEntry : CVariable
	{
		private CHandle<gameeventsHitEvent> _hitEvent;
		private CFloat _totalDamageReceived;
		private CUInt64 _frameReceived;
		private CFloat _timestamp;
		private CFloat _healthAtTheTime;
		private wCHandle<gameObject> _source;
		private wCHandle<gameObject> _target;

		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetProperty(ref _hitEvent);
			set => SetProperty(ref _hitEvent, value);
		}

		[Ordinal(1)] 
		[RED("totalDamageReceived")] 
		public CFloat TotalDamageReceived
		{
			get => GetProperty(ref _totalDamageReceived);
			set => SetProperty(ref _totalDamageReceived, value);
		}

		[Ordinal(2)] 
		[RED("frameReceived")] 
		public CUInt64 FrameReceived
		{
			get => GetProperty(ref _frameReceived);
			set => SetProperty(ref _frameReceived, value);
		}

		[Ordinal(3)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetProperty(ref _timestamp);
			set => SetProperty(ref _timestamp, value);
		}

		[Ordinal(4)] 
		[RED("healthAtTheTime")] 
		public CFloat HealthAtTheTime
		{
			get => GetProperty(ref _healthAtTheTime);
			set => SetProperty(ref _healthAtTheTime, value);
		}

		[Ordinal(5)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(6)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public DamageHistoryEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
