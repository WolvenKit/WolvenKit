using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessageLocation_Resource : toolsIMessageLocation
	{
		[Ordinal(0)] 
		[RED("path")] 
		public MessageResourcePath Path
		{
			get => GetPropertyValue<MessageResourcePath>();
			set => SetPropertyValue<MessageResourcePath>(value);
		}

		public toolsMessageLocation_Resource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
