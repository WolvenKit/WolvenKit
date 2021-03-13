using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioListItemData : IScriptable
	{
		[Ordinal(0)] [RED("record")] public wCHandle<gamedataRadioStation_Record> Record { get; set; }

		public RadioListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
