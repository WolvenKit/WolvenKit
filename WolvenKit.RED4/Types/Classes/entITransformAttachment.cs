
namespace WolvenKit.RED4.Types
{
	public abstract partial class entITransformAttachment : entIAttachment
	{
		public entITransformAttachment()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
