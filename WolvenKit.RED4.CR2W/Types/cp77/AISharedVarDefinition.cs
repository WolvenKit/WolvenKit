using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISharedVarDefinition : CVariable
	{
		private CEnum<AIESharedVarDefinitionType> _type;
		private LibTreeSharedVarRegistrationName _name;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<AIESharedVarDefinitionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<AIESharedVarDefinitionType>) CR2WTypeManager.Create("AIESharedVarDefinitionType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("name")] 
		public LibTreeSharedVarRegistrationName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (LibTreeSharedVarRegistrationName) CR2WTypeManager.Create("LibTreeSharedVarRegistrationName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		public AISharedVarDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
