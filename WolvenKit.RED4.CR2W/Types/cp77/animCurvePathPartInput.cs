using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathPartInput : CVariable
	{
		private CFloat _curveLengthStart;
		private CFloat _curveLengthEnd;
		private CName _controllerName;
		private CName _eventNameStart;
		private CName _eventNameEnd;
		private CFloat _startBlendTime;

		[Ordinal(0)] 
		[RED("curveLengthStart")] 
		public CFloat CurveLengthStart
		{
			get => GetProperty(ref _curveLengthStart);
			set => SetProperty(ref _curveLengthStart, value);
		}

		[Ordinal(1)] 
		[RED("curveLengthEnd")] 
		public CFloat CurveLengthEnd
		{
			get => GetProperty(ref _curveLengthEnd);
			set => SetProperty(ref _curveLengthEnd, value);
		}

		[Ordinal(2)] 
		[RED("controllerName")] 
		public CName ControllerName
		{
			get => GetProperty(ref _controllerName);
			set => SetProperty(ref _controllerName, value);
		}

		[Ordinal(3)] 
		[RED("eventNameStart")] 
		public CName EventNameStart
		{
			get => GetProperty(ref _eventNameStart);
			set => SetProperty(ref _eventNameStart, value);
		}

		[Ordinal(4)] 
		[RED("eventNameEnd")] 
		public CName EventNameEnd
		{
			get => GetProperty(ref _eventNameEnd);
			set => SetProperty(ref _eventNameEnd, value);
		}

		[Ordinal(5)] 
		[RED("startBlendTime")] 
		public CFloat StartBlendTime
		{
			get => GetProperty(ref _startBlendTime);
			set => SetProperty(ref _startBlendTime, value);
		}

		public animCurvePathPartInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
