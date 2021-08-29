using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkDisplayContainerCreatedEvent : redEvent
	{
		private CInt32 _index;
		private CBool _isTrait;
		private CWeakHandle<PerkDisplayContainerController> _container;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get => GetProperty(ref _isTrait);
			set => SetProperty(ref _isTrait, value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public CWeakHandle<PerkDisplayContainerController> Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}
	}
}
