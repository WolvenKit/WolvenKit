using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetCustomStyle_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("style")] 
		public CEnum<questCustomStyle> Style
		{
			get => GetPropertyValue<CEnum<questCustomStyle>>();
			set => SetPropertyValue<CEnum<questCustomStyle>>(value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetCustomStyle_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
