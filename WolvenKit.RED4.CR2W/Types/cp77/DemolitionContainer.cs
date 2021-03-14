using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DemolitionContainer : BaseSkillCheckContainer
	{
		private CHandle<DemolitionSkillCheck> _demolitionCheck;

		[Ordinal(3)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get
			{
				if (_demolitionCheck == null)
				{
					_demolitionCheck = (CHandle<DemolitionSkillCheck>) CR2WTypeManager.Create("handle:DemolitionSkillCheck", "demolitionCheck", cr2w, this);
				}
				return _demolitionCheck;
			}
			set
			{
				if (_demolitionCheck == value)
				{
					return;
				}
				_demolitionCheck = value;
				PropertySet(this);
			}
		}

		public DemolitionContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
