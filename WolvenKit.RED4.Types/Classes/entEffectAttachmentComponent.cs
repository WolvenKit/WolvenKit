
namespace WolvenKit.RED4.Types
{
	public partial class entEffectAttachmentComponent : entIComponent
	{
		public entEffectAttachmentComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
