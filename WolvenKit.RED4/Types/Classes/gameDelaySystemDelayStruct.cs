
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemDelayStruct : ISerializable
	{
		public gameDelaySystemDelayStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
