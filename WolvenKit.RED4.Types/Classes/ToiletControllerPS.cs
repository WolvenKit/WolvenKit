using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToiletControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _flushDuration;
		private CName _flushSFX;
		private CName _flushVFXname;
		private CBool _isFlushing;

		[Ordinal(104)] 
		[RED("flushDuration")] 
		public CFloat FlushDuration
		{
			get => GetProperty(ref _flushDuration);
			set => SetProperty(ref _flushDuration, value);
		}

		[Ordinal(105)] 
		[RED("flushSFX")] 
		public CName FlushSFX
		{
			get => GetProperty(ref _flushSFX);
			set => SetProperty(ref _flushSFX, value);
		}

		[Ordinal(106)] 
		[RED("flushVFXname")] 
		public CName FlushVFXname
		{
			get => GetProperty(ref _flushVFXname);
			set => SetProperty(ref _flushVFXname, value);
		}

		[Ordinal(107)] 
		[RED("isFlushing")] 
		public CBool IsFlushing
		{
			get => GetProperty(ref _isFlushing);
			set => SetProperty(ref _isFlushing, value);
		}
	}
}
