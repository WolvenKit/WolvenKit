using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioListItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("record")] 
		public CWeakHandle<gamedataRadioStation_Record> Record
		{
			get => GetPropertyValue<CWeakHandle<gamedataRadioStation_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataRadioStation_Record>>(value);
		}

		public RadioListItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
