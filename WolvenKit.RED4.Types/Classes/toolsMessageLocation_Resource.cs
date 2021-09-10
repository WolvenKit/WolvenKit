using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsMessageLocation_Resource : toolsIMessageLocation
	{
		[Ordinal(0)] 
		[RED("path")] 
		public MessageResourcePath Path
		{
			get => GetPropertyValue<MessageResourcePath>();
			set => SetPropertyValue<MessageResourcePath>(value);
		}
	}
}
