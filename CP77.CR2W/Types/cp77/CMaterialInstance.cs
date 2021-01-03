using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMaterialInstance : IMaterial
	{
		[Ordinal(0)]  [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(1)]  [RED("baseMaterial")] public rRef<IMaterial> BaseMaterial { get; set; }
		[Ordinal(2)]  [RED("enableMask")] public CBool EnableMask { get; set; }
		[Ordinal(3)]  [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }

		public CMaterialInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
