
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldEditorDebugFilterSettings : ISerializable
	{
		public worldEditorDebugFilterSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
