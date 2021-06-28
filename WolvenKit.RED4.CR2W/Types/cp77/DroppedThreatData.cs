using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DroppedThreatData : CVariable
	{
		private wCHandle<entEntity> _threat;
		private Vector4 _position;
		private CFloat _timeStamp;

		[Ordinal(0)] 
		[RED("threat")] 
		public wCHandle<entEntity> Threat
		{
			get => GetProperty(ref _threat);
			set => SetProperty(ref _threat, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		public DroppedThreatData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
