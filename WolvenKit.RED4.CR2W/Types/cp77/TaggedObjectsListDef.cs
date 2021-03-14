using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TaggedObjectsListDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _taggedObjectsList;

		[Ordinal(0)] 
		[RED("taggedObjectsList")] 
		public gamebbScriptID_Variant TaggedObjectsList
		{
			get
			{
				if (_taggedObjectsList == null)
				{
					_taggedObjectsList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "taggedObjectsList", cr2w, this);
				}
				return _taggedObjectsList;
			}
			set
			{
				if (_taggedObjectsList == value)
				{
					return;
				}
				_taggedObjectsList = value;
				PropertySet(this);
			}
		}

		public TaggedObjectsListDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
