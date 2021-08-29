using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutlineRequestEvent : redEvent
	{
		private CHandle<OutlineRequest> _outlineRequest;
		private CBool _flag;

		[Ordinal(0)] 
		[RED("outlineRequest")] 
		public CHandle<OutlineRequest> OutlineRequest
		{
			get => GetProperty(ref _outlineRequest);
			set => SetProperty(ref _outlineRequest, value);
		}

		[Ordinal(1)] 
		[RED("flag")] 
		public CBool Flag
		{
			get => GetProperty(ref _flag);
			set => SetProperty(ref _flag, value);
		}
	}
}
