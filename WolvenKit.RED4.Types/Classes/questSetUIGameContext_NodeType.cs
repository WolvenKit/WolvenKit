using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetUIGameContext_NodeType : questIUIManagerNodeType
	{
		private CEnum<questUIGameContextRequestType> _requestType;
		private CEnum<UIGameContext> _context;

		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<questUIGameContextRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CEnum<UIGameContext> Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}
	}
}
