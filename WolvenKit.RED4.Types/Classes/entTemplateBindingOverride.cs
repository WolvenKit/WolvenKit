using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTemplateBindingOverride : RedBaseClass
	{
		private CName _componentName;
		private CName _propertyName;
		private CHandle<entIBinding> _binding;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("propertyName")] 
		public CName PropertyName
		{
			get => GetProperty(ref _propertyName);
			set => SetProperty(ref _propertyName, value);
		}

		[Ordinal(2)] 
		[RED("binding")] 
		public CHandle<entIBinding> Binding
		{
			get => GetProperty(ref _binding);
			set => SetProperty(ref _binding, value);
		}
	}
}
