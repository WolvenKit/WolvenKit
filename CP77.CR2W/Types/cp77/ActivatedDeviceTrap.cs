using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrap : ActivatedDeviceTransfromAnim
	{
		[Ordinal(0)]  [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }

		public ActivatedDeviceTrap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
