using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareTabModsRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("wrapper")] 
		public CHandle<CyberwareDisplayWrapper> Wrapper
		{
			get => GetPropertyValue<CHandle<CyberwareDisplayWrapper>>();
			set => SetPropertyValue<CHandle<CyberwareDisplayWrapper>>(value);
		}
	}
}
