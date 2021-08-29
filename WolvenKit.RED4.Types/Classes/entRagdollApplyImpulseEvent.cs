using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollApplyImpulseEvent : redEvent
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
	}
}
