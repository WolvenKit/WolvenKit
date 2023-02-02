using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StorageUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("storageObject")] 
		public CWeakHandle<gameObject> StorageObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public StorageUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
