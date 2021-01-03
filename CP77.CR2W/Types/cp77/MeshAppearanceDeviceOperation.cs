using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MeshAppearanceDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("meshesAppearence")] public CName MeshesAppearence { get; set; }

		public MeshAppearanceDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
