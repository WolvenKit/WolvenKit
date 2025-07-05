using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerNPCHeaderGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("skullIndicator")] 
		public inkWidgetReference SkullIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("archetypeIcon")] 
		public inkImageWidgetReference ArchetypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("levelCallbackID")] 
		public CHandle<redCallbackObject> LevelCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("nameCallbackID")] 
		public CHandle<redCallbackObject> NameCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("attitudeCallbackID")] 
		public CHandle<redCallbackObject> AttitudeCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("archtypeCallbackID")] 
		public CHandle<redCallbackObject> ArchtypeCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("isValidName")] 
		public CBool IsValidName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isValidRarity")] 
		public CBool IsValidRarity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isValidArchetype")] 
		public CBool IsValidArchetype
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerNPCHeaderGameController()
		{
			NameText = new inkTextWidgetReference();
			SkullIndicator = new inkWidgetReference();
			ArchetypeIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
