
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIAttachmentSlotsListener : IScriptable
	{
		public gameIAttachmentSlotsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
