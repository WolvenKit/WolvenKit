using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AsyncSpawnData : IScriptable
	{
		private wCHandle<IScriptable> _callbackTarget;
		private wCHandle<IScriptable> _controller;
		private CName _functionName;
		private CName _libraryID;
		private CVariant _widgetData;

		[Ordinal(0)] 
		[RED("callbackTarget")] 
		public wCHandle<IScriptable> CallbackTarget
		{
			get => GetProperty(ref _callbackTarget);
			set => SetProperty(ref _callbackTarget, value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public wCHandle<IScriptable> Controller
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

		public AsyncSpawnData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
