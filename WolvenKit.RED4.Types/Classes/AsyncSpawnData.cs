using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AsyncSpawnData : IScriptable
	{
		private CWeakHandle<IScriptable> _callbackTarget;
		private CWeakHandle<IScriptable> _controller;
		private CName _functionName;
		private CName _libraryID;
		private CVariant _widgetData;

		[Ordinal(0)] 
		[RED("callbackTarget")] 
		public CWeakHandle<IScriptable> CallbackTarget
		{
			get => GetProperty(ref _callbackTarget);
			set => SetProperty(ref _callbackTarget, value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public CWeakHandle<IScriptable> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(2)] 
		[RED("functionName")] 
		public CName FunctionName
		{
			get => GetProperty(ref _functionName);
			set => SetProperty(ref _functionName, value);
		}

		[Ordinal(3)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetProperty(ref _libraryID);
			set => SetProperty(ref _libraryID, value);
		}

		[Ordinal(4)] 
		[RED("widgetData")] 
		public CVariant WidgetData
		{
			get => GetProperty(ref _widgetData);
			set => SetProperty(ref _widgetData, value);
		}
	}
}
