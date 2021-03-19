using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimuliEffectEvent : redEvent
	{
		private CName _stimuliEventName;
		private Vector4 _targetPoint;

		[Ordinal(0)] 
		[RED("stimuliEventName")] 
		public CName StimuliEventName
		{
			get => GetProperty(ref _stimuliEventName);
			set => SetProperty(ref _stimuliEventName, value);
		}

		[Ordinal(1)] 
		[RED("targetPoint")] 
		public Vector4 TargetPoint
		{
			get => GetProperty(ref _targetPoint);
			set => SetProperty(ref _targetPoint, value);
		}

		public StimuliEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
