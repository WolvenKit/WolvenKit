
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldEditorDebugColoringSettings : ISerializable
	{
		public worldEditorDebugColoringSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
