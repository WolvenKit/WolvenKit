using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_Scripted : gameEffectPostAction
	{

		public gameEffectPostAction_Scripted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
