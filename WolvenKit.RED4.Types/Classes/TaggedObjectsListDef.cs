using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TaggedObjectsListDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("taggedObjectsList")] 
		public gamebbScriptID_Variant TaggedObjectsList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public TaggedObjectsListDef()
		{
			TaggedObjectsList = new();
		}
	}
}
