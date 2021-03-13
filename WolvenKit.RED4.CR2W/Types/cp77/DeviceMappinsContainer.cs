using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceMappinsContainer : IScriptable
	{
		[Ordinal(0)] [RED("mappins")] public CArray<SDeviceMappinData> Mappins { get; set; }
		[Ordinal(1)] [RED("newNewFocusMappin")] public SDeviceMappinData NewNewFocusMappin { get; set; }
		[Ordinal(2)] [RED("useNewFocusMappin")] public CBool UseNewFocusMappin { get; set; }
		[Ordinal(3)] [RED("offsetValue")] public CFloat OffsetValue { get; set; }

		public DeviceMappinsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
