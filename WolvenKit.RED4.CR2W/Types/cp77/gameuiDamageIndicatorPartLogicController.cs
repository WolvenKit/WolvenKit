using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		private CFloat _maxDistanceForSharedIndicators;
		private inkImageWidgetReference _arrowFrontWidget;
		private CFloat _damageThreshold;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _animProxy;
		private CFloat _damageTaken;
		private CBool _continuous;

		[Ordinal(3)] 
		[RED("maxDistanceForSharedIndicators")] 
		public CFloat MaxDistanceForSharedIndicators
		{
			get => GetProperty(ref _maxDistanceForSharedIndicators);
			set => SetProperty(ref _maxDistanceForSharedIndicators, value);
		}

		[Ordinal(4)] 
		[RED("arrowFrontWidget")] 
		public inkImageWidgetReference ArrowFrontWidget
		{
			get => GetProperty(ref _arrowFrontWidget);
			set => SetProperty(ref _arrowFrontWidget, value);
		}

		[Ordinal(5)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetProperty(ref _damageThreshold);
			set => SetProperty(ref _damageThreshold, value);
		}

		[Ordinal(6)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(7)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(8)] 
		[RED("damageTaken")] 
		public CFloat DamageTaken
		{
			get => GetProperty(ref _damageTaken);
			set => SetProperty(ref _damageTaken, value);
		}

		[Ordinal(9)] 
		[RED("continuous")] 
		public CBool Continuous
		{
			get => GetProperty(ref _continuous);
			set => SetProperty(ref _continuous, value);
		}

		public gameuiDamageIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
