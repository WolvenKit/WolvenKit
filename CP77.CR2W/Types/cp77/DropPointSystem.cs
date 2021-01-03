using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DropPointSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(1)]  [RED("mappins")] public CArray<CHandle<DropPointMappinRegistrationData>> Mappins { get; set; }
		[Ordinal(2)]  [RED("packages")] public CArray<CHandle<DropPointPackage>> Packages { get; set; }

		public DropPointSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
