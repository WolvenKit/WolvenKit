using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entContextualLookAtAddEvent : entLookAtAddEvent
	{
		[Ordinal(4)] 
		[RED("contextName")] 
		public CName ContextName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
