using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entKillEffectEvent : redEvent
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
	}
}
