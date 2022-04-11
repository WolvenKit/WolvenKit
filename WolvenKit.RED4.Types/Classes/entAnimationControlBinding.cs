
namespace WolvenKit.RED4.Types
{
	public partial class entAnimationControlBinding : entISourceBinding
	{
		public entAnimationControlBinding()
		{
			Enabled = true;
			EnableMask = new() { HardTags = new() { Tags = new() }, SoftTags = new() { Tags = new() }, ExcludedTags = new() { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
