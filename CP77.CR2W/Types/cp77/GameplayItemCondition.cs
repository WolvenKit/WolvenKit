using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameplayItemCondition : GameplayConditionBase
	{
		[Ordinal(0)]  [RED("itemToCheck")] public TweakDBID ItemToCheck { get; set; }

		public GameplayItemCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
