using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetLifePath : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("lifePathID")] public TweakDBID LifePathID { get; set; }

		public questCharacterManagerParameters_SetLifePath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
