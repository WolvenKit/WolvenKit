using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePingComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("associatedPingType")] public CEnum<gamedataPingType> AssociatedPingType { get; set; }

		public gamePingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
