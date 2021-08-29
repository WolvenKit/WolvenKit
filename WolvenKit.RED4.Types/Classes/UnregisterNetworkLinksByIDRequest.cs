using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterNetworkLinksByIDRequest : gameScriptableSystemRequest
	{
		private entEntityID _iD;

		[Ordinal(0)] 
		[RED("ID")] 
		public entEntityID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}
	}
}
