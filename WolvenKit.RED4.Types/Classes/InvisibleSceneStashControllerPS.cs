using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InvisibleSceneStashControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("storedItems")] 
		public CArray<gameItemID> StoredItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public InvisibleSceneStashControllerPS()
		{
			StoredItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
