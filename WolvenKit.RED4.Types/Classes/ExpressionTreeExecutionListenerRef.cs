
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class ExpressionTreeExecutionListenerRef : RedBaseClass
	{
		public ExpressionTreeExecutionListenerRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
