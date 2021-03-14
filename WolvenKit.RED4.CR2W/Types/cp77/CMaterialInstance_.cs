using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialInstance_ : IMaterial
	{
		[Ordinal(1)] [RED("baseMaterial")] public rRef<IMaterial> BaseMaterial { get; set; }
		[Ordinal(2)] [RED("enableMask")] public CBool EnableMask { get; set; }
		[Ordinal(3)] [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(4)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }

		public CMaterialInstance_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
