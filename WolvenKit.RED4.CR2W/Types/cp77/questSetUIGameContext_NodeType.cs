using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetUIGameContext_NodeType : questIUIManagerNodeType
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

		public questSetUIGameContext_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
