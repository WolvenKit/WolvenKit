using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryAnimationFinished : CVariable
	{
		private CName _hudEntry;
		private CName _animationName;
		private CBool _finished;

		[Ordinal(0)] 
		[RED("hudEntry")] 
		public CName HudEntry
		{
			get => GetProperty(ref _hudEntry);
			set => SetProperty(ref _hudEntry, value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(2)] 
		[RED("finished")] 
		public CBool Finished
		{
			get => GetProperty(ref _finished);
			set => SetProperty(ref _finished, value);
		}

		public questHUDEntryAnimationFinished(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
