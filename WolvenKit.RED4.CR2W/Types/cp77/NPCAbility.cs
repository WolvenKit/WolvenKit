using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCAbility : CVariable
	{
		private CString _abilityName;

		[Ordinal(0)] 
		[RED("abilityName")] 
		public CString AbilityName
		{
			get
			{
				if (_abilityName == null)
				{
					_abilityName = (CString) CR2WTypeManager.Create("String", "abilityName", cr2w, this);
				}
				return _abilityName;
			}
			set
			{
				if (_abilityName == value)
				{
					return;
				}
				_abilityName = value;
				PropertySet(this);
			}
		}

		public NPCAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
