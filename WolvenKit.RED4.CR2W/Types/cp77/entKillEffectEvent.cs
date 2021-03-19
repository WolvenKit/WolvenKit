using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entKillEffectEvent : redEvent
	{
		private CName _effectName;
		private CBool _breakAllLoops;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(1)] 
		[RED("breakAllLoops")] 
		public CBool BreakAllLoops
		{
			get => GetProperty(ref _breakAllLoops);
			set => SetProperty(ref _breakAllLoops, value);
		}

		public entKillEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
