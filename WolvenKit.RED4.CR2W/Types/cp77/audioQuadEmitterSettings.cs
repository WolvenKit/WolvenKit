using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioQuadEmitterSettings : CVariable
	{
		private CBool _enabled;
		private CBool _interleaved;
		private CFloat _radius;
		private Vector3 _offset;
		private CFloat _angle;
		private CArrayFixedSize<audioAudEventStruct> _events;

		[Ordinal(0)] 
		[RED("Enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("Interleaved")] 
		public CBool Interleaved
		{
			get => GetProperty(ref _interleaved);
			set => SetProperty(ref _interleaved, value);
		}

		[Ordinal(2)] 
		[RED("Radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(3)] 
		[RED("Offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(4)] 
		[RED("Angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(5)] 
		[RED("Events", 4)] 
		public CArrayFixedSize<audioAudEventStruct> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		public audioQuadEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
