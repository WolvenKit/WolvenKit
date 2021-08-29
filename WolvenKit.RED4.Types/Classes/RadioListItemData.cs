using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadioListItemData : IScriptable
	{
		private CWeakHandle<gamedataRadioStation_Record> _record;

		[Ordinal(0)] 
		[RED("record")] 
		public CWeakHandle<gamedataRadioStation_Record> Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}
	}
}
