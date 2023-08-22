
namespace WolvenKit.RED4.Types
{
	public abstract partial class scnIInterruptCondition : ISerializable
	{
		public scnIInterruptCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
