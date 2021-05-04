using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineRequestManager : IScriptable
	{
		private CArray<CHandle<OutlineRequest>> _requestsList;
		private wCHandle<gameObject> _owner;
		private CBool _isBlocked;
		private CArray<CHandle<OutlineRequest>> _dbgRequests;

		[Ordinal(0)] 
		[RED("requestsList")] 
		public CArray<CHandle<OutlineRequest>> RequestsList
		{
			get => GetProperty(ref _requestsList);
			set => SetProperty(ref _requestsList, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(2)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetProperty(ref _isBlocked);
			set => SetProperty(ref _isBlocked, value);
		}

		[Ordinal(3)] 
		[RED("dbgRequests")] 
		public CArray<CHandle<OutlineRequest>> DbgRequests
		{
			get => GetProperty(ref _dbgRequests);
			set => SetProperty(ref _dbgRequests, value);
		}

		public OutlineRequestManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
