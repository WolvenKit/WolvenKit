using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceReference<gameSmartObjectResource> Resource
		{
			get => GetPropertyValue<CResourceReference<gameSmartObjectResource>>();
			set => SetPropertyValue<CResourceReference<gameSmartObjectResource>>(value);
		}

		[Ordinal(1)] 
		[RED("actions")] 
		public CArray<CName> Actions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("motionActionDatabase")] 
		public CResourceReference<animActionAnimDatabase> MotionActionDatabase
		{
			get => GetPropertyValue<CResourceReference<animActionAnimDatabase>>();
			set => SetPropertyValue<CResourceReference<animActionAnimDatabase>>(value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("overrideGeneratedParameters")] 
		public CBool OverrideGeneratedParameters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSmartObjectDefinition()
		{
			Actions = new() { "CoverGetOut" };
			MotionActionDatabase = new CResourceReference<animActionAnimDatabase>(4960121789495904435);
			Enabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
