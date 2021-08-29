using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsTimeChangeEvent : redEvent
	{
		private CUInt32 _listenerId;

		[Ordinal(0)] 
		[RED("listenerId")] 
		public CUInt32 ListenerId
		{
			get => GetProperty(ref _listenerId);
			set => SetProperty(ref _listenerId, value);
		}
	}
}
