using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestUIRefreshEvent : redEvent
	{
		private gamePersistentID _requester;
		private CName _context;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CName Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		public RequestUIRefreshEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
