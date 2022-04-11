using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreviousMenuData : IScriptable
	{
		[Ordinal(0)] 
		[RED("openMenuRequest")] 
		public CHandle<OpenMenuRequest> OpenMenuRequest
		{
			get => GetPropertyValue<CHandle<OpenMenuRequest>>();
			set => SetPropertyValue<CHandle<OpenMenuRequest>>(value);
		}
	}
}
