using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareTabModsRequest : redEvent
	{
		private CBool _open;
		private CHandle<CyberwareDisplayWrapper> _wrapper;

		[Ordinal(0)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetProperty(ref _open);
			set => SetProperty(ref _open, value);
		}

		[Ordinal(1)] 
		[RED("wrapper")] 
		public CHandle<CyberwareDisplayWrapper> Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}
	}
}
