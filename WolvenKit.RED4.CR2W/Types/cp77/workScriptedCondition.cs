using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workScriptedCondition : workIWorkspotCondition
	{
		private CHandle<workIScriptedCondition> _script;

		[Ordinal(2)] 
		[RED("script")] 
		public CHandle<workIScriptedCondition> Script
		{
			get
			{
				if (_script == null)
				{
					_script = (CHandle<workIScriptedCondition>) CR2WTypeManager.Create("handle:workIScriptedCondition", "script", cr2w, this);
				}
				return _script;
			}
			set
			{
				if (_script == value)
				{
					return;
				}
				_script = value;
				PropertySet(this);
			}
		}

		public workScriptedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
