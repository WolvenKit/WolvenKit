using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioListItemData : IScriptable
	{
		private wCHandle<gamedataRadioStation_Record> _record;

		[Ordinal(0)] 
		[RED("record")] 
		public wCHandle<gamedataRadioStation_Record> Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		public RadioListItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
