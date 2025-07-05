using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCallbackConnectorData : IScriptable
	{
		[Ordinal(0)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public inkCallbackConnectorData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
