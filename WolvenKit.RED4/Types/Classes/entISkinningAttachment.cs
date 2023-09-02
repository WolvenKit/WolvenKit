
namespace WolvenKit.RED4.Types
{
	public abstract partial class entISkinningAttachment : entIAttachment
	{
		public entISkinningAttachment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
