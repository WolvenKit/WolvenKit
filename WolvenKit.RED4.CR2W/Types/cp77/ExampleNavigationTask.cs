using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExampleNavigationTask : AIbehaviortaskScript
	{
		private CUInt32 _queryId;
		private CBool _queryStarted;

		[Ordinal(0)] 
		[RED("queryId")] 
		public CUInt32 QueryId
		{
			get => GetProperty(ref _queryId);
			set => SetProperty(ref _queryId, value);
		}

		[Ordinal(1)] 
		[RED("queryStarted")] 
		public CBool QueryStarted
		{
			get => GetProperty(ref _queryStarted);
			set => SetProperty(ref _queryStarted, value);
		}

		public ExampleNavigationTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
