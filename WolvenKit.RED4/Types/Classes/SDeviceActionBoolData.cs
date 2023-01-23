using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDeviceActionBoolData : SDeviceActionData
	{
		[Ordinal(10)] 
		[RED("nameOnTrueRecord")] 
		public TweakDBID NameOnTrueRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(11)] 
		[RED("nameOnTrue")] 
		public CString NameOnTrue
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("nameOnFalseRecord")] 
		public TweakDBID NameOnFalseRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("nameOnFalse")] 
		public CString NameOnFalse
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SDeviceActionBoolData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
