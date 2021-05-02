using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntityReference : CVariable
	{
		private CEnum<gameEntityReferenceType> _type;
		private NodeRef _reference;
		private CArray<CName> _names;
		private CName _slotName;
		private CName _sceneActorContextName;
		private CName _dynamicEntityUniqueName;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameEntityReferenceType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(4)] 
		[RED("sceneActorContextName")] 
		public CName SceneActorContextName
		{
			get => GetProperty(ref _sceneActorContextName);
			set => SetProperty(ref _sceneActorContextName, value);
		}

		[Ordinal(5)] 
		[RED("dynamicEntityUniqueName")] 
		public CName DynamicEntityUniqueName
		{
			get => GetProperty(ref _dynamicEntityUniqueName);
			set => SetProperty(ref _dynamicEntityUniqueName, value);
		}

		public gameEntityReference(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
