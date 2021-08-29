using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTemplateComponentResolveSettings : RedBaseClass
	{
		private CName _componentName;
		private CName _nameParam;
		private CEnum<entTemplateComponentResolveMode> _mode;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("nameParam")] 
		public CName NameParam
		{
			get => GetProperty(ref _nameParam);
			set => SetProperty(ref _nameParam, value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<entTemplateComponentResolveMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
