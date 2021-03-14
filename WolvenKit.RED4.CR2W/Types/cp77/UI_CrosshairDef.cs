using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CrosshairDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _enemyNeutralized;

		[Ordinal(0)] 
		[RED("EnemyNeutralized")] 
		public gamebbScriptID_Variant EnemyNeutralized
		{
			get
			{
				if (_enemyNeutralized == null)
				{
					_enemyNeutralized = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "EnemyNeutralized", cr2w, this);
				}
				return _enemyNeutralized;
			}
			set
			{
				if (_enemyNeutralized == value)
				{
					return;
				}
				_enemyNeutralized = value;
				PropertySet(this);
			}
		}

		public UI_CrosshairDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
