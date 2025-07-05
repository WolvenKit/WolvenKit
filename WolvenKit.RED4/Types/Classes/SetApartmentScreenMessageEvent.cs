using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetApartmentScreenMessageEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("targetRentStatus")] 
		public CEnum<ERentStatus> TargetRentStatus
		{
			get => GetPropertyValue<CEnum<ERentStatus>>();
			set => SetPropertyValue<CEnum<ERentStatus>>(value);
		}

		public SetApartmentScreenMessageEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
