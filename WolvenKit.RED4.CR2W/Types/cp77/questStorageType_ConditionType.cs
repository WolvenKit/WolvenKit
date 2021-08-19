using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStorageType_ConditionType : questISystemConditionType
	{
		private CEnum<questStorage> _storage;

		[Ordinal(0)] 
		[RED("storage")] 
		public CEnum<questStorage> Storage
		{
			get => GetProperty(ref _storage);
			set => SetProperty(ref _storage, value);
		}

		public questStorageType_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
