using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationTrackItem : ISerializable
	{
		private CHandle<gameTransformAnimationTrackItemImpl> _impl;
		private CFloat _startTime;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("impl")] 
		public CHandle<gameTransformAnimationTrackItemImpl> Impl
		{
			get => GetProperty(ref _impl);
			set => SetProperty(ref _impl, value);
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public gameTransformAnimationTrackItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
