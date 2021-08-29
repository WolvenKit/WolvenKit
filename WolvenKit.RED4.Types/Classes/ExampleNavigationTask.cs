using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExampleNavigationTask : AIbehaviortaskScript
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
	}
}
