using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interopEntityEffectSelectionSyncData : CVariable
	{
		[Ordinal(0)]  [RED("effectIDPath")] public toolsEditorObjectIDPath EffectIDPath { get; set; }
		[Ordinal(1)]  [RED("effectName")] public CName EffectName { get; set; }

		public interopEntityEffectSelectionSyncData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
