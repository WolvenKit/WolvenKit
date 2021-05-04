using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeParameter : CVariable
	{
		private CName _parameterName;
		private CUInt16 _parameterId;
		private CEnum<LibTreeEParameterType> _parameterType;
		private CVariant _value;

		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetProperty(ref _parameterName);
			set => SetProperty(ref _parameterName, value);
		}

		[Ordinal(1)] 
		[RED("parameterId")] 
		public CUInt16 ParameterId
		{
			get => GetProperty(ref _parameterId);
			set => SetProperty(ref _parameterId, value);
		}

		[Ordinal(2)] 
		[RED("parameterType")] 
		public CEnum<LibTreeEParameterType> ParameterType
		{
			get => GetProperty(ref _parameterType);
			set => SetProperty(ref _parameterType, value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public LibTreeParameter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
