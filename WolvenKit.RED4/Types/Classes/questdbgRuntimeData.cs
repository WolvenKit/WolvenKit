using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questdbgRuntimeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("version")] 
		public CUInt64 Version
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("questResourcePathHash")] 
		public CUInt64 QuestResourcePathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("selectedBlockId")] 
		public CUInt64 SelectedBlockId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("objects")] 
		public CArray<CHandle<ISerializable>> Objects
		{
			get => GetPropertyValue<CArray<CHandle<ISerializable>>>();
			set => SetPropertyValue<CArray<CHandle<ISerializable>>>(value);
		}

		public questdbgRuntimeData()
		{
			SelectedBlockId = long.MaxValue;
			Objects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
