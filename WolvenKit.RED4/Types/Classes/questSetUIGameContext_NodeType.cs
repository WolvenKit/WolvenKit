using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetUIGameContext_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<questUIGameContextRequestType> RequestType
		{
			get => GetPropertyValue<CEnum<questUIGameContextRequestType>>();
			set => SetPropertyValue<CEnum<questUIGameContextRequestType>>(value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CEnum<UIGameContext> Context
		{
			get => GetPropertyValue<CEnum<UIGameContext>>();
			set => SetPropertyValue<CEnum<UIGameContext>>(value);
		}

		public questSetUIGameContext_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
