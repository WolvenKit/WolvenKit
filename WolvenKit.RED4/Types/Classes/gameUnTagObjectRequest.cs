using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameUnTagObjectRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public gameUnTagObjectRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
