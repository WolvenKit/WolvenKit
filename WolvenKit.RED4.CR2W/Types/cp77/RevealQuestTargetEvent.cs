using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealQuestTargetEvent : redEvent
	{
		private CName _sourceName;
		private CEnum<ERevealDurationType> _durationType;
		private CBool _reveal;
		private CFloat _timeout;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(1)] 
		[RED("durationType")] 
		public CEnum<ERevealDurationType> DurationType
		{
			get => GetProperty(ref _durationType);
			set => SetProperty(ref _durationType, value);
		}

		[Ordinal(2)] 
		[RED("reveal")] 
		public CBool Reveal
		{
			get => GetProperty(ref _reveal);
			set => SetProperty(ref _reveal, value);
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		public RevealQuestTargetEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
