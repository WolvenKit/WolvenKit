using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreviousMenuData : IScriptable
	{
		private CHandle<OpenMenuRequest> _openMenuRequest;

		[Ordinal(0)] 
		[RED("openMenuRequest")] 
		public CHandle<OpenMenuRequest> OpenMenuRequest
		{
			get => GetProperty(ref _openMenuRequest);
			set => SetProperty(ref _openMenuRequest, value);
		}
	}
}
