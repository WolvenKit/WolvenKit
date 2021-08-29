using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questForceVMModule_NodeTypeParams : RedBaseClass
	{
		private gameEntityReference _reference;
		private CString _module;
		private CArray<CName> _components;

		[Ordinal(0)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		[Ordinal(1)] 
		[RED("module")] 
		public CString Module
		{
			get => GetProperty(ref _module);
			set => SetProperty(ref _module, value);
		}

		[Ordinal(2)] 
		[RED("components")] 
		public CArray<CName> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}
	}
}
