using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceCover : ActivatedDeviceTransfromAnim
	{
		[Ordinal(0)]  [RED("offMeshConnection")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnection { get; set; }

		public ActivatedDeviceCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
