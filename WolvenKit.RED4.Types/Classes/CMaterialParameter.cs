using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameter : ISerializable
	{
		private CName _parameterName;
		private CUInt32 _register;

		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetProperty(ref _parameterName);
			set => SetProperty(ref _parameterName, value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CUInt32 Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}
	}
}
