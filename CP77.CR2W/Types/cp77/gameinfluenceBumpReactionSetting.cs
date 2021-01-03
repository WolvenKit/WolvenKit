using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpReactionSetting : ISerializable
	{
		[Ordinal(0)]  [RED("maxVelocity")] public CFloat MaxVelocity { get; set; }
		[Ordinal(1)]  [RED("reaction")] public CEnum<gameinteractionsBumpIntensity> Reaction { get; set; }

		public gameinfluenceBumpReactionSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
