using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCallbackListener : RedBaseClass
	{
		private CWeakHandle<IScriptable> _object;
		private CName _functionName;

		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<IScriptable> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(1)] 
		[RED("functionName")] 
		public CName FunctionName
		{
			get => GetProperty(ref _functionName);
			set => SetProperty(ref _functionName, value);
		}
	}
}
