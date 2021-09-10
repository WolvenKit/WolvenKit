using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimSetStyleEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("style")] 
		public CResourceAsyncReference<inkStyleResource> Style
		{
			get => GetPropertyValue<CResourceAsyncReference<inkStyleResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkStyleResource>>(value);
		}
	}
}
