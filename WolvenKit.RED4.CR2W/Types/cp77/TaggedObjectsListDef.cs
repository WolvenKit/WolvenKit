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
			get => GetProperty(ref _taggedObjectsList);
			set => SetProperty(ref _taggedObjectsList, value);
		}

		public TaggedObjectsListDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
