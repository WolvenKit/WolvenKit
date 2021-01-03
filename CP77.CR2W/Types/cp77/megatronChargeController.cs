using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class megatronChargeController : ChargeLogicController
	{
		[Ordinal(0)]  [RED("chargeBar")] public wCHandle<inkImageWidget> ChargeBar { get; set; }

		public megatronChargeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
