using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleVisWireMasterTwo : gameObject
	{
		[Ordinal(35)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		public sampleVisWireMasterTwo()
		{
			DependableEntities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
