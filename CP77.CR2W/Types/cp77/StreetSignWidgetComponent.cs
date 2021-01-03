using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StreetSignWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(0)]  [RED("isAStreetName")] public CBool IsAStreetName { get; set; }
		[Ordinal(1)]  [RED("signSelector")] public CHandle<inkTweakDBIDSelector> SignSelector { get; set; }
		[Ordinal(2)]  [RED("signVersion")] public CUInt32 SignVersion { get; set; }
		[Ordinal(3)]  [RED("streetNameSignTDBID")] public TweakDBID StreetNameSignTDBID { get; set; }
		[Ordinal(4)]  [RED("streetSignTDBID")] public TweakDBID StreetSignTDBID { get; set; }

		public StreetSignWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
