using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_FullControl : animLookAtPreset
	{
		private animLookAtLimits _limits;
		private CFloat _eyesSuppress;
		private CInt32 _eyesMode;
		private CFloat _headSuppress;
		private CInt32 _headMode;
		private CFloat _headSquareScale;
		private CFloat _chestSuppress;
		private CInt32 _chestMode;
		private CFloat _chestSquareScale;

		[Ordinal(0)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get => GetProperty(ref _limits);
			set => SetProperty(ref _limits, value);
		}

		[Ordinal(1)] 
		[RED("eyesSuppress")] 
		public CFloat EyesSuppress
		{
			get => GetProperty(ref _eyesSuppress);
			set => SetProperty(ref _eyesSuppress, value);
		}

		[Ordinal(2)] 
		[RED("eyesMode")] 
		public CInt32 EyesMode
		{
			get => GetProperty(ref _eyesMode);
			set => SetProperty(ref _eyesMode, value);
		}

		[Ordinal(3)] 
		[RED("headSuppress")] 
		public CFloat HeadSuppress
		{
			get => GetProperty(ref _headSuppress);
			set => SetProperty(ref _headSuppress, value);
		}

		[Ordinal(4)] 
		[RED("headMode")] 
		public CInt32 HeadMode
		{
			get => GetProperty(ref _headMode);
			set => SetProperty(ref _headMode, value);
		}

		[Ordinal(5)] 
		[RED("headSquareScale")] 
		public CFloat HeadSquareScale
		{
			get => GetProperty(ref _headSquareScale);
			set => SetProperty(ref _headSquareScale, value);
		}

		[Ordinal(6)] 
		[RED("chestSuppress")] 
		public CFloat ChestSuppress
		{
			get => GetProperty(ref _chestSuppress);
			set => SetProperty(ref _chestSuppress, value);
		}

		[Ordinal(7)] 
		[RED("chestMode")] 
		public CInt32 ChestMode
		{
			get => GetProperty(ref _chestMode);
			set => SetProperty(ref _chestMode, value);
		}

		[Ordinal(8)] 
		[RED("chestSquareScale")] 
		public CFloat ChestSquareScale
		{
			get => GetProperty(ref _chestSquareScale);
			set => SetProperty(ref _chestSquareScale, value);
		}

		public animLookAtPreset_FullControl(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
