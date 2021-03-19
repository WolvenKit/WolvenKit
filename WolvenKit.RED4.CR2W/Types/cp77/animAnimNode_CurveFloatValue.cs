using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CurveFloatValue : animAnimNode_FloatValue
	{
		private curveData<CFloat> _curveData;
		private animFloatLink _argument;

		[Ordinal(11)] 
		[RED("curveData")] 
		public curveData<CFloat> CurveData
		{
			get => GetProperty(ref _curveData);
			set => SetProperty(ref _curveData, value);
		}

		[Ordinal(12)] 
		[RED("argument")] 
		public animFloatLink Argument
		{
			get => GetProperty(ref _argument);
			set => SetProperty(ref _argument, value);
		}

		public animAnimNode_CurveFloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
