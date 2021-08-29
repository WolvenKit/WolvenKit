using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCallbackBase : RedBaseClass
	{
		private CName _callbackName;
		private CArray<inkCallbackListener> _listeners;

		[Ordinal(0)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetProperty(ref _callbackName);
			set => SetProperty(ref _callbackName, value);
		}

		[Ordinal(1)] 
		[RED("listeners")] 
		public CArray<inkCallbackListener> Listeners
		{
			get => GetProperty(ref _listeners);
			set => SetProperty(ref _listeners, value);
		}
	}
}
