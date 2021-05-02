using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionBluelinePart : gameinteractionsChoiceCaptionPart
	{
		private CHandle<gameinteractionsvisBluelineDescription> _blueline;

		[Ordinal(0)] 
		[RED("blueline")] 
		public CHandle<gameinteractionsvisBluelineDescription> Blueline
		{
			get => GetProperty(ref _blueline);
			set => SetProperty(ref _blueline, value);
		}

		public gameinteractionsChoiceCaptionBluelinePart(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
