
namespace WolvenKit.RED4.Types
{
	public abstract partial class animIRuntimeCondition : ISerializable
	{
		public animIRuntimeCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
