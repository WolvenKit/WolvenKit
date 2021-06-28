using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToiletControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _flushDuration;
		private CName _flushSFX;
		private CName _flushVFXname;
		private CBool _isFlushing;

		[Ordinal(103)] 
		[RED("flushDuration")] 
		public CFloat FlushDuration
		{
			get => GetProperty(ref _flushDuration);
			set => SetProperty(ref _flushDuration, value);
		}

		[Ordinal(104)] 
		[RED("flushSFX")] 
		public CName FlushSFX
		{
			get => GetProperty(ref _flushSFX);
			set => SetProperty(ref _flushSFX, value);
		}

		[Ordinal(105)] 
		[RED("flushVFXname")] 
		public CName FlushVFXname
		{
			get => GetProperty(ref _flushVFXname);
			set => SetProperty(ref _flushVFXname, value);
		}

		[Ordinal(106)] 
		[RED("isFlushing")] 
		public CBool IsFlushing
		{
			get => GetProperty(ref _isFlushing);
			set => SetProperty(ref _isFlushing, value);
		}

		public ToiletControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
