
namespace WolvenKit.RED4.Types
{
	public partial class gameBinkMeshTargetBinding : entISourceBinding
	{
		public gameBinkMeshTargetBinding()
		{
			Enabled = true;
			EnableMask = new() { HardTags = new() { Tags = new() }, SoftTags = new() { Tags = new() }, ExcludedTags = new() { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
