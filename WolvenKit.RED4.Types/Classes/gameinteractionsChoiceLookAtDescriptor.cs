using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoiceLookAtDescriptor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameinteractionsChoiceLookAtType> Type
		{
			get => GetPropertyValue<CEnum<gameinteractionsChoiceLookAtType>>();
			set => SetPropertyValue<CEnum<gameinteractionsChoiceLookAtType>>(value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("orbId")] 
		public gameinteractionsOrbID OrbId
		{
			get => GetPropertyValue<gameinteractionsOrbID>();
			set => SetPropertyValue<gameinteractionsOrbID>(value);
		}

		public gameinteractionsChoiceLookAtDescriptor()
		{
			Offset = new();
			OrbId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
