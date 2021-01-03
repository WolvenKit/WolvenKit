using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficGlobalPathPosition : ISerializable
	{
		[Ordinal(0)]  [RED("pathIdx")] public CUInt32 PathIdx { get; set; }
		[Ordinal(1)]  [RED("worldPosition")] public Vector3 WorldPosition { get; set; }

		public worldTrafficGlobalPathPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
