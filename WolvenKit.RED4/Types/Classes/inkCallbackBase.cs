using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class inkCallbackBase : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("listeners")] 
		public CArray<inkCallbackListener> Listeners
		{
			get => GetPropertyValue<CArray<inkCallbackListener>>();
			set => SetPropertyValue<CArray<inkCallbackListener>>(value);
		}

		public inkCallbackBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
