using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questISceneManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questISceneManagerNodeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questISceneManagerNodeType>) CR2WTypeManager.Create("handle:questISceneManagerNodeType", "type", cr2w, this);
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

		public questSceneManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
