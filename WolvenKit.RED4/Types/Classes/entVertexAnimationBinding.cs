
namespace WolvenKit.RED4.Types
{
	public partial class entVertexAnimationBinding : entISourceBinding
	{
		public entVertexAnimationBinding()
		{
			Enabled = true;
			EnableMask = new entTagMask { ExcludedTags = new redTagList { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
