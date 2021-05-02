using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectSignalEvent : redEvent
	{
		private TweakDBID _statusEffectID;
		private CFloat _priority;
		private CArray<CName> _tags;
		private CArray<CEnum<EAIGateSignalFlags>> _flags;
		private CFloat _repeatSignalDelay;

		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetProperty(ref _statusEffectID);
			set => SetProperty(ref _statusEffectID, value);
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CFloat Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(2)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CArray<CEnum<EAIGateSignalFlags>> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(4)] 
		[RED("repeatSignalDelay")] 
		public CFloat RepeatSignalDelay
		{
			get => GetProperty(ref _repeatSignalDelay);
			set => SetProperty(ref _repeatSignalDelay, value);
		}

		public StatusEffectSignalEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
