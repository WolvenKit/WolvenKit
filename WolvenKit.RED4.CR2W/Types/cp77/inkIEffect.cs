using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkIEffect : ISerializable
	{
		[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(1)] [RED("effectName")] public CName EffectName { get; set; }

		public inkIEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
