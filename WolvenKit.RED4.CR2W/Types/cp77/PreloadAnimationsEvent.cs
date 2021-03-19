using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreloadAnimationsEvent : redEvent
	{
		private CName _streamingContextName;
		private CBool _highPriority;

		[Ordinal(0)] 
		[RED("streamingContextName")] 
		public CName StreamingContextName
		{
			get => GetProperty(ref _streamingContextName);
			set => SetProperty(ref _streamingContextName, value);
		}

		[Ordinal(1)] 
		[RED("highPriority")] 
		public CBool HighPriority
		{
			get => GetProperty(ref _highPriority);
			set => SetProperty(ref _highPriority, value);
		}

		public PreloadAnimationsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
