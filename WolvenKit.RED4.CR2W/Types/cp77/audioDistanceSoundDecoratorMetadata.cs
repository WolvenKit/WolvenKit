using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDistanceSoundDecoratorMetadata : audioEmitterMetadata
	{
		private CName _onEnter;
		private CName _onLeave;
		private CFloat _triggerDistance;
		private CBool _stopOnlyVirtualSounds;

		[Ordinal(1)] 
		[RED("onEnter")] 
		public CName OnEnter
		{
			get => GetProperty(ref _onEnter);
			set => SetProperty(ref _onEnter, value);
		}

		[Ordinal(2)] 
		[RED("onLeave")] 
		public CName OnLeave
		{
			get => GetProperty(ref _onLeave);
			set => SetProperty(ref _onLeave, value);
		}

		[Ordinal(3)] 
		[RED("triggerDistance")] 
		public CFloat TriggerDistance
		{
			get => GetProperty(ref _triggerDistance);
			set => SetProperty(ref _triggerDistance, value);
		}

		[Ordinal(4)] 
		[RED("stopOnlyVirtualSounds")] 
		public CBool StopOnlyVirtualSounds
		{
			get => GetProperty(ref _stopOnlyVirtualSounds);
			set => SetProperty(ref _stopOnlyVirtualSounds, value);
		}

		public audioDistanceSoundDecoratorMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
