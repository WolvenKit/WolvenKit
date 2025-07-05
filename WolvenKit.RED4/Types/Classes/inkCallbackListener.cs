using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCallbackListener : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<IScriptable> Object
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(1)] 
		[RED("functionName")] 
		public CName FunctionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkCallbackListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
