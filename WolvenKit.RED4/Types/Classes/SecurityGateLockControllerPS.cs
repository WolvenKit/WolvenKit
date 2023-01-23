using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGateLockControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("tresspasserList")] 
		public CArray<TrespasserEntry> TresspasserList
		{
			get => GetPropertyValue<CArray<TrespasserEntry>>();
			set => SetPropertyValue<CArray<TrespasserEntry>>(value);
		}

		[Ordinal(105)] 
		[RED("entranceToken")] 
		public entEntityID EntranceToken
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(106)] 
		[RED("isLeaving")] 
		public CBool IsLeaving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(107)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityGateLockControllerPS()
		{
			TresspasserList = new();
			EntranceToken = new();
			IsLocked = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
