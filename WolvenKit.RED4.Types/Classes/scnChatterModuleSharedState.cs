using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChatterModuleSharedState : ISerializable
	{
		[Ordinal(0)] 
		[RED("chatterHistory")] 
		public CArray<CHandle<scnChatter>> ChatterHistory
		{
			get => GetPropertyValue<CArray<CHandle<scnChatter>>>();
			set => SetPropertyValue<CArray<CHandle<scnChatter>>>(value);
		}

		public scnChatterModuleSharedState()
		{
			ChatterHistory = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
