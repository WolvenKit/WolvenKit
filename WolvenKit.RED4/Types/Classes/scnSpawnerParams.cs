using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSpawnerParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnSpawnerParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
