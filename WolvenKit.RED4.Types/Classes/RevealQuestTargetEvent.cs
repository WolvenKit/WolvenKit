using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealQuestTargetEvent : redEvent
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
	}
}
