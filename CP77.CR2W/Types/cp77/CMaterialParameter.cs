using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameter : ISerializable
	{
		[Ordinal(0)]  [RED("parameterName")] public CName ParameterName { get; set; }
		[Ordinal(1)]  [RED("register")] public CUInt32 Register { get; set; }

		public CMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
