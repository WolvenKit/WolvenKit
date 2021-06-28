using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTrapTooltipDisplayer : inkWidgetLogicController
	{
		private wCHandle<gamedataMiniGame_Trap_Record> _trap;
		private CFloat _delayDuration;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(1)] 
		[RED("trap")] 
		public wCHandle<gamedataMiniGame_Trap_Record> Trap
		{
			get => GetProperty(ref _trap);
			set => SetProperty(ref _trap, value);
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetProperty(ref _delayDuration);
			set => SetProperty(ref _delayDuration, value);
		}

		[Ordinal(3)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		public gameuiTrapTooltipDisplayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
