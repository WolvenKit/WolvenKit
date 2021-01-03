using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameplayConditionBase : IScriptable
	{
		[Ordinal(0)]  [RED("entityID")] public entEntityID EntityID { get; set; }

		public GameplayConditionBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
