using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollApplyImpulseEvent : redEvent
	{
		private Vector4 _worldImpulsePos;
		private Vector4 _worldImpulseValue;
		private CFloat _influenceRadius;

		[Ordinal(0)] 
		[RED("worldImpulsePos")] 
		public Vector4 WorldImpulsePos
		{
			get => GetProperty(ref _worldImpulsePos);
			set => SetProperty(ref _worldImpulsePos, value);
		}

		[Ordinal(1)] 
		[RED("worldImpulseValue")] 
		public Vector4 WorldImpulseValue
		{
			get => GetProperty(ref _worldImpulseValue);
			set => SetProperty(ref _worldImpulseValue, value);
		}

		[Ordinal(2)] 
		[RED("influenceRadius")] 
		public CFloat InfluenceRadius
		{
			get => GetProperty(ref _influenceRadius);
			set => SetProperty(ref _influenceRadius, value);
		}

		public entRagdollApplyImpulseEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
