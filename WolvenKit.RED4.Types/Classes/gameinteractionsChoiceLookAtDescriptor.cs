using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceLookAtDescriptor : RedBaseClass
	{
		private CEnum<gameinteractionsChoiceLookAtType> _type;
		private CName _slotName;
		private Vector3 _offset;
		private gameinteractionsOrbID _orbId;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameinteractionsChoiceLookAtType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("orbId")] 
		public gameinteractionsOrbID OrbId
		{
			get => GetProperty(ref _orbId);
			set => SetProperty(ref _orbId, value);
		}
	}
}
