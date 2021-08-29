using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StorageUserData : IScriptable
	{
		private CWeakHandle<gameObject> _storageObject;

		[Ordinal(0)] 
		[RED("storageObject")] 
		public CWeakHandle<gameObject> StorageObject
		{
			get => GetProperty(ref _storageObject);
			set => SetProperty(ref _storageObject, value);
		}
	}
}
