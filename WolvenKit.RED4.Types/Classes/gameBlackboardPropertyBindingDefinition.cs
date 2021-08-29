using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBlackboardPropertyBindingDefinition : RedBaseClass
	{
		private gameBlackboardSerializableID _serializableID;
		private CArray<CName> _propertyPath;
		private CName _propertyType;

		[Ordinal(0)] 
		[RED("serializableID")] 
		public gameBlackboardSerializableID SerializableID
		{
			get => GetProperty(ref _serializableID);
			set => SetProperty(ref _serializableID, value);
		}

		[Ordinal(1)] 
		[RED("propertyPath")] 
		public CArray<CName> PropertyPath
		{
			get => GetProperty(ref _propertyPath);
			set => SetProperty(ref _propertyPath, value);
		}

		[Ordinal(2)] 
		[RED("propertyType")] 
		public CName PropertyType
		{
			get => GetProperty(ref _propertyType);
			set => SetProperty(ref _propertyType, value);
		}
	}
}
