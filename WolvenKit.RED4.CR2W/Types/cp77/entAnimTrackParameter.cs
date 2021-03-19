using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimTrackParameter : CVariable
	{
		private CName _animTrackName;
		private CName _parameterName;
		private CFloat _defaultValue;

		[Ordinal(0)] 
		[RED("animTrackName")] 
		public CName AnimTrackName
		{
			get => GetProperty(ref _animTrackName);
			set => SetProperty(ref _animTrackName, value);
		}

		[Ordinal(1)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetProperty(ref _parameterName);
			set => SetProperty(ref _parameterName, value);
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public entAnimTrackParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
