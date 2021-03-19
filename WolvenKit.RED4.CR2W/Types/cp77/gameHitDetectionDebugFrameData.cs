using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameData : CVariable
	{
		private CBool _t;
		private wCHandle<gameHitRepresentationComponent> _mponent;
		private netTime _tTime;
		private CArray<gameHitDetectionDebugFrameDataShapeEntry> _apes;

		[Ordinal(0)] 
		[RED("t")] 
		public CBool T
		{
			get => GetProperty(ref _t);
			set => SetProperty(ref _t, value);
		}

		[Ordinal(1)] 
		[RED("mponent")] 
		public wCHandle<gameHitRepresentationComponent> Mponent
		{
			get => GetProperty(ref _mponent);
			set => SetProperty(ref _mponent, value);
		}

		[Ordinal(2)] 
		[RED("tTime")] 
		public netTime TTime
		{
			get => GetProperty(ref _tTime);
			set => SetProperty(ref _tTime, value);
		}

		[Ordinal(3)] 
		[RED("apes")] 
		public CArray<gameHitDetectionDebugFrameDataShapeEntry> Apes
		{
			get => GetProperty(ref _apes);
			set => SetProperty(ref _apes, value);
		}

		public gameHitDetectionDebugFrameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
