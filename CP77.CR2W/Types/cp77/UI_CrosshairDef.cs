using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_CrosshairDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("EnemyNeutralized")] public gamebbScriptID_Variant EnemyNeutralized { get; set; }

		public UI_CrosshairDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
