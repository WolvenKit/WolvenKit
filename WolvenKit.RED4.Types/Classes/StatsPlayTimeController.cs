using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatsPlayTimeController : inkWidgetLogicController
	{
		private inkTextWidgetReference _playTimeRef;
		private inkTextWidgetReference _lifePathRef;
		private inkImageWidgetReference _lifePathIconRef;

		[Ordinal(1)] 
		[RED("playTimeRef")] 
		public inkTextWidgetReference PlayTimeRef
		{
			get => GetProperty(ref _playTimeRef);
			set => SetProperty(ref _playTimeRef, value);
		}

		[Ordinal(2)] 
		[RED("lifePathRef")] 
		public inkTextWidgetReference LifePathRef
		{
			get => GetProperty(ref _lifePathRef);
			set => SetProperty(ref _lifePathRef, value);
		}

		[Ordinal(3)] 
		[RED("lifePathIconRef")] 
		public inkImageWidgetReference LifePathIconRef
		{
			get => GetProperty(ref _lifePathIconRef);
			set => SetProperty(ref _lifePathIconRef, value);
		}
	}
}
