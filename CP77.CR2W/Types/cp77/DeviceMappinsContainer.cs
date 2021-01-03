using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceMappinsContainer : IScriptable
	{
		[Ordinal(0)]  [RED("mappins")] public CArray<SDeviceMappinData> Mappins { get; set; }
		[Ordinal(1)]  [RED("newNewFocusMappin")] public SDeviceMappinData NewNewFocusMappin { get; set; }
		[Ordinal(2)]  [RED("offsetValue")] public CFloat OffsetValue { get; set; }
		[Ordinal(3)]  [RED("useNewFocusMappin")] public CBool UseNewFocusMappin { get; set; }

		public DeviceMappinsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
