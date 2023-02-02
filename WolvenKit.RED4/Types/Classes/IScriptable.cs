
namespace WolvenKit.RED4.Types
{
	public partial class IScriptable : ISerializable
	{
		public IScriptable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
