using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMappinManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<gameJournalPath> _path;
		private CBool _disablePreviousMappins;

		[Ordinal(2)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("disablePreviousMappins")] 
		public CBool DisablePreviousMappins
		{
			get
			{
				if (_disablePreviousMappins == null)
				{
					_disablePreviousMappins = (CBool) CR2WTypeManager.Create("Bool", "disablePreviousMappins", cr2w, this);
				}
				return _disablePreviousMappins;
			}
			set
			{
				if (_disablePreviousMappins == value)
				{
					return;
				}
				_disablePreviousMappins = value;
				PropertySet(this);
			}
		}

		public questMappinManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
