using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workAnimClip : workIEntry
	{
		private CName _animName;
		private CFloat _blendOutTime;

		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(3)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetProperty(ref _blendOutTime);
			set => SetProperty(ref _blendOutTime, value);
		}

		public workAnimClip()
		{
			_blendOutTime = 0.500000F;
		}
	}
}
