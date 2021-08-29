using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleScreenProjectionGameController : gameuiProjectedHUDGameController
	{
		private CHandle<redCallbackObject> _onTargetHitCallback;

		[Ordinal(9)] 
		[RED("OnTargetHitCallback")] 
		public CHandle<redCallbackObject> OnTargetHitCallback
		{
			get => GetProperty(ref _onTargetHitCallback);
			set => SetProperty(ref _onTargetHitCallback, value);
		}
	}
}
