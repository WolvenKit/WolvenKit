using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimSetStyleEvent : inkanimEvent
	{
		private CResourceAsyncReference<inkStyleResource> _style;

		[Ordinal(1)] 
		[RED("style")] 
		public CResourceAsyncReference<inkStyleResource> Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}
	}
}
