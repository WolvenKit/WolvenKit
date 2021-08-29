using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveFromChainRequest : gameScriptableSystemRequest
	{
		private entEntityID _requestSource;

		[Ordinal(0)] 
		[RED("requestSource")] 
		public entEntityID RequestSource
		{
			get => GetProperty(ref _requestSource);
			set => SetProperty(ref _requestSource, value);
		}
	}
}
