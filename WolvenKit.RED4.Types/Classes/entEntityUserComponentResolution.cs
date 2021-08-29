using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityUserComponentResolution : RedBaseClass
	{
		private CRUID _id;
		private CResourceAsyncReference<entEntityTemplate> _include;
		private CEnum<entEntityUserComponentResolutionMode> _mode;

		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("include")] 
		public CResourceAsyncReference<entEntityTemplate> Include
		{
			get => GetProperty(ref _include);
			set => SetProperty(ref _include, value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<entEntityUserComponentResolutionMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
