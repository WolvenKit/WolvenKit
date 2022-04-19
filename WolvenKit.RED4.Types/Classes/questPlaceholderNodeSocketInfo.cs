using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlaceholderNodeSocketInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<questSocketType> Type
		{
			get => GetPropertyValue<CEnum<questSocketType>>();
			set => SetPropertyValue<CEnum<questSocketType>>(value);
		}

		public questPlaceholderNodeSocketInfo()
		{
			Type = Enums.questSocketType.Input;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
