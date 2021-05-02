using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTutorialOverlayInputRequest : redEvent
	{
		private CBool _isInputRequested;

		[Ordinal(0)] 
		[RED("isInputRequested")] 
		public CBool IsInputRequested
		{
			get => GetProperty(ref _isInputRequested);
			set => SetProperty(ref _isInputRequested, value);
		}

		public inkTutorialOverlayInputRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
