
namespace WolvenKit.RED4.Types
{
	public partial class entSkinningBinding : entISourceBinding
	{
		public entSkinningBinding()
		{
			Enabled = true;
			EnableMask = new entTagMask { ExcludedTags = new redTagList { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
