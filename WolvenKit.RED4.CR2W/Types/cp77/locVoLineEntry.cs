using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoLineEntry : CVariable
	{
		private CRUID _stringId;
		private raRef<locVoResource> _femaleResPath;
		private raRef<locVoResource> _maleResPath;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("femaleResPath")] 
		public raRef<locVoResource> FemaleResPath
		{
			get => GetProperty(ref _femaleResPath);
			set => SetProperty(ref _femaleResPath, value);
		}

		[Ordinal(2)] 
		[RED("maleResPath")] 
		public raRef<locVoResource> MaleResPath
		{
			get => GetProperty(ref _maleResPath);
			set => SetProperty(ref _maleResPath, value);
		}

		public locVoLineEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
