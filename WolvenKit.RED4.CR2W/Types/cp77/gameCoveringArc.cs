using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCoveringArc : CVariable
	{
		private CFloat _leftAngle;
		private CFloat _rightAngle;
		private CFloat _verticalAngle;

		[Ordinal(0)] 
		[RED("leftAngle")] 
		public CFloat LeftAngle
		{
			get => GetProperty(ref _leftAngle);
			set => SetProperty(ref _leftAngle, value);
		}

		[Ordinal(1)] 
		[RED("rightAngle")] 
		public CFloat RightAngle
		{
			get => GetProperty(ref _rightAngle);
			set => SetProperty(ref _rightAngle, value);
		}

		[Ordinal(2)] 
		[RED("verticalAngle")] 
		public CFloat VerticalAngle
		{
			get => GetProperty(ref _verticalAngle);
			set => SetProperty(ref _verticalAngle, value);
		}

		public gameCoveringArc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
