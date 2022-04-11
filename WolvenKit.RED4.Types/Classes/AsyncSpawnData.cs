using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AsyncSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("callbackTarget")] 
		public CWeakHandle<IScriptable> CallbackTarget
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public CWeakHandle<IScriptable> Controller
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(2)] 
		[RED("functionName")] 
		public CName FunctionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("widgetData")] 
		public CVariant WidgetData
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public AsyncSpawnData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
