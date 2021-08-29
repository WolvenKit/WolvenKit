using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCensorshipController : inkWidgetLogicController
	{
		private CEnum<CensorshipFlags> _censorshipFlags;

		[Ordinal(1)] 
		[RED("censorshipFlags")] 
		public CEnum<CensorshipFlags> CensorshipFlags
		{
			get => GetProperty(ref _censorshipFlags);
			set => SetProperty(ref _censorshipFlags, value);
		}
	}
}
