
namespace WolvenKit.RED4.Types
{
	public abstract partial class IDynamicTextureGenerator : ISerializable
	{
		public IDynamicTextureGenerator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
