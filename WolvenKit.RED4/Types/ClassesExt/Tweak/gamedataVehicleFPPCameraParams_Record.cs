
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFPPCameraParams_Record
	{
		[RED("enable_rear_view")]
		[REDProperty(IsIgnored = true)]
		public CBool Enable_rear_view
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forward_offset_value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Forward_offset_value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("is_forward_offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Is_forward_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("is_paralax")]
		[REDProperty(IsIgnored = true)]
		public CFloat Is_paralax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("is_pitch_off")]
		[REDProperty(IsIgnored = true)]
		public CFloat Is_pitch_off
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("is_yaw_off")]
		[REDProperty(IsIgnored = true)]
		public CFloat Is_yaw_off
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_offset_vertical")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_offset_vertical
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_pitch_forward_down_ratio")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_pitch_forward_down_ratio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_pitch_forward_offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_pitch_forward_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_yaw_left_offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_yaw_left_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_yaw_left_up_offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_yaw_left_up_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_yaw_offset_active_angle")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_yaw_offset_active_angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_yaw_right_offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_yaw_right_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lookat_yaw_right_up_offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lookat_yaw_right_up_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("paralax_forward_offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Paralax_forward_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("paralax_radius")]
		[REDProperty(IsIgnored = true)]
		public CFloat Paralax_radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rear_view_offset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Rear_view_offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("rear_view_pitch_threshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat Rear_view_pitch_threshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rear_view_yaw_threshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat Rear_view_yaw_threshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("upperbody_pitch_weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Upperbody_pitch_weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("upperbody_yaw_weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Upperbody_yaw_weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
