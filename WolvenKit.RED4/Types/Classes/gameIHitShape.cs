
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIHitShape : ISerializable
	{
		public gameIHitShape()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
