using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentOverrideWrapper : CVariable
	{
		private CName _name;
		private CEnum<AIArgumentType> _type;
		private CHandle<AIArgumentDefinition> _definition;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
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

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<AIArgumentType>) CR2WTypeManager.Create("AIArgumentType", "type", cr2w, this);
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

		[Ordinal(2)] 
		[RED("definition")] 
		public CHandle<AIArgumentDefinition> Definition
		{
			get
			{
				if (_definition == null)
				{
					_definition = (CHandle<AIArgumentDefinition>) CR2WTypeManager.Create("handle:AIArgumentDefinition", "definition", cr2w, this);
				}
				return _definition;
			}
			set
			{
				if (_definition == value)
				{
					return;
				}
				_definition = value;
				PropertySet(this);
			}
		}

		public AIArgumentOverrideWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
