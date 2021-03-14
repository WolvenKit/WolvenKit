using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpReactionSetting : ISerializable
	{
		[Ordinal(0)] [RED("reaction")] public CEnum<gameinteractionsBumpIntensity> Reaction { get; set; }
		[Ordinal(1)] [RED("maxVelocity")] public CFloat MaxVelocity { get; set; }

		public gameinfluenceBumpReactionSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
