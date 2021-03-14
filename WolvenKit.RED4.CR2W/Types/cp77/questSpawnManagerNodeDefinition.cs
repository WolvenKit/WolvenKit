using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CArray<questSpawnManagerNodeActionEntry> _actions;

		[Ordinal(2)] 
		[RED("actions")] 
		public CArray<questSpawnManagerNodeActionEntry> Actions
		{
			get
			{
				if (_actions == null)
				{
					_actions = (CArray<questSpawnManagerNodeActionEntry>) CR2WTypeManager.Create("array:questSpawnManagerNodeActionEntry", "actions", cr2w, this);
				}
				return _actions;
			}
			set
			{
				if (_actions == value)
				{
					return;
				}
				_actions = value;
				PropertySet(this);
			}
		}

		public questSpawnManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
