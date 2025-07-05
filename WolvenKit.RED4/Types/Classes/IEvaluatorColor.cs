
namespace WolvenKit.RED4.Types
{
	public abstract partial class IEvaluatorColor : IEvaluator
	{
		public IEvaluatorColor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
