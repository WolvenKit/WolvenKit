using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DropPointMappinRegistrationData : IScriptable
	{
		[Ordinal(0)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(1)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(2)] [RED("mapinID")] public gameNewMappinID MapinID { get; set; }
		[Ordinal(3)] [RED("trackingAlternativeMappinID")] public gameNewMappinID TrackingAlternativeMappinID { get; set; }

		public DropPointMappinRegistrationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
