using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGlobalNodeID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hash")] 
		public NodeRef Hash
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public worldGlobalNodeID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
