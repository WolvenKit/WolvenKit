using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class megatronFullAutoController : AmmoLogicController
	{
		private CWeakHandle<inkTextWidget> _ammoCountText;
		private CWeakHandle<inkImageWidget> _ammoBar;

		[Ordinal(3)] 
		[RED("ammoCountText")] 
		public CWeakHandle<inkTextWidget> AmmoCountText
		{
			get => GetProperty(ref _ammoCountText);
			set => SetProperty(ref _ammoCountText, value);
		}

		[Ordinal(4)] 
		[RED("ammoBar")] 
		public CWeakHandle<inkImageWidget> AmmoBar
		{
			get => GetProperty(ref _ammoBar);
			set => SetProperty(ref _ammoBar, value);
		}
	}
}
