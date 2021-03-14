using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeType : questIRetNodeType
	{
		private CEnum<populationSpawnerObjectCtrlAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<populationSpawnerObjectCtrlAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<populationSpawnerObjectCtrlAction>) CR2WTypeManager.Create("populationSpawnerObjectCtrlAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public questSpawnManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
