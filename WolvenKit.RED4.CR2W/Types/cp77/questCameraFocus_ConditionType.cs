using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCameraFocus_ConditionType : questISystemConditionType
	{
		private gameEntityReference _objectRef;
		private CFloat _timeInterval;
		private CBool _onScreenTest;
		private CBool _useFrustrumCheck;
		private CFloat _angleTolerance;
		private CBool _inverted;
		private CBool _zoomed;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		[Ordinal(2)] 
		[RED("onScreenTest")] 
		public CBool OnScreenTest
		{
			get => GetProperty(ref _onScreenTest);
			set => SetProperty(ref _onScreenTest, value);
		}

		[Ordinal(3)] 
		[RED("useFrustrumCheck")] 
		public CBool UseFrustrumCheck
		{
			get => GetProperty(ref _useFrustrumCheck);
			set => SetProperty(ref _useFrustrumCheck, value);
		}

		[Ordinal(4)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get => GetProperty(ref _angleTolerance);
			set => SetProperty(ref _angleTolerance, value);
		}

		[Ordinal(5)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(6)] 
		[RED("zoomed")] 
		public CBool Zoomed
		{
			get => GetProperty(ref _zoomed);
			set => SetProperty(ref _zoomed, value);
		}

		public questCameraFocus_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
