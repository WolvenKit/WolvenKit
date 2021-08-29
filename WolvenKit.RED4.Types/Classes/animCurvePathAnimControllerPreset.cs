using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animCurvePathAnimControllerPreset : RedBaseClass
	{
		private CName _name;
		private CName _leftAnimationName;
		private CName _forwardAnimationName;
		private CName _rightAnimationName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("leftAnimationName")] 
		public CName LeftAnimationName
		{
			get => GetProperty(ref _leftAnimationName);
			set => SetProperty(ref _leftAnimationName, value);
		}

		[Ordinal(2)] 
		[RED("forwardAnimationName")] 
		public CName ForwardAnimationName
		{
			get => GetProperty(ref _forwardAnimationName);
			set => SetProperty(ref _forwardAnimationName, value);
		}

		[Ordinal(3)] 
		[RED("rightAnimationName")] 
		public CName RightAnimationName
		{
			get => GetProperty(ref _rightAnimationName);
			set => SetProperty(ref _rightAnimationName, value);
		}
	}
}
