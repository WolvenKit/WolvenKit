using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TaggedObjectsListDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _taggedObjectsList;

		[Ordinal(0)] 
		[RED("taggedObjectsList")] 
		public gamebbScriptID_Variant TaggedObjectsList
		{
			get => GetProperty(ref _taggedObjectsList);
			set => SetProperty(ref _taggedObjectsList, value);
		}
	}
}
