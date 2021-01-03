using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisposalDeviceSetup : CVariable
	{
		[Ordinal(0)]  [RED("actionName")] public TweakDBID ActionName { get; set; }
		[Ordinal(1)]  [RED("isBodyRequired")] public CBool IsBodyRequired { get; set; }
		[Ordinal(2)]  [RED("nonlethalTakedownActionName")] public TweakDBID NonlethalTakedownActionName { get; set; }
		[Ordinal(3)]  [RED("numberOfUses")] public CInt32 NumberOfUses { get; set; }
		[Ordinal(4)]  [RED("takedownActionName")] public TweakDBID TakedownActionName { get; set; }

		public DisposalDeviceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
