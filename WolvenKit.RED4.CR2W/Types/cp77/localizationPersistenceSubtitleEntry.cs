using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleEntry : CVariable
	{
		private CRUID _stringId;
		private CString _femaleVariant;
		private CString _maleVariant;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("femaleVariant")] 
		public CString FemaleVariant
		{
			get => GetProperty(ref _femaleVariant);
			set => SetProperty(ref _femaleVariant, value);
		}

		[Ordinal(2)] 
		[RED("maleVariant")] 
		public CString MaleVariant
		{
			get => GetProperty(ref _maleVariant);
			set => SetProperty(ref _maleVariant, value);
		}

		public localizationPersistenceSubtitleEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
