
namespace WolvenKit.RED4.Types
{
	public abstract partial class toolsIMessageToken : ISerializable
	{
		public toolsIMessageToken()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
