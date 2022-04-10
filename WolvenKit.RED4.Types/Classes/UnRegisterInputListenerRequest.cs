using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnRegisterInputListenerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public UnRegisterInputListenerRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
