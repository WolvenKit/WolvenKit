using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamecheatsystemObjCheats : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CInt32 Flags
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gamecheatsystemObjCheats()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
