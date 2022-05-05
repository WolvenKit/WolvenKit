using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExampleNavigationTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("queryId")] 
		public CUInt32 QueryId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("queryStarted")] 
		public CBool QueryStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExampleNavigationTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
