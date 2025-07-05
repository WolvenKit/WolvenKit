
namespace WolvenKit.RED4.Types
{
	public abstract partial class scnIInterruptionOperation : ISerializable
	{
		public scnIInterruptionOperation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
