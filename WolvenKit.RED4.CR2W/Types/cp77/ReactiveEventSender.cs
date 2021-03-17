using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactiveEventSender : AISignalSenderTask
	{
		private CName _behaviorArgumentNameTag;
		private CName _behaviorArgumentFloatPriority;
		private CName _behaviorArgumentNameFlag;
		private CName _reactiveType;

		[Ordinal(4)] 
		[RED("behaviorArgumentNameTag")] 
		public CName BehaviorArgumentNameTag
		{
			get => GetProperty(ref _behaviorArgumentNameTag);
			set => SetProperty(ref _behaviorArgumentNameTag, value);
		}

		[Ordinal(5)] 
		[RED("behaviorArgumentFloatPriority")] 
		public CName BehaviorArgumentFloatPriority
		{
			get => GetProperty(ref _behaviorArgumentFloatPriority);
			set => SetProperty(ref _behaviorArgumentFloatPriority, value);
		}

		[Ordinal(6)] 
		[RED("behaviorArgumentNameFlag")] 
		public CName BehaviorArgumentNameFlag
		{
			get => GetProperty(ref _behaviorArgumentNameFlag);
			set => SetProperty(ref _behaviorArgumentNameFlag, value);
		}

		[Ordinal(7)] 
		[RED("reactiveType")] 
		public CName ReactiveType
		{
			get => GetProperty(ref _reactiveType);
			set => SetProperty(ref _reactiveType, value);
		}

		public ReactiveEventSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
