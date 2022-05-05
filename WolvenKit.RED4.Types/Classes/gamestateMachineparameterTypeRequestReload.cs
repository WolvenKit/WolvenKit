using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineparameterTypeRequestReload : IScriptable
	{
		[Ordinal(0)] 
		[RED("item")] 
		public CWeakHandle<gameItemObject> Item
		{
			get => GetPropertyValue<CWeakHandle<gameItemObject>>();
			set => SetPropertyValue<CWeakHandle<gameItemObject>>(value);
		}

		public gamestateMachineparameterTypeRequestReload()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
