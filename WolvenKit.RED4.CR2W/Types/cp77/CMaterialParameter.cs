using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameter : ISerializable
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

		public CMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
