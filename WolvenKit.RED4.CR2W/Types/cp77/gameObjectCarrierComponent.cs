using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameObjectCarrierComponent : entIComponent
	{
		[Ordinal(3)] [RED("objectToSpawn")] public TweakDBID ObjectToSpawn { get; set; }

		public gameObjectCarrierComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
