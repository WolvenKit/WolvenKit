using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIsquadsOrder : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)]  [RED("squadAction")] public CName SquadAction { get; set; }
		[Ordinal(2)]  [RED("state")] public CUInt32 State { get; set; }

		public AIsquadsOrder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
