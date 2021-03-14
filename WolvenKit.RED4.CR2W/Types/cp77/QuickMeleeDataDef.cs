using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _nPCHit;

		[Ordinal(0)] 
		[RED("NPCHit")] 
		public gamebbScriptID_Bool NPCHit
		{
			get
			{
				if (_nPCHit == null)
				{
					_nPCHit = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "NPCHit", cr2w, this);
				}
				return _nPCHit;
			}
			set
			{
				if (_nPCHit == value)
				{
					return;
				}
				_nPCHit = value;
				PropertySet(this);
			}
		}

		public QuickMeleeDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
