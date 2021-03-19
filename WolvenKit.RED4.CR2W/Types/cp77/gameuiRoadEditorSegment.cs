using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorSegment : CVariable
	{
		private CUInt32 _length;
		private CFloat _curve;
		private CBool _hasCheckpoint;
		private CArray<gameuiRoadEditorObstacleSettings> _obstacleSettings;
		private CArray<gameuiRoadEditorDecorationSettings> _decorationSettings;

		[Ordinal(0)] 
		[RED("length")] 
		public CUInt32 Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}

		[Ordinal(1)] 
		[RED("curve")] 
		public CFloat Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		[Ordinal(2)] 
		[RED("hasCheckpoint")] 
		public CBool HasCheckpoint
		{
			get => GetProperty(ref _hasCheckpoint);
			set => SetProperty(ref _hasCheckpoint, value);
		}

		[Ordinal(3)] 
		[RED("obstacleSettings")] 
		public CArray<gameuiRoadEditorObstacleSettings> ObstacleSettings
		{
			get => GetProperty(ref _obstacleSettings);
			set => SetProperty(ref _obstacleSettings, value);
		}

		[Ordinal(4)] 
		[RED("decorationSettings")] 
		public CArray<gameuiRoadEditorDecorationSettings> DecorationSettings
		{
			get => GetProperty(ref _decorationSettings);
			set => SetProperty(ref _decorationSettings, value);
		}

		public gameuiRoadEditorSegment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
