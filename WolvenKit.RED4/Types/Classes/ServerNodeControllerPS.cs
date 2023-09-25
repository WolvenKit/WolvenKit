using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ServerNodeControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("coverState")] 
		public CEnum<CoverState> CoverState
		{
			get => GetPropertyValue<CEnum<CoverState>>();
			set => SetPropertyValue<CEnum<CoverState>>(value);
		}

		[Ordinal(108)] 
		[RED("serverState")] 
		public CEnum<ServerState> ServerState
		{
			get => GetPropertyValue<CEnum<ServerState>>();
			set => SetPropertyValue<CEnum<ServerState>>(value);
		}

		[Ordinal(109)] 
		[RED("destroyedPin", 12)] 
		public CArrayFixedSize<CInt32> DestroyedPin
		{
			get => GetPropertyValue<CArrayFixedSize<CInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CInt32>>(value);
		}

		public ServerNodeControllerPS()
		{
			CoverState = Enums.CoverState.Closed;
			DestroyedPin = new(12);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
