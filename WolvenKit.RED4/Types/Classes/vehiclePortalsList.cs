using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehiclePortalsList : IScriptable
	{
		[Ordinal(0)] 
		[RED("listPoints")] 
		public CArray<NodeRef> ListPoints
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		public vehiclePortalsList()
		{
			ListPoints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
