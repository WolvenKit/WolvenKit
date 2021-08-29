using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterToListListener : gameScriptableSystemRequest
	{
		private CWeakHandle<gameObject> _object;
		private CName _funcName;

		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(1)] 
		[RED("funcName")] 
		public CName FuncName
		{
			get => GetProperty(ref _funcName);
			set => SetProperty(ref _funcName, value);
		}
	}
}
