using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questForceVMModule_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("module")] 
		public CString Module
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("components")] 
		public CArray<CName> Components
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public questForceVMModule_NodeTypeParams()
		{
			Reference = new gameEntityReference { Names = new() };
			Components = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
