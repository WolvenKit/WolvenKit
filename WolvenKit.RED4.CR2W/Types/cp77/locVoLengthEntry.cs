using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoLengthEntry : CVariable
	{
		private CRUID _stringId;
		private CFloat _femaleLength;
		private CFloat _maleLength;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("femaleLength")] 
		public CFloat FemaleLength
		{
			get => GetProperty(ref _femaleLength);
			set => SetProperty(ref _femaleLength, value);
		}

		[Ordinal(2)] 
		[RED("maleLength")] 
		public CFloat MaleLength
		{
			get => GetProperty(ref _maleLength);
			set => SetProperty(ref _maleLength, value);
		}

		public locVoLengthEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
