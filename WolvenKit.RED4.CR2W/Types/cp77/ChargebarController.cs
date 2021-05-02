using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargebarController : inkWidgetLogicController
	{
		private inkWidgetReference _foreground;
		private inkWidgetReference _midground;
		private inkWidgetReference _background;
		private CName _maxChargeAnimationName;
		private CHandle<inkanimProxy> _animationMaxCharge;
		private CHandle<gameStatsSystem> _statsSystem;
		private CBool _canFullyCharge;
		private CBool _canOvercharge;
		private CHandle<ChargebarStatsListener> _listenerFullCharge;
		private CHandle<ChargebarStatsListener> _listenerOvercharge;

		[Ordinal(1)] 
		[RED("foreground")] 
		public inkWidgetReference Foreground
		{
			get => GetProperty(ref _foreground);
			set => SetProperty(ref _foreground, value);
		}

		[Ordinal(2)] 
		[RED("midground")] 
		public inkWidgetReference Midground
		{
			get => GetProperty(ref _midground);
			set => SetProperty(ref _midground, value);
		}

		[Ordinal(3)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(4)] 
		[RED("maxChargeAnimationName")] 
		public CName MaxChargeAnimationName
		{
			get => GetProperty(ref _maxChargeAnimationName);
			set => SetProperty(ref _maxChargeAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("animationMaxCharge")] 
		public CHandle<inkanimProxy> AnimationMaxCharge
		{
			get => GetProperty(ref _animationMaxCharge);
			set => SetProperty(ref _animationMaxCharge, value);
		}

		[Ordinal(6)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(7)] 
		[RED("canFullyCharge")] 
		public CBool CanFullyCharge
		{
			get => GetProperty(ref _canFullyCharge);
			set => SetProperty(ref _canFullyCharge, value);
		}

		[Ordinal(8)] 
		[RED("canOvercharge")] 
		public CBool CanOvercharge
		{
			get => GetProperty(ref _canOvercharge);
			set => SetProperty(ref _canOvercharge, value);
		}

		[Ordinal(9)] 
		[RED("listenerFullCharge")] 
		public CHandle<ChargebarStatsListener> ListenerFullCharge
		{
			get => GetProperty(ref _listenerFullCharge);
			set => SetProperty(ref _listenerFullCharge, value);
		}

		[Ordinal(10)] 
		[RED("listenerOvercharge")] 
		public CHandle<ChargebarStatsListener> ListenerOvercharge
		{
			get => GetProperty(ref _listenerOvercharge);
			set => SetProperty(ref _listenerOvercharge, value);
		}

		public ChargebarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
