using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entContextualLookAtRemoveEvent : entLookAtRemoveEvent
	{
		[Ordinal(3)] 
		[RED("contextName")] 
		public CName ContextName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
