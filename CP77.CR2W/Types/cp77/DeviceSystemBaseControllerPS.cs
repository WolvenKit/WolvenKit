using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceSystemBaseControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("quickHacksEnabled")] public CBool QuickHacksEnabled { get; set; }

		public DeviceSystemBaseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
