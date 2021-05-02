using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealRequestEvent : redEvent
	{
		private CBool _shouldReveal;
		private entEntityID _requester;
		private CBool _oneFrame;

		[Ordinal(0)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get => GetProperty(ref _shouldReveal);
			set => SetProperty(ref _shouldReveal, value);
		}

		[Ordinal(1)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(2)] 
		[RED("oneFrame")] 
		public CBool OneFrame
		{
			get => GetProperty(ref _oneFrame);
			set => SetProperty(ref _oneFrame, value);
		}

		public RevealRequestEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
