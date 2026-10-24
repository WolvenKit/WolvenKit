
namespace WolvenKit.RED4.Types
{
	public partial class entAnimationControlBinding : entISourceBinding
	{
		public entAnimationControlBinding()
		{
			Enabled = true;
			EnableMask = new entTagMask { ExcludedTags = new redTagList { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
