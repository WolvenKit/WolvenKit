using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SChannelEnumData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("channel")] 
		public CEnum<ETVChannel> Channel
		{
			get => GetPropertyValue<CEnum<ETVChannel>>();
			set => SetPropertyValue<CEnum<ETVChannel>>(value);
		}
	}
}
