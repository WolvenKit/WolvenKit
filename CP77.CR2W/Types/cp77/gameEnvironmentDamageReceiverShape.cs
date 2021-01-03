using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverShape : ISerializable
	{
		[Ordinal(0)]  [RED("transform")] public Transform Transform { get; set; }

		public gameEnvironmentDamageReceiverShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
