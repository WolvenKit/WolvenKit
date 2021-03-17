using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BroadcastEvent : redEvent
	{
		private CEnum<EBroadcasteingType> _broadcastType;
		private CBool _shouldOverride;
		private CFloat _lifetime;
		private CEnum<gamedataStimType> _stimType;
		private stimInvestigateData _stimData;
		private CFloat _radius;
		private CBool _propagationChange;
		private wCHandle<entEntity> _directTarget;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("broadcastType")] 
		public CEnum<EBroadcasteingType> BroadcastType
		{
			get => GetProperty(ref _broadcastType);
			set => SetProperty(ref _broadcastType, value);
		}

		[Ordinal(1)] 
		[RED("shouldOverride")] 
		public CBool ShouldOverride
		{
			get => GetProperty(ref _shouldOverride);
			set => SetProperty(ref _shouldOverride, value);
		}

		[Ordinal(2)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetProperty(ref _lifetime);
			set => SetProperty(ref _lifetime, value);
		}

		[Ordinal(3)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(4)] 
		[RED("stimData")] 
		public stimInvestigateData StimData
		{
			get => GetProperty(ref _stimData);
			set => SetProperty(ref _stimData, value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(6)] 
		[RED("propagationChange")] 
		public CBool PropagationChange
		{
			get => GetProperty(ref _propagationChange);
			set => SetProperty(ref _propagationChange, value);
		}

		[Ordinal(7)] 
		[RED("directTarget")] 
		public wCHandle<entEntity> DirectTarget
		{
			get => GetProperty(ref _directTarget);
			set => SetProperty(ref _directTarget, value);
		}

		[Ordinal(8)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		public BroadcastEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
