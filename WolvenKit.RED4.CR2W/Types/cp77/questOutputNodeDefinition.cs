using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOutputNodeDefinition : questIONodeDefinition
	{
		private CEnum<questExitType> _type;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<questExitType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questExitType>) CR2WTypeManager.Create("questExitType", "type", cr2w, this);
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

		public questOutputNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
