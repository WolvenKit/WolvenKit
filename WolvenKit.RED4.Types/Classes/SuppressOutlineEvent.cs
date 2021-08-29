using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SuppressOutlineEvent : redEvent
	{
		private CHandle<OutlineRequest> _requestToSuppress;

		[Ordinal(0)] 
		[RED("requestToSuppress")] 
		public CHandle<OutlineRequest> RequestToSuppress
		{
			get => GetProperty(ref _requestToSuppress);
			set => SetProperty(ref _requestToSuppress, value);
		}
	}
}
