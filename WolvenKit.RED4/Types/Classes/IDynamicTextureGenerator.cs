
namespace WolvenKit.RED4.Types
{
	public partial class IDynamicTextureGenerator : ISerializable
	{
		public IDynamicTextureGenerator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
