using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayCameraData : IScriptable
	{
		[Ordinal(0)] 
		[RED("is_forward_offset")] 
		public CFloat Is_forward_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("upperbody_pitch_weight")] 
		public CFloat Upperbody_pitch_weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("forward_offset_value")] 
		public CFloat Forward_offset_value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("upperbody_yaw_weight")] 
		public CFloat Upperbody_yaw_weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("is_pitch_off")] 
		public CFloat Is_pitch_off
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("is_yaw_off")] 
		public CFloat Is_yaw_off
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GameplayCameraData()
		{
			Is_forward_offset = 1.000000F;
			Forward_offset_value = 0.200000F;
		}
	}
}
