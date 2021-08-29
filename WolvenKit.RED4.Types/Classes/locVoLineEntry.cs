using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoLineEntry : RedBaseClass
	{
		private CRUID _stringId;
		private CResourceAsyncReference<locVoResource> _femaleResPath;
		private CResourceAsyncReference<locVoResource> _maleResPath;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("femaleResPath")] 
		public CResourceAsyncReference<locVoResource> FemaleResPath
		{
			get => GetProperty(ref _femaleResPath);
			set => SetProperty(ref _femaleResPath, value);
		}

		[Ordinal(2)] 
		[RED("maleResPath")] 
		public CResourceAsyncReference<locVoResource> MaleResPath
		{
			get => GetProperty(ref _maleResPath);
			set => SetProperty(ref _maleResPath, value);
		}
	}
}
