using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePingComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("associatedPingType")] public CEnum<gamedataPingType> AssociatedPingType { get; set; }

		public gamePingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
