using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceOnScreenEntry : CVariable
	{
		private CUInt64 _primaryKey;
		private CString _secondaryKey;
		private CString _femaleVariant;
		private CString _maleVariant;

		[Ordinal(0)] 
		[RED("primaryKey")] 
		public CUInt64 PrimaryKey
		{
			get => GetProperty(ref _primaryKey);
			set => SetProperty(ref _primaryKey, value);
		}

		[Ordinal(1)] 
		[RED("secondaryKey")] 
		public CString SecondaryKey
		{
			get => GetProperty(ref _secondaryKey);
			set => SetProperty(ref _secondaryKey, value);
		}

		[Ordinal(2)] 
		[RED("femaleVariant")] 
		public CString FemaleVariant
		{
			get => GetProperty(ref _femaleVariant);
			set => SetProperty(ref _femaleVariant, value);
		}

		[Ordinal(3)] 
		[RED("maleVariant")] 
		public CString MaleVariant
		{
			get => GetProperty(ref _maleVariant);
			set => SetProperty(ref _maleVariant, value);
		}

		public localizationPersistenceOnScreenEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
