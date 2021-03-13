using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseDeviceStatus : ActionEnum
	{
		[Ordinal(25)] [RED("isRestarting")] public CBool IsRestarting { get; set; }

		public BaseDeviceStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
