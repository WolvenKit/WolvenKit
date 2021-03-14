using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCanTakeCPOMissionDataPrereq : gameinteractionsInteractionScriptedCondition
	{

		public PlayerCanTakeCPOMissionDataPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
