using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectResource : CResource
	{
		[Ordinal(1)] 
		[RED("entryPoints")] 
		public CArray<gameSmartObjectGate> EntryPoints
		{
			get => GetPropertyValue<CArray<gameSmartObjectGate>>();
			set => SetPropertyValue<CArray<gameSmartObjectGate>>(value);
		}

		[Ordinal(2)] 
		[RED("exitPoints")] 
		public CArray<gameSmartObjectGate> ExitPoints
		{
			get => GetPropertyValue<CArray<gameSmartObjectGate>>();
			set => SetPropertyValue<CArray<gameSmartObjectGate>>(value);
		}

		[Ordinal(3)] 
		[RED("bodyTypes")] 
		public CArray<gameBodyTypeAnimationDefinition> BodyTypes
		{
			get => GetPropertyValue<CArray<gameBodyTypeAnimationDefinition>>();
			set => SetPropertyValue<CArray<gameBodyTypeAnimationDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("loopAnimations")] 
		public CArray<gameSmartObjectGate> LoopAnimations
		{
			get => GetPropertyValue<CArray<gameSmartObjectGate>>();
			set => SetPropertyValue<CArray<gameSmartObjectGate>>(value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<gameSmartObjectType> Type
		{
			get => GetPropertyValue<CEnum<gameSmartObjectType>>();
			set => SetPropertyValue<CEnum<gameSmartObjectType>>(value);
		}

		public gameSmartObjectResource()
		{
			EntryPoints = new();
			ExitPoints = new();
			BodyTypes = new();
			LoopAnimations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
