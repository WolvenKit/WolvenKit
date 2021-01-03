using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameObjectCarrierComponent : entIComponent
	{
		[Ordinal(0)]  [RED("objectToSpawn")] public TweakDBID ObjectToSpawn { get; set; }

		public gameObjectCarrierComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
