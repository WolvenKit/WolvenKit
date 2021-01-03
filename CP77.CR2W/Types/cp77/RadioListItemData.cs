using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RadioListItemData : IScriptable
	{
		[Ordinal(0)]  [RED("record")] public wCHandle<gamedataRadioStation_Record> Record { get; set; }

		public RadioListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
