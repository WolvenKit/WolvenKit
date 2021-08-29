using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaterialUsedParameter : RedBaseClass
	{
		private CName _name;
		private CUInt8 _register;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CUInt8 Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}
	}
}
