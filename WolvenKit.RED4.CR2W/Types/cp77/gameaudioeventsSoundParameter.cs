using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSoundParameter : redEvent
	{
		private CName _parameterName;
		private CFloat _parameterValue;

		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetProperty(ref _parameterName);
			set => SetProperty(ref _parameterName, value);
		}

		[Ordinal(1)] 
		[RED("parameterValue")] 
		public CFloat ParameterValue
		{
			get => GetProperty(ref _parameterValue);
			set => SetProperty(ref _parameterValue, value);
		}

		public gameaudioeventsSoundParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
