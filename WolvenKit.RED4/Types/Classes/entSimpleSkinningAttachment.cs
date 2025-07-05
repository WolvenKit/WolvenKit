
namespace WolvenKit.RED4.Types
{
	public abstract partial class entSimpleSkinningAttachment : entISkinningAttachment
	{
		public entSimpleSkinningAttachment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
