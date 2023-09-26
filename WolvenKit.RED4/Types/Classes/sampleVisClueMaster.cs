using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleVisClueMaster : gameObject
	{
		[Ordinal(36)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		public sampleVisClueMaster()
		{
			DependableEntities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
