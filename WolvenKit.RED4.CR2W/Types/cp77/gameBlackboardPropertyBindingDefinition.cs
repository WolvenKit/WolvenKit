using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardPropertyBindingDefinition : CVariable
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

		public gameBlackboardPropertyBindingDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
