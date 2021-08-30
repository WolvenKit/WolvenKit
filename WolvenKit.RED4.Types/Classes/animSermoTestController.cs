using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSermoTestController : RedBaseClass
	{
		private CFloat _faceEnvelope;
		private CFloat _upperFace;
		private CFloat _lowerFace;
		private CFloat _lipSyncEnvelope;
		private CFloat _lipSyncLeftEnvelope;
		private CFloat _lipSyncRightEnvelope;
		private CFloat _jaliJaw;
		private CFloat _jaliLips;
		private CFloat _muzzleLips;
		private CFloat _muzzleEyes;
		private CFloat _muzzleBrows;
		private CFloat _muzzleEyeDirections;
		private CFloat _eye_l_blink;
		private CFloat _eye_r_blink;
		private CFloat _eye_l_widen;
		private CFloat _eye_r_widen;
		private CFloat _eye_l_dir_up;
		private CFloat _eye_l_dir_dn;
		private CFloat _eye_l_dir_in;
		private CFloat _eye_l_dir_out;
		private CFloat _eye_r_dir_up;
		private CFloat _eye_r_dir_dn;
		private CFloat _eye_r_dir_in;
		private CFloat _eye_r_dir_out;
		private CFloat _eye_l_pupil_narrow;
		private CFloat _eye_r_pupil_narrow;
		private CFloat _eye_l_pupil_wide;
		private CFloat _eye_r_pupil_wide;
		private CFloat _eye_l_brows_raise_in;
		private CFloat _eye_r_brows_raise_in;
		private CFloat _eye_l_brows_raise_out;
		private CFloat _eye_r_brows_raise_out;
		private CFloat _eye_l_brows_lower;
		private CFloat _eye_r_brows_lower;
		private CFloat _eye_l_brows_lateral;
		private CFloat _eye_r_brows_lateral;
		private CFloat _eye_l_oculi_squint_inner;
		private CFloat _eye_r_oculi_squint_inner;
		private CFloat _eye_l_oculi_squint_outer_lower;
		private CFloat _eye_r_oculi_squint_outer_lower;
		private CFloat _eye_l_oculi_squint_outer_upper;
		private CFloat _eye_r_oculi_squint_outer_upper;
		private CFloat _nose_l_compress;
		private CFloat _nose_r_compress;
		private CFloat _nose_l_breathe_in;
		private CFloat _nose_r_breathe_in;
		private CFloat _nose_l_breathe_out;
		private CFloat _nose_r_breathe_out;
		private CFloat _nose_l_snear;
		private CFloat _nose_r_snear;
		private CFloat _lips_l_nasolabialDeepener;
		private CFloat _lips_r_nasolabialDeepener;
		private CFloat _lips_l_upper_raise;
		private CFloat _lips_r_upper_raise;
		private CFloat _lips_l_pull;
		private CFloat _lips_r_pull;
		private CFloat _lips_l_corner_up;
		private CFloat _lips_r_corner_up;
		private CFloat _lips_l_corner_wide;
		private CFloat _lips_r_corner_wide;
		private CFloat _lips_l_corner_stretch;
		private CFloat _lips_r_corner_stretch;
		private CFloat _lips_l_stretch;
		private CFloat _lips_r_stretch;
		private CFloat _lips_l_corner_sharp_up;
		private CFloat _lips_r_corner_sharp_up;
		private CFloat _lips_suck_up;
		private CFloat _lips_suck_dn;
		private CFloat _lips_puff_up;
		private CFloat _lips_puff_dn;
		private CFloat _lips_apart_up;
		private CFloat _lips_apart_dn;
		private CFloat _lips_l_lower_raise;
		private CFloat _lips_r_lower_raise;
		private CFloat _lips_l_corner_dn;
		private CFloat _lips_r_corner_dn;
		private CFloat _lips_chin_raise;
		private CFloat _lips_together_up;
		private CFloat _lips_together_dn;
		private CFloat _lips_l_purse;
		private CFloat _lips_r_purse;
		private CFloat _lips_l_funnel;
		private CFloat _lips_r_funnel;
		private CFloat _lips_tighten_up;
		private CFloat _lips_tighten_dn;
		private CFloat _lips_mid_shift_l;
		private CFloat _lips_mid_shift_r;
		private CFloat _lips_mid_shift_up;
		private CFloat _lips_mid_shift_dn;
		private CFloat _lips_corner_sticky;
		private CFloat _lips_l_corner_up_in_sticky_cutScene;
		private CFloat _lips_l_corner_dn_in_sticky_cutScene;
		private CFloat _lips_l_corner_up_out_sticky_cutScene;
		private CFloat _lips_l_corner_dn_out_sticky_cutScene;
		private CFloat _lips_r_corner_up_in_sticky_cutScene;
		private CFloat _lips_r_corner_up_out_sticky_cutScene;
		private CFloat _lips_r_corner_dn_in_sticky_cutScene;
		private CFloat _lips_r_corner_dn_out_sticky_cutScene;
		private CFloat _cheek_l_suck;
		private CFloat _cheek_r_suck;
		private CFloat _cheek_l_puff;
		private CFloat _cheek_r_puff;
		private CFloat _jaw_mid_open;
		private CFloat _jaw_mid_close;
		private CFloat _jaw_mid_shift_l;
		private CFloat _jaw_mid_shift_r;
		private CFloat _jaw_mid_shift_fwd;
		private CFloat _jaw_mid_shift_back;
		private CFloat _jaw_mid_clench;
		private CFloat _neck_l_stretch;
		private CFloat _neck_r_stretch;
		private CFloat _neck_tighten;
		private CFloat _neck_l_sternocleidomastoid_flex;
		private CFloat _neck_r_sternocleidomastoid_flex;
		private CFloat _neck_l_platysma_flex;
		private CFloat _neck_r_platysma_flex;
		private CFloat _neck_throat_adamsApple_up;
		private CFloat _neck_throat_adamsApple_dn;
		private CFloat _neck_throat_compress;
		private CFloat _neck_throat_open;
		private CFloat _neck_l_turn;
		private CFloat _neck_r_turn;
		private CFloat _neck_up_turn;
		private CFloat _neck_dn_turn;
		private CFloat _neck_l_tilt;
		private CFloat _neck_r_tilt;
		private CFloat _head_neck_up_turn;
		private CFloat _head_neck_dn_turn;
		private CFloat _head_neck_l_tilt;
		private CFloat _head_neck_r_tilt;
		private CFloat _ear_l_shift_up;
		private CFloat _ear_r_shift_up;
		private CFloat _sculp_mid_slide;
		private CFloat _face_gravity_fwd;
		private CFloat _face_gravity_back;
		private CFloat _face_gravity_l;
		private CFloat _face_gravity_r;
		private CFloat _tongue_mid_base_l;
		private CFloat _tongue_mid_base_r;
		private CFloat _tongue_mid_base_dn;
		private CFloat _tongue_mid_base_up;
		private CFloat _tongue_mid_base_fwd;
		private CFloat _tongue_mid_base_front;
		private CFloat _tongue_mid_base_back;
		private CFloat _tongue_mid_fwd;
		private CFloat _tongue_mid_lift;
		private CFloat _tongue_mid_tip_l;
		private CFloat _tongue_mid_tip_r;
		private CFloat _tongue_mid_tip_dn;
		private CFloat _tongue_mid_tip_up;
		private CFloat _tongue_mid_twist_l;
		private CFloat _tongue_mid_twist_r;
		private CFloat _tongue_mid_thick;
		private CFloat _nose_l_snearAnimOverrideWeight;
		private CFloat _nose_r_snearAnimOverrideWeight;
		private CFloat _lips_l_nasolabialDeepenerAnimOverrideWeight;
		private CFloat _lips_r_nasolabialDeepenerAnimOverrideWeight;
		private CFloat _lips_l_upper_raiseAnimOverrideWeight;
		private CFloat _lips_r_upper_raiseAnimOverrideWeight;
		private CFloat _lips_l_pullAnimOverrideWeight;
		private CFloat _lips_r_pullAnimOverrideWeight;
		private CFloat _lips_l_corner_upAnimOverrideWeight;
		private CFloat _lips_r_corner_upAnimOverrideWeight;
		private CFloat _lips_l_corner_wideAnimOverrideWeight;
		private CFloat _lips_r_corner_wideAnimOverrideWeight;
		private CFloat _lips_l_corner_stretchAnimOverrideWeight;
		private CFloat _lips_r_corner_stretchAnimOverrideWeight;
		private CFloat _lips_l_stretchAnimOverrideWeight;
		private CFloat _lips_r_stretchAnimOverrideWeight;
		private CFloat _lips_l_corner_sharp_upAnimOverrideWeight;
		private CFloat _lips_r_corner_sharp_upAnimOverrideWeight;
		private CFloat _lips_suck_upAnimOverrideWeight;
		private CFloat _lips_suck_dnAnimOverrideWeight;
		private CFloat _lips_puff_upAnimOverrideWeight;
		private CFloat _lips_puff_dnAnimOverrideWeight;
		private CFloat _lips_apart_upAnimOverrideWeight;
		private CFloat _lips_apart_dnAnimOverrideWeight;
		private CFloat _lips_l_lower_raiseAnimOverrideWeight;
		private CFloat _lips_r_lower_raiseAnimOverrideWeight;
		private CFloat _lips_l_corner_dnAnimOverrideWeight;
		private CFloat _lips_r_corner_dnAnimOverrideWeight;
		private CFloat _lips_chin_raiseAnimOverrideWeight;
		private CFloat _lips_together_upAnimOverrideWeight;
		private CFloat _lips_together_dnAnimOverrideWeight;
		private CFloat _lips_l_purseAnimOverrideWeight;
		private CFloat _lips_r_purseAnimOverrideWeight;
		private CFloat _lips_l_funnelAnimOverrideWeight;
		private CFloat _lips_r_funnelAnimOverrideWeight;
		private CFloat _lips_tighten_upAnimOverrideWeight;
		private CFloat _lips_tighten_dnAnimOverrideWeight;
		private CFloat _lips_mid_shift_lAnimOverrideWeight;
		private CFloat _lips_mid_shift_rAnimOverrideWeight;
		private CFloat _lips_mid_shift_upAnimOverrideWeight;
		private CFloat _lips_mid_shift_dnAnimOverrideWeight;
		private CFloat _cheek_l_puffAnimOverrideWeight;
		private CFloat _cheek_r_puffAnimOverrideWeight;
		private CFloat _jaw_mid_openAnimOverrideWeight;
		private CFloat _jaw_mid_closeAnimOverrideWeight;
		private CFloat _jaw_mid_shift_lAnimOverrideWeight;
		private CFloat _jaw_mid_shift_rAnimOverrideWeight;
		private CFloat _jaw_mid_shift_fwdAnimOverrideWeight;
		private CFloat _jaw_mid_shift_backAnimOverrideWeight;
		private CFloat _jaw_mid_clenchAnimOverrideWeight;
		private CFloat _neck_l_stretchAnimOverrideWeight;
		private CFloat _neck_r_stretchAnimOverrideWeight;
		private CFloat _neck_tightenAnimOverrideWeight;
		private CFloat _neck_l_sternocleidomastoid_flexAnimOverrideWeight;
		private CFloat _neck_r_sternocleidomastoid_flexAnimOverrideWeight;
		private CFloat _neck_l_platysma_flexAnimOverrideWeight;
		private CFloat _neck_r_platysma_flexAnimOverrideWeight;
		private CFloat _neck_throat_adamsApple_upAnimOverrideWeight;
		private CFloat _neck_throat_adamsApple_dnAnimOverrideWeight;
		private CFloat _neck_throat_compressAnimOverrideWeight;
		private CFloat _neck_throat_openAnimOverrideWeight;
		private CFloat _lips_corner_stickyAnimOverrideWeight;
		private CFloat _lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight;
		private CFloat _lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight;
		private CFloat _lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight;
		private CFloat _lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight;
		private CFloat _lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight;
		private CFloat _lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight;
		private CFloat _lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight;
		private CFloat _lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight;
		private CFloat _tongue_mid_base_lAnimOverrideWeight;
		private CFloat _tongue_mid_base_rAnimOverrideWeight;
		private CFloat _tongue_mid_base_dnAnimOverrideWeight;
		private CFloat _tongue_mid_base_upAnimOverrideWeight;
		private CFloat _tongue_mid_base_fwdAnimOverrideWeight;
		private CFloat _tongue_mid_base_frontAnimOverrideWeight;
		private CFloat _tongue_mid_base_backAnimOverrideWeight;
		private CFloat _tongue_mid_fwdAnimOverrideWeight;
		private CFloat _tongue_mid_liftAnimOverrideWeight;
		private CFloat _tongue_mid_tip_lAnimOverrideWeight;
		private CFloat _tongue_mid_tip_rAnimOverrideWeight;
		private CFloat _tongue_mid_tip_dnAnimOverrideWeight;
		private CFloat _tongue_mid_tip_upAnimOverrideWeight;
		private CFloat _tongue_mid_twist_lAnimOverrideWeight;
		private CFloat _tongue_mid_twist_rAnimOverrideWeight;
		private CFloat _tongue_mid_thickAnimOverrideWeight;
		private CFloat _eye_l_blinkLipsyncPoseOutput;
		private CFloat _eye_r_blinkLipsyncPoseOutput;
		private CFloat _eye_l_widenLipsyncPoseOutput;
		private CFloat _eye_r_widenLipsyncPoseOutput;
		private CFloat _eye_l_dir_upLipsyncPoseOutput;
		private CFloat _eye_l_dir_dnLipsyncPoseOutput;
		private CFloat _eye_l_dir_inLipsyncPoseOutput;
		private CFloat _eye_l_dir_outLipsyncPoseOutput;
		private CFloat _eye_r_dir_upLipsyncPoseOutput;
		private CFloat _eye_r_dir_dnLipsyncPoseOutput;
		private CFloat _eye_r_dir_inLipsyncPoseOutput;
		private CFloat _eye_r_dir_outLipsyncPoseOutput;
		private CFloat _eye_l_pupil_narrowLipsyncPoseOutput;
		private CFloat _eye_r_pupil_narrowLipsyncPoseOutput;
		private CFloat _eye_l_pupil_wideLipsyncPoseOutput;
		private CFloat _eye_r_pupil_wideLipsyncPoseOutput;
		private CFloat _eye_l_brows_raise_inLipsyncPoseOutput;
		private CFloat _eye_r_brows_raise_inLipsyncPoseOutput;
		private CFloat _eye_l_brows_raise_outLipsyncPoseOutput;
		private CFloat _eye_r_brows_raise_outLipsyncPoseOutput;
		private CFloat _eye_l_brows_lowerLipsyncPoseOutput;
		private CFloat _eye_r_brows_lowerLipsyncPoseOutput;
		private CFloat _eye_l_brows_lateralLipsyncPoseOutput;
		private CFloat _eye_r_brows_lateralLipsyncPoseOutput;
		private CFloat _eye_l_oculi_squint_innerLipsyncPoseOutput;
		private CFloat _eye_r_oculi_squint_innerLipsyncPoseOutput;
		private CFloat _eye_l_oculi_squint_outer_lowerLipsyncPoseOutput;
		private CFloat _eye_r_oculi_squint_outer_lowerLipsyncPoseOutput;
		private CFloat _eye_l_oculi_squint_outer_upperLipsyncPoseOutput;
		private CFloat _eye_r_oculi_squint_outer_upperLipsyncPoseOutput;
		private CFloat _nose_l_compressLipsyncPoseOutput;
		private CFloat _nose_r_compressLipsyncPoseOutput;
		private CFloat _nose_l_breathe_inLipsyncPoseOutput;
		private CFloat _nose_r_breathe_inLipsyncPoseOutput;
		private CFloat _nose_l_breathe_outLipsyncPoseOutput;
		private CFloat _nose_r_breathe_outLipsyncPoseOutput;
		private CFloat _nose_l_snearLipsyncPoseOutput;
		private CFloat _nose_r_snearLipsyncPoseOutput;
		private CFloat _lips_l_nasolabialDeepenerLipsyncPoseOutput;
		private CFloat _lips_r_nasolabialDeepenerLipsyncPoseOutput;
		private CFloat _lips_l_upper_raiseLipsyncPoseOutput;
		private CFloat _lips_r_upper_raiseLipsyncPoseOutput;
		private CFloat _lips_l_pullLipsyncPoseOutput;
		private CFloat _lips_r_pullLipsyncPoseOutput;
		private CFloat _lips_l_corner_upLipsyncPoseOutput;
		private CFloat _lips_r_corner_upLipsyncPoseOutput;
		private CFloat _lips_l_corner_wideLipsyncPoseOutput;
		private CFloat _lips_r_corner_wideLipsyncPoseOutput;
		private CFloat _lips_l_corner_stretchLipsyncPoseOutput;
		private CFloat _lips_r_corner_stretchLipsyncPoseOutput;
		private CFloat _lips_l_stretchLipsyncPoseOutput;
		private CFloat _lips_r_stretchLipsyncPoseOutput;
		private CFloat _lips_l_corner_sharp_upLipsyncPoseOutput;
		private CFloat _lips_r_corner_sharp_upLipsyncPoseOutput;
		private CFloat _lips_suck_upLipsyncPoseOutput;
		private CFloat _lips_suck_dnLipsyncPoseOutput;
		private CFloat _lips_puff_upLipsyncPoseOutput;
		private CFloat _lips_puff_dnLipsyncPoseOutput;
		private CFloat _lips_apart_upLipsyncPoseOutput;
		private CFloat _lips_apart_dnLipsyncPoseOutput;
		private CFloat _lips_l_lower_raiseLipsyncPoseOutput;
		private CFloat _lips_r_lower_raiseLipsyncPoseOutput;
		private CFloat _lips_l_corner_dnLipsyncPoseOutput;
		private CFloat _lips_r_corner_dnLipsyncPoseOutput;
		private CFloat _lips_chin_raiseLipsyncPoseOutput;
		private CFloat _lips_together_upLipsyncPoseOutput;
		private CFloat _lips_together_dnLipsyncPoseOutput;
		private CFloat _lips_l_purseLipsyncPoseOutput;
		private CFloat _lips_r_purseLipsyncPoseOutput;
		private CFloat _lips_l_funnelLipsyncPoseOutput;
		private CFloat _lips_r_funnelLipsyncPoseOutput;
		private CFloat _lips_tighten_upLipsyncPoseOutput;
		private CFloat _lips_tighten_dnLipsyncPoseOutput;
		private CFloat _lips_mid_shift_lLipsyncPoseOutput;
		private CFloat _lips_mid_shift_rLipsyncPoseOutput;
		private CFloat _lips_mid_shift_upLipsyncPoseOutput;
		private CFloat _lips_mid_shift_dnLipsyncPoseOutput;
		private CFloat _lips_corner_stickyLipsyncPoseOutput;
		private CFloat _lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput;
		private CFloat _cheek_l_suckLipsyncPoseOutput;
		private CFloat _cheek_r_suckLipsyncPoseOutput;
		private CFloat _cheek_l_puffLipsyncPoseOutput;
		private CFloat _cheek_r_puffLipsyncPoseOutput;
		private CFloat _jaw_mid_openLipsyncPoseOutput;
		private CFloat _jaw_mid_closeLipsyncPoseOutput;
		private CFloat _jaw_mid_shift_lLipsyncPoseOutput;
		private CFloat _jaw_mid_shift_rLipsyncPoseOutput;
		private CFloat _jaw_mid_shift_fwdLipsyncPoseOutput;
		private CFloat _jaw_mid_shift_backLipsyncPoseOutput;
		private CFloat _jaw_mid_clenchLipsyncPoseOutput;
		private CFloat _neck_l_stretchLipsyncPoseOutput;
		private CFloat _neck_r_stretchLipsyncPoseOutput;
		private CFloat _neck_tightenLipsyncPoseOutput;
		private CFloat _neck_l_sternocleidomastoid_flexLipsyncPoseOutput;
		private CFloat _neck_r_sternocleidomastoid_flexLipsyncPoseOutput;
		private CFloat _neck_l_platysma_flexLipsyncPoseOutput;
		private CFloat _neck_r_platysma_flexLipsyncPoseOutput;
		private CFloat _neck_throat_adamsApple_upLipsyncPoseOutput;
		private CFloat _neck_throat_adamsApple_dnLipsyncPoseOutput;
		private CFloat _neck_throat_compressLipsyncPoseOutput;
		private CFloat _neck_throat_openLipsyncPoseOutput;
		private CFloat _neck_l_turnLipsyncPoseOutput;
		private CFloat _neck_r_turnLipsyncPoseOutput;
		private CFloat _neck_up_turnLipsyncPoseOutput;
		private CFloat _neck_dn_turnLipsyncPoseOutput;
		private CFloat _neck_l_tiltLipsyncPoseOutput;
		private CFloat _neck_r_tiltLipsyncPoseOutput;
		private CFloat _head_neck_up_turnLipsyncPoseOutput;
		private CFloat _head_neck_dn_turnLipsyncPoseOutput;
		private CFloat _head_neck_l_tiltLipsyncPoseOutput;
		private CFloat _head_neck_r_tiltLipsyncPoseOutput;
		private CFloat _ear_l_shift_upLipsyncPoseOutput;
		private CFloat _ear_r_shift_upLipsyncPoseOutput;
		private CFloat _sculp_mid_slideLipsyncPoseOutput;
		private CFloat _face_gravity_fwdLipsyncPoseOutput;
		private CFloat _face_gravity_backLipsyncPoseOutput;
		private CFloat _face_gravity_lLipsyncPoseOutput;
		private CFloat _face_gravity_rLipsyncPoseOutput;
		private CFloat _tongue_mid_base_lLipsyncPoseOutput;
		private CFloat _tongue_mid_base_rLipsyncPoseOutput;
		private CFloat _tongue_mid_base_dnLipsyncPoseOutput;
		private CFloat _tongue_mid_base_upLipsyncPoseOutput;
		private CFloat _tongue_mid_base_fwdLipsyncPoseOutput;
		private CFloat _tongue_mid_base_frontLipsyncPoseOutput;
		private CFloat _tongue_mid_base_backLipsyncPoseOutput;
		private CFloat _tongue_mid_fwdLipsyncPoseOutput;
		private CFloat _tongue_mid_liftLipsyncPoseOutput;
		private CFloat _tongue_mid_tip_lLipsyncPoseOutput;
		private CFloat _tongue_mid_tip_rLipsyncPoseOutput;
		private CFloat _tongue_mid_tip_dnLipsyncPoseOutput;
		private CFloat _tongue_mid_tip_upLipsyncPoseOutput;
		private CFloat _tongue_mid_twist_lLipsyncPoseOutput;
		private CFloat _tongue_mid_twist_rLipsyncPoseOutput;
		private CFloat _tongue_mid_thickLipsyncPoseOutput;
		private CFloat _eye_l_oculi_squint_outer_lowerWrnkl;
		private CFloat _eye_r_oculi_squint_outer_lowerWrnkl;
		private CFloat _eye_l_oculi_squint_outer_upperWrnkl;
		private CFloat _eye_r_oculi_squint_outer_upperWrnkl;
		private CFloat _eye_l_brows_raise_inWrnkl;
		private CFloat _eye_r_brows_raise_inWrnkl;
		private CFloat _eye_l_brows_raise_outWrnkl;
		private CFloat _eye_r_brows_raise_outWrnkl;
		private CFloat _eye_l_brows_lowerWrnkl;
		private CFloat _eye_r_brows_lowerWrnkl;
		private CFloat _eye_l_brows_lateralWrnkl;
		private CFloat _eye_r_brows_lateralWrnkl;
		private CFloat _nose_l_snearWrnkl;
		private CFloat _nose_r_snearWrnkl;
		private CFloat _lips_l_upper_raiseWrnkl;
		private CFloat _lips_r_upper_raiseWrnkl;
		private CFloat _lips_l_corner_upWrnkl;
		private CFloat _lips_r_corner_upWrnkl;
		private CFloat _lips_l_corner_wideWrnkl;
		private CFloat _lips_r_corner_wideWrnkl;
		private CFloat _lips_l_corner_stretchWrnkl;
		private CFloat _lips_r_corner_stretchWrnkl;
		private CFloat _lips_l_lower_raiseWrnkl;
		private CFloat _lips_r_lower_raiseWrnkl;
		private CFloat _lips_chin_raiseWrnkl;
		private CFloat _lips_l_purseWrnkl;
		private CFloat _lips_r_purseWrnkl;
		private CFloat _lips_l_funnelWrnkl;
		private CFloat _lips_r_funnelWrnkl;
		private CFloat _jaw_mid_openWrnkl;
		private CFloat _neck_l_stretchWrnkl;
		private CFloat _neck_r_stretchWrnkl;
		private CFloat _head_neck_dn_turnWrnkl;

		[Ordinal(0)] 
		[RED("faceEnvelope")] 
		public CFloat FaceEnvelope
		{
			get => GetProperty(ref _faceEnvelope);
			set => SetProperty(ref _faceEnvelope, value);
		}

		[Ordinal(1)] 
		[RED("upperFace")] 
		public CFloat UpperFace
		{
			get => GetProperty(ref _upperFace);
			set => SetProperty(ref _upperFace, value);
		}

		[Ordinal(2)] 
		[RED("lowerFace")] 
		public CFloat LowerFace
		{
			get => GetProperty(ref _lowerFace);
			set => SetProperty(ref _lowerFace, value);
		}

		[Ordinal(3)] 
		[RED("lipSyncEnvelope")] 
		public CFloat LipSyncEnvelope
		{
			get => GetProperty(ref _lipSyncEnvelope);
			set => SetProperty(ref _lipSyncEnvelope, value);
		}

		[Ordinal(4)] 
		[RED("lipSyncLeftEnvelope")] 
		public CFloat LipSyncLeftEnvelope
		{
			get => GetProperty(ref _lipSyncLeftEnvelope);
			set => SetProperty(ref _lipSyncLeftEnvelope, value);
		}

		[Ordinal(5)] 
		[RED("lipSyncRightEnvelope")] 
		public CFloat LipSyncRightEnvelope
		{
			get => GetProperty(ref _lipSyncRightEnvelope);
			set => SetProperty(ref _lipSyncRightEnvelope, value);
		}

		[Ordinal(6)] 
		[RED("jaliJaw")] 
		public CFloat JaliJaw
		{
			get => GetProperty(ref _jaliJaw);
			set => SetProperty(ref _jaliJaw, value);
		}

		[Ordinal(7)] 
		[RED("jaliLips")] 
		public CFloat JaliLips
		{
			get => GetProperty(ref _jaliLips);
			set => SetProperty(ref _jaliLips, value);
		}

		[Ordinal(8)] 
		[RED("muzzleLips")] 
		public CFloat MuzzleLips
		{
			get => GetProperty(ref _muzzleLips);
			set => SetProperty(ref _muzzleLips, value);
		}

		[Ordinal(9)] 
		[RED("muzzleEyes")] 
		public CFloat MuzzleEyes
		{
			get => GetProperty(ref _muzzleEyes);
			set => SetProperty(ref _muzzleEyes, value);
		}

		[Ordinal(10)] 
		[RED("muzzleBrows")] 
		public CFloat MuzzleBrows
		{
			get => GetProperty(ref _muzzleBrows);
			set => SetProperty(ref _muzzleBrows, value);
		}

		[Ordinal(11)] 
		[RED("muzzleEyeDirections")] 
		public CFloat MuzzleEyeDirections
		{
			get => GetProperty(ref _muzzleEyeDirections);
			set => SetProperty(ref _muzzleEyeDirections, value);
		}

		[Ordinal(12)] 
		[RED("eye_l_blink")] 
		public CFloat Eye_l_blink
		{
			get => GetProperty(ref _eye_l_blink);
			set => SetProperty(ref _eye_l_blink, value);
		}

		[Ordinal(13)] 
		[RED("eye_r_blink")] 
		public CFloat Eye_r_blink
		{
			get => GetProperty(ref _eye_r_blink);
			set => SetProperty(ref _eye_r_blink, value);
		}

		[Ordinal(14)] 
		[RED("eye_l_widen")] 
		public CFloat Eye_l_widen
		{
			get => GetProperty(ref _eye_l_widen);
			set => SetProperty(ref _eye_l_widen, value);
		}

		[Ordinal(15)] 
		[RED("eye_r_widen")] 
		public CFloat Eye_r_widen
		{
			get => GetProperty(ref _eye_r_widen);
			set => SetProperty(ref _eye_r_widen, value);
		}

		[Ordinal(16)] 
		[RED("eye_l_dir_up")] 
		public CFloat Eye_l_dir_up
		{
			get => GetProperty(ref _eye_l_dir_up);
			set => SetProperty(ref _eye_l_dir_up, value);
		}

		[Ordinal(17)] 
		[RED("eye_l_dir_dn")] 
		public CFloat Eye_l_dir_dn
		{
			get => GetProperty(ref _eye_l_dir_dn);
			set => SetProperty(ref _eye_l_dir_dn, value);
		}

		[Ordinal(18)] 
		[RED("eye_l_dir_in")] 
		public CFloat Eye_l_dir_in
		{
			get => GetProperty(ref _eye_l_dir_in);
			set => SetProperty(ref _eye_l_dir_in, value);
		}

		[Ordinal(19)] 
		[RED("eye_l_dir_out")] 
		public CFloat Eye_l_dir_out
		{
			get => GetProperty(ref _eye_l_dir_out);
			set => SetProperty(ref _eye_l_dir_out, value);
		}

		[Ordinal(20)] 
		[RED("eye_r_dir_up")] 
		public CFloat Eye_r_dir_up
		{
			get => GetProperty(ref _eye_r_dir_up);
			set => SetProperty(ref _eye_r_dir_up, value);
		}

		[Ordinal(21)] 
		[RED("eye_r_dir_dn")] 
		public CFloat Eye_r_dir_dn
		{
			get => GetProperty(ref _eye_r_dir_dn);
			set => SetProperty(ref _eye_r_dir_dn, value);
		}

		[Ordinal(22)] 
		[RED("eye_r_dir_in")] 
		public CFloat Eye_r_dir_in
		{
			get => GetProperty(ref _eye_r_dir_in);
			set => SetProperty(ref _eye_r_dir_in, value);
		}

		[Ordinal(23)] 
		[RED("eye_r_dir_out")] 
		public CFloat Eye_r_dir_out
		{
			get => GetProperty(ref _eye_r_dir_out);
			set => SetProperty(ref _eye_r_dir_out, value);
		}

		[Ordinal(24)] 
		[RED("eye_l_pupil_narrow")] 
		public CFloat Eye_l_pupil_narrow
		{
			get => GetProperty(ref _eye_l_pupil_narrow);
			set => SetProperty(ref _eye_l_pupil_narrow, value);
		}

		[Ordinal(25)] 
		[RED("eye_r_pupil_narrow")] 
		public CFloat Eye_r_pupil_narrow
		{
			get => GetProperty(ref _eye_r_pupil_narrow);
			set => SetProperty(ref _eye_r_pupil_narrow, value);
		}

		[Ordinal(26)] 
		[RED("eye_l_pupil_wide")] 
		public CFloat Eye_l_pupil_wide
		{
			get => GetProperty(ref _eye_l_pupil_wide);
			set => SetProperty(ref _eye_l_pupil_wide, value);
		}

		[Ordinal(27)] 
		[RED("eye_r_pupil_wide")] 
		public CFloat Eye_r_pupil_wide
		{
			get => GetProperty(ref _eye_r_pupil_wide);
			set => SetProperty(ref _eye_r_pupil_wide, value);
		}

		[Ordinal(28)] 
		[RED("eye_l_brows_raise_in")] 
		public CFloat Eye_l_brows_raise_in
		{
			get => GetProperty(ref _eye_l_brows_raise_in);
			set => SetProperty(ref _eye_l_brows_raise_in, value);
		}

		[Ordinal(29)] 
		[RED("eye_r_brows_raise_in")] 
		public CFloat Eye_r_brows_raise_in
		{
			get => GetProperty(ref _eye_r_brows_raise_in);
			set => SetProperty(ref _eye_r_brows_raise_in, value);
		}

		[Ordinal(30)] 
		[RED("eye_l_brows_raise_out")] 
		public CFloat Eye_l_brows_raise_out
		{
			get => GetProperty(ref _eye_l_brows_raise_out);
			set => SetProperty(ref _eye_l_brows_raise_out, value);
		}

		[Ordinal(31)] 
		[RED("eye_r_brows_raise_out")] 
		public CFloat Eye_r_brows_raise_out
		{
			get => GetProperty(ref _eye_r_brows_raise_out);
			set => SetProperty(ref _eye_r_brows_raise_out, value);
		}

		[Ordinal(32)] 
		[RED("eye_l_brows_lower")] 
		public CFloat Eye_l_brows_lower
		{
			get => GetProperty(ref _eye_l_brows_lower);
			set => SetProperty(ref _eye_l_brows_lower, value);
		}

		[Ordinal(33)] 
		[RED("eye_r_brows_lower")] 
		public CFloat Eye_r_brows_lower
		{
			get => GetProperty(ref _eye_r_brows_lower);
			set => SetProperty(ref _eye_r_brows_lower, value);
		}

		[Ordinal(34)] 
		[RED("eye_l_brows_lateral")] 
		public CFloat Eye_l_brows_lateral
		{
			get => GetProperty(ref _eye_l_brows_lateral);
			set => SetProperty(ref _eye_l_brows_lateral, value);
		}

		[Ordinal(35)] 
		[RED("eye_r_brows_lateral")] 
		public CFloat Eye_r_brows_lateral
		{
			get => GetProperty(ref _eye_r_brows_lateral);
			set => SetProperty(ref _eye_r_brows_lateral, value);
		}

		[Ordinal(36)] 
		[RED("eye_l_oculi_squint_inner")] 
		public CFloat Eye_l_oculi_squint_inner
		{
			get => GetProperty(ref _eye_l_oculi_squint_inner);
			set => SetProperty(ref _eye_l_oculi_squint_inner, value);
		}

		[Ordinal(37)] 
		[RED("eye_r_oculi_squint_inner")] 
		public CFloat Eye_r_oculi_squint_inner
		{
			get => GetProperty(ref _eye_r_oculi_squint_inner);
			set => SetProperty(ref _eye_r_oculi_squint_inner, value);
		}

		[Ordinal(38)] 
		[RED("eye_l_oculi_squint_outer_lower")] 
		public CFloat Eye_l_oculi_squint_outer_lower
		{
			get => GetProperty(ref _eye_l_oculi_squint_outer_lower);
			set => SetProperty(ref _eye_l_oculi_squint_outer_lower, value);
		}

		[Ordinal(39)] 
		[RED("eye_r_oculi_squint_outer_lower")] 
		public CFloat Eye_r_oculi_squint_outer_lower
		{
			get => GetProperty(ref _eye_r_oculi_squint_outer_lower);
			set => SetProperty(ref _eye_r_oculi_squint_outer_lower, value);
		}

		[Ordinal(40)] 
		[RED("eye_l_oculi_squint_outer_upper")] 
		public CFloat Eye_l_oculi_squint_outer_upper
		{
			get => GetProperty(ref _eye_l_oculi_squint_outer_upper);
			set => SetProperty(ref _eye_l_oculi_squint_outer_upper, value);
		}

		[Ordinal(41)] 
		[RED("eye_r_oculi_squint_outer_upper")] 
		public CFloat Eye_r_oculi_squint_outer_upper
		{
			get => GetProperty(ref _eye_r_oculi_squint_outer_upper);
			set => SetProperty(ref _eye_r_oculi_squint_outer_upper, value);
		}

		[Ordinal(42)] 
		[RED("nose_l_compress")] 
		public CFloat Nose_l_compress
		{
			get => GetProperty(ref _nose_l_compress);
			set => SetProperty(ref _nose_l_compress, value);
		}

		[Ordinal(43)] 
		[RED("nose_r_compress")] 
		public CFloat Nose_r_compress
		{
			get => GetProperty(ref _nose_r_compress);
			set => SetProperty(ref _nose_r_compress, value);
		}

		[Ordinal(44)] 
		[RED("nose_l_breathe_in")] 
		public CFloat Nose_l_breathe_in
		{
			get => GetProperty(ref _nose_l_breathe_in);
			set => SetProperty(ref _nose_l_breathe_in, value);
		}

		[Ordinal(45)] 
		[RED("nose_r_breathe_in")] 
		public CFloat Nose_r_breathe_in
		{
			get => GetProperty(ref _nose_r_breathe_in);
			set => SetProperty(ref _nose_r_breathe_in, value);
		}

		[Ordinal(46)] 
		[RED("nose_l_breathe_out")] 
		public CFloat Nose_l_breathe_out
		{
			get => GetProperty(ref _nose_l_breathe_out);
			set => SetProperty(ref _nose_l_breathe_out, value);
		}

		[Ordinal(47)] 
		[RED("nose_r_breathe_out")] 
		public CFloat Nose_r_breathe_out
		{
			get => GetProperty(ref _nose_r_breathe_out);
			set => SetProperty(ref _nose_r_breathe_out, value);
		}

		[Ordinal(48)] 
		[RED("nose_l_snear")] 
		public CFloat Nose_l_snear
		{
			get => GetProperty(ref _nose_l_snear);
			set => SetProperty(ref _nose_l_snear, value);
		}

		[Ordinal(49)] 
		[RED("nose_r_snear")] 
		public CFloat Nose_r_snear
		{
			get => GetProperty(ref _nose_r_snear);
			set => SetProperty(ref _nose_r_snear, value);
		}

		[Ordinal(50)] 
		[RED("lips_l_nasolabialDeepener")] 
		public CFloat Lips_l_nasolabialDeepener
		{
			get => GetProperty(ref _lips_l_nasolabialDeepener);
			set => SetProperty(ref _lips_l_nasolabialDeepener, value);
		}

		[Ordinal(51)] 
		[RED("lips_r_nasolabialDeepener")] 
		public CFloat Lips_r_nasolabialDeepener
		{
			get => GetProperty(ref _lips_r_nasolabialDeepener);
			set => SetProperty(ref _lips_r_nasolabialDeepener, value);
		}

		[Ordinal(52)] 
		[RED("lips_l_upper_raise")] 
		public CFloat Lips_l_upper_raise
		{
			get => GetProperty(ref _lips_l_upper_raise);
			set => SetProperty(ref _lips_l_upper_raise, value);
		}

		[Ordinal(53)] 
		[RED("lips_r_upper_raise")] 
		public CFloat Lips_r_upper_raise
		{
			get => GetProperty(ref _lips_r_upper_raise);
			set => SetProperty(ref _lips_r_upper_raise, value);
		}

		[Ordinal(54)] 
		[RED("lips_l_pull")] 
		public CFloat Lips_l_pull
		{
			get => GetProperty(ref _lips_l_pull);
			set => SetProperty(ref _lips_l_pull, value);
		}

		[Ordinal(55)] 
		[RED("lips_r_pull")] 
		public CFloat Lips_r_pull
		{
			get => GetProperty(ref _lips_r_pull);
			set => SetProperty(ref _lips_r_pull, value);
		}

		[Ordinal(56)] 
		[RED("lips_l_corner_up")] 
		public CFloat Lips_l_corner_up
		{
			get => GetProperty(ref _lips_l_corner_up);
			set => SetProperty(ref _lips_l_corner_up, value);
		}

		[Ordinal(57)] 
		[RED("lips_r_corner_up")] 
		public CFloat Lips_r_corner_up
		{
			get => GetProperty(ref _lips_r_corner_up);
			set => SetProperty(ref _lips_r_corner_up, value);
		}

		[Ordinal(58)] 
		[RED("lips_l_corner_wide")] 
		public CFloat Lips_l_corner_wide
		{
			get => GetProperty(ref _lips_l_corner_wide);
			set => SetProperty(ref _lips_l_corner_wide, value);
		}

		[Ordinal(59)] 
		[RED("lips_r_corner_wide")] 
		public CFloat Lips_r_corner_wide
		{
			get => GetProperty(ref _lips_r_corner_wide);
			set => SetProperty(ref _lips_r_corner_wide, value);
		}

		[Ordinal(60)] 
		[RED("lips_l_corner_stretch")] 
		public CFloat Lips_l_corner_stretch
		{
			get => GetProperty(ref _lips_l_corner_stretch);
			set => SetProperty(ref _lips_l_corner_stretch, value);
		}

		[Ordinal(61)] 
		[RED("lips_r_corner_stretch")] 
		public CFloat Lips_r_corner_stretch
		{
			get => GetProperty(ref _lips_r_corner_stretch);
			set => SetProperty(ref _lips_r_corner_stretch, value);
		}

		[Ordinal(62)] 
		[RED("lips_l_stretch")] 
		public CFloat Lips_l_stretch
		{
			get => GetProperty(ref _lips_l_stretch);
			set => SetProperty(ref _lips_l_stretch, value);
		}

		[Ordinal(63)] 
		[RED("lips_r_stretch")] 
		public CFloat Lips_r_stretch
		{
			get => GetProperty(ref _lips_r_stretch);
			set => SetProperty(ref _lips_r_stretch, value);
		}

		[Ordinal(64)] 
		[RED("lips_l_corner_sharp_up")] 
		public CFloat Lips_l_corner_sharp_up
		{
			get => GetProperty(ref _lips_l_corner_sharp_up);
			set => SetProperty(ref _lips_l_corner_sharp_up, value);
		}

		[Ordinal(65)] 
		[RED("lips_r_corner_sharp_up")] 
		public CFloat Lips_r_corner_sharp_up
		{
			get => GetProperty(ref _lips_r_corner_sharp_up);
			set => SetProperty(ref _lips_r_corner_sharp_up, value);
		}

		[Ordinal(66)] 
		[RED("lips_suck_up")] 
		public CFloat Lips_suck_up
		{
			get => GetProperty(ref _lips_suck_up);
			set => SetProperty(ref _lips_suck_up, value);
		}

		[Ordinal(67)] 
		[RED("lips_suck_dn")] 
		public CFloat Lips_suck_dn
		{
			get => GetProperty(ref _lips_suck_dn);
			set => SetProperty(ref _lips_suck_dn, value);
		}

		[Ordinal(68)] 
		[RED("lips_puff_up")] 
		public CFloat Lips_puff_up
		{
			get => GetProperty(ref _lips_puff_up);
			set => SetProperty(ref _lips_puff_up, value);
		}

		[Ordinal(69)] 
		[RED("lips_puff_dn")] 
		public CFloat Lips_puff_dn
		{
			get => GetProperty(ref _lips_puff_dn);
			set => SetProperty(ref _lips_puff_dn, value);
		}

		[Ordinal(70)] 
		[RED("lips_apart_up")] 
		public CFloat Lips_apart_up
		{
			get => GetProperty(ref _lips_apart_up);
			set => SetProperty(ref _lips_apart_up, value);
		}

		[Ordinal(71)] 
		[RED("lips_apart_dn")] 
		public CFloat Lips_apart_dn
		{
			get => GetProperty(ref _lips_apart_dn);
			set => SetProperty(ref _lips_apart_dn, value);
		}

		[Ordinal(72)] 
		[RED("lips_l_lower_raise")] 
		public CFloat Lips_l_lower_raise
		{
			get => GetProperty(ref _lips_l_lower_raise);
			set => SetProperty(ref _lips_l_lower_raise, value);
		}

		[Ordinal(73)] 
		[RED("lips_r_lower_raise")] 
		public CFloat Lips_r_lower_raise
		{
			get => GetProperty(ref _lips_r_lower_raise);
			set => SetProperty(ref _lips_r_lower_raise, value);
		}

		[Ordinal(74)] 
		[RED("lips_l_corner_dn")] 
		public CFloat Lips_l_corner_dn
		{
			get => GetProperty(ref _lips_l_corner_dn);
			set => SetProperty(ref _lips_l_corner_dn, value);
		}

		[Ordinal(75)] 
		[RED("lips_r_corner_dn")] 
		public CFloat Lips_r_corner_dn
		{
			get => GetProperty(ref _lips_r_corner_dn);
			set => SetProperty(ref _lips_r_corner_dn, value);
		}

		[Ordinal(76)] 
		[RED("lips_chin_raise")] 
		public CFloat Lips_chin_raise
		{
			get => GetProperty(ref _lips_chin_raise);
			set => SetProperty(ref _lips_chin_raise, value);
		}

		[Ordinal(77)] 
		[RED("lips_together_up")] 
		public CFloat Lips_together_up
		{
			get => GetProperty(ref _lips_together_up);
			set => SetProperty(ref _lips_together_up, value);
		}

		[Ordinal(78)] 
		[RED("lips_together_dn")] 
		public CFloat Lips_together_dn
		{
			get => GetProperty(ref _lips_together_dn);
			set => SetProperty(ref _lips_together_dn, value);
		}

		[Ordinal(79)] 
		[RED("lips_l_purse")] 
		public CFloat Lips_l_purse
		{
			get => GetProperty(ref _lips_l_purse);
			set => SetProperty(ref _lips_l_purse, value);
		}

		[Ordinal(80)] 
		[RED("lips_r_purse")] 
		public CFloat Lips_r_purse
		{
			get => GetProperty(ref _lips_r_purse);
			set => SetProperty(ref _lips_r_purse, value);
		}

		[Ordinal(81)] 
		[RED("lips_l_funnel")] 
		public CFloat Lips_l_funnel
		{
			get => GetProperty(ref _lips_l_funnel);
			set => SetProperty(ref _lips_l_funnel, value);
		}

		[Ordinal(82)] 
		[RED("lips_r_funnel")] 
		public CFloat Lips_r_funnel
		{
			get => GetProperty(ref _lips_r_funnel);
			set => SetProperty(ref _lips_r_funnel, value);
		}

		[Ordinal(83)] 
		[RED("lips_tighten_up")] 
		public CFloat Lips_tighten_up
		{
			get => GetProperty(ref _lips_tighten_up);
			set => SetProperty(ref _lips_tighten_up, value);
		}

		[Ordinal(84)] 
		[RED("lips_tighten_dn")] 
		public CFloat Lips_tighten_dn
		{
			get => GetProperty(ref _lips_tighten_dn);
			set => SetProperty(ref _lips_tighten_dn, value);
		}

		[Ordinal(85)] 
		[RED("lips_mid_shift_l")] 
		public CFloat Lips_mid_shift_l
		{
			get => GetProperty(ref _lips_mid_shift_l);
			set => SetProperty(ref _lips_mid_shift_l, value);
		}

		[Ordinal(86)] 
		[RED("lips_mid_shift_r")] 
		public CFloat Lips_mid_shift_r
		{
			get => GetProperty(ref _lips_mid_shift_r);
			set => SetProperty(ref _lips_mid_shift_r, value);
		}

		[Ordinal(87)] 
		[RED("lips_mid_shift_up")] 
		public CFloat Lips_mid_shift_up
		{
			get => GetProperty(ref _lips_mid_shift_up);
			set => SetProperty(ref _lips_mid_shift_up, value);
		}

		[Ordinal(88)] 
		[RED("lips_mid_shift_dn")] 
		public CFloat Lips_mid_shift_dn
		{
			get => GetProperty(ref _lips_mid_shift_dn);
			set => SetProperty(ref _lips_mid_shift_dn, value);
		}

		[Ordinal(89)] 
		[RED("lips_corner_sticky")] 
		public CFloat Lips_corner_sticky
		{
			get => GetProperty(ref _lips_corner_sticky);
			set => SetProperty(ref _lips_corner_sticky, value);
		}

		[Ordinal(90)] 
		[RED("lips_l_corner_up_in_sticky_cutScene")] 
		public CFloat Lips_l_corner_up_in_sticky_cutScene
		{
			get => GetProperty(ref _lips_l_corner_up_in_sticky_cutScene);
			set => SetProperty(ref _lips_l_corner_up_in_sticky_cutScene, value);
		}

		[Ordinal(91)] 
		[RED("lips_l_corner_dn_in_sticky_cutScene")] 
		public CFloat Lips_l_corner_dn_in_sticky_cutScene
		{
			get => GetProperty(ref _lips_l_corner_dn_in_sticky_cutScene);
			set => SetProperty(ref _lips_l_corner_dn_in_sticky_cutScene, value);
		}

		[Ordinal(92)] 
		[RED("lips_l_corner_up_out_sticky_cutScene")] 
		public CFloat Lips_l_corner_up_out_sticky_cutScene
		{
			get => GetProperty(ref _lips_l_corner_up_out_sticky_cutScene);
			set => SetProperty(ref _lips_l_corner_up_out_sticky_cutScene, value);
		}

		[Ordinal(93)] 
		[RED("lips_l_corner_dn_out_sticky_cutScene")] 
		public CFloat Lips_l_corner_dn_out_sticky_cutScene
		{
			get => GetProperty(ref _lips_l_corner_dn_out_sticky_cutScene);
			set => SetProperty(ref _lips_l_corner_dn_out_sticky_cutScene, value);
		}

		[Ordinal(94)] 
		[RED("lips_r_corner_up_in_sticky_cutScene")] 
		public CFloat Lips_r_corner_up_in_sticky_cutScene
		{
			get => GetProperty(ref _lips_r_corner_up_in_sticky_cutScene);
			set => SetProperty(ref _lips_r_corner_up_in_sticky_cutScene, value);
		}

		[Ordinal(95)] 
		[RED("lips_r_corner_up_out_sticky_cutScene")] 
		public CFloat Lips_r_corner_up_out_sticky_cutScene
		{
			get => GetProperty(ref _lips_r_corner_up_out_sticky_cutScene);
			set => SetProperty(ref _lips_r_corner_up_out_sticky_cutScene, value);
		}

		[Ordinal(96)] 
		[RED("lips_r_corner_dn_in_sticky_cutScene")] 
		public CFloat Lips_r_corner_dn_in_sticky_cutScene
		{
			get => GetProperty(ref _lips_r_corner_dn_in_sticky_cutScene);
			set => SetProperty(ref _lips_r_corner_dn_in_sticky_cutScene, value);
		}

		[Ordinal(97)] 
		[RED("lips_r_corner_dn_out_sticky_cutScene")] 
		public CFloat Lips_r_corner_dn_out_sticky_cutScene
		{
			get => GetProperty(ref _lips_r_corner_dn_out_sticky_cutScene);
			set => SetProperty(ref _lips_r_corner_dn_out_sticky_cutScene, value);
		}

		[Ordinal(98)] 
		[RED("cheek_l_suck")] 
		public CFloat Cheek_l_suck
		{
			get => GetProperty(ref _cheek_l_suck);
			set => SetProperty(ref _cheek_l_suck, value);
		}

		[Ordinal(99)] 
		[RED("cheek_r_suck")] 
		public CFloat Cheek_r_suck
		{
			get => GetProperty(ref _cheek_r_suck);
			set => SetProperty(ref _cheek_r_suck, value);
		}

		[Ordinal(100)] 
		[RED("cheek_l_puff")] 
		public CFloat Cheek_l_puff
		{
			get => GetProperty(ref _cheek_l_puff);
			set => SetProperty(ref _cheek_l_puff, value);
		}

		[Ordinal(101)] 
		[RED("cheek_r_puff")] 
		public CFloat Cheek_r_puff
		{
			get => GetProperty(ref _cheek_r_puff);
			set => SetProperty(ref _cheek_r_puff, value);
		}

		[Ordinal(102)] 
		[RED("jaw_mid_open")] 
		public CFloat Jaw_mid_open
		{
			get => GetProperty(ref _jaw_mid_open);
			set => SetProperty(ref _jaw_mid_open, value);
		}

		[Ordinal(103)] 
		[RED("jaw_mid_close")] 
		public CFloat Jaw_mid_close
		{
			get => GetProperty(ref _jaw_mid_close);
			set => SetProperty(ref _jaw_mid_close, value);
		}

		[Ordinal(104)] 
		[RED("jaw_mid_shift_l")] 
		public CFloat Jaw_mid_shift_l
		{
			get => GetProperty(ref _jaw_mid_shift_l);
			set => SetProperty(ref _jaw_mid_shift_l, value);
		}

		[Ordinal(105)] 
		[RED("jaw_mid_shift_r")] 
		public CFloat Jaw_mid_shift_r
		{
			get => GetProperty(ref _jaw_mid_shift_r);
			set => SetProperty(ref _jaw_mid_shift_r, value);
		}

		[Ordinal(106)] 
		[RED("jaw_mid_shift_fwd")] 
		public CFloat Jaw_mid_shift_fwd
		{
			get => GetProperty(ref _jaw_mid_shift_fwd);
			set => SetProperty(ref _jaw_mid_shift_fwd, value);
		}

		[Ordinal(107)] 
		[RED("jaw_mid_shift_back")] 
		public CFloat Jaw_mid_shift_back
		{
			get => GetProperty(ref _jaw_mid_shift_back);
			set => SetProperty(ref _jaw_mid_shift_back, value);
		}

		[Ordinal(108)] 
		[RED("jaw_mid_clench")] 
		public CFloat Jaw_mid_clench
		{
			get => GetProperty(ref _jaw_mid_clench);
			set => SetProperty(ref _jaw_mid_clench, value);
		}

		[Ordinal(109)] 
		[RED("neck_l_stretch")] 
		public CFloat Neck_l_stretch
		{
			get => GetProperty(ref _neck_l_stretch);
			set => SetProperty(ref _neck_l_stretch, value);
		}

		[Ordinal(110)] 
		[RED("neck_r_stretch")] 
		public CFloat Neck_r_stretch
		{
			get => GetProperty(ref _neck_r_stretch);
			set => SetProperty(ref _neck_r_stretch, value);
		}

		[Ordinal(111)] 
		[RED("neck_tighten")] 
		public CFloat Neck_tighten
		{
			get => GetProperty(ref _neck_tighten);
			set => SetProperty(ref _neck_tighten, value);
		}

		[Ordinal(112)] 
		[RED("neck_l_sternocleidomastoid_flex")] 
		public CFloat Neck_l_sternocleidomastoid_flex
		{
			get => GetProperty(ref _neck_l_sternocleidomastoid_flex);
			set => SetProperty(ref _neck_l_sternocleidomastoid_flex, value);
		}

		[Ordinal(113)] 
		[RED("neck_r_sternocleidomastoid_flex")] 
		public CFloat Neck_r_sternocleidomastoid_flex
		{
			get => GetProperty(ref _neck_r_sternocleidomastoid_flex);
			set => SetProperty(ref _neck_r_sternocleidomastoid_flex, value);
		}

		[Ordinal(114)] 
		[RED("neck_l_platysma_flex")] 
		public CFloat Neck_l_platysma_flex
		{
			get => GetProperty(ref _neck_l_platysma_flex);
			set => SetProperty(ref _neck_l_platysma_flex, value);
		}

		[Ordinal(115)] 
		[RED("neck_r_platysma_flex")] 
		public CFloat Neck_r_platysma_flex
		{
			get => GetProperty(ref _neck_r_platysma_flex);
			set => SetProperty(ref _neck_r_platysma_flex, value);
		}

		[Ordinal(116)] 
		[RED("neck_throat_adamsApple_up")] 
		public CFloat Neck_throat_adamsApple_up
		{
			get => GetProperty(ref _neck_throat_adamsApple_up);
			set => SetProperty(ref _neck_throat_adamsApple_up, value);
		}

		[Ordinal(117)] 
		[RED("neck_throat_adamsApple_dn")] 
		public CFloat Neck_throat_adamsApple_dn
		{
			get => GetProperty(ref _neck_throat_adamsApple_dn);
			set => SetProperty(ref _neck_throat_adamsApple_dn, value);
		}

		[Ordinal(118)] 
		[RED("neck_throat_compress")] 
		public CFloat Neck_throat_compress
		{
			get => GetProperty(ref _neck_throat_compress);
			set => SetProperty(ref _neck_throat_compress, value);
		}

		[Ordinal(119)] 
		[RED("neck_throat_open")] 
		public CFloat Neck_throat_open
		{
			get => GetProperty(ref _neck_throat_open);
			set => SetProperty(ref _neck_throat_open, value);
		}

		[Ordinal(120)] 
		[RED("neck_l_turn")] 
		public CFloat Neck_l_turn
		{
			get => GetProperty(ref _neck_l_turn);
			set => SetProperty(ref _neck_l_turn, value);
		}

		[Ordinal(121)] 
		[RED("neck_r_turn")] 
		public CFloat Neck_r_turn
		{
			get => GetProperty(ref _neck_r_turn);
			set => SetProperty(ref _neck_r_turn, value);
		}

		[Ordinal(122)] 
		[RED("neck_up_turn")] 
		public CFloat Neck_up_turn
		{
			get => GetProperty(ref _neck_up_turn);
			set => SetProperty(ref _neck_up_turn, value);
		}

		[Ordinal(123)] 
		[RED("neck_dn_turn")] 
		public CFloat Neck_dn_turn
		{
			get => GetProperty(ref _neck_dn_turn);
			set => SetProperty(ref _neck_dn_turn, value);
		}

		[Ordinal(124)] 
		[RED("neck_l_tilt")] 
		public CFloat Neck_l_tilt
		{
			get => GetProperty(ref _neck_l_tilt);
			set => SetProperty(ref _neck_l_tilt, value);
		}

		[Ordinal(125)] 
		[RED("neck_r_tilt")] 
		public CFloat Neck_r_tilt
		{
			get => GetProperty(ref _neck_r_tilt);
			set => SetProperty(ref _neck_r_tilt, value);
		}

		[Ordinal(126)] 
		[RED("head_neck_up_turn")] 
		public CFloat Head_neck_up_turn
		{
			get => GetProperty(ref _head_neck_up_turn);
			set => SetProperty(ref _head_neck_up_turn, value);
		}

		[Ordinal(127)] 
		[RED("head_neck_dn_turn")] 
		public CFloat Head_neck_dn_turn
		{
			get => GetProperty(ref _head_neck_dn_turn);
			set => SetProperty(ref _head_neck_dn_turn, value);
		}

		[Ordinal(128)] 
		[RED("head_neck_l_tilt")] 
		public CFloat Head_neck_l_tilt
		{
			get => GetProperty(ref _head_neck_l_tilt);
			set => SetProperty(ref _head_neck_l_tilt, value);
		}

		[Ordinal(129)] 
		[RED("head_neck_r_tilt")] 
		public CFloat Head_neck_r_tilt
		{
			get => GetProperty(ref _head_neck_r_tilt);
			set => SetProperty(ref _head_neck_r_tilt, value);
		}

		[Ordinal(130)] 
		[RED("ear_l_shift_up")] 
		public CFloat Ear_l_shift_up
		{
			get => GetProperty(ref _ear_l_shift_up);
			set => SetProperty(ref _ear_l_shift_up, value);
		}

		[Ordinal(131)] 
		[RED("ear_r_shift_up")] 
		public CFloat Ear_r_shift_up
		{
			get => GetProperty(ref _ear_r_shift_up);
			set => SetProperty(ref _ear_r_shift_up, value);
		}

		[Ordinal(132)] 
		[RED("sculp_mid_slide")] 
		public CFloat Sculp_mid_slide
		{
			get => GetProperty(ref _sculp_mid_slide);
			set => SetProperty(ref _sculp_mid_slide, value);
		}

		[Ordinal(133)] 
		[RED("face_gravity_fwd")] 
		public CFloat Face_gravity_fwd
		{
			get => GetProperty(ref _face_gravity_fwd);
			set => SetProperty(ref _face_gravity_fwd, value);
		}

		[Ordinal(134)] 
		[RED("face_gravity_back")] 
		public CFloat Face_gravity_back
		{
			get => GetProperty(ref _face_gravity_back);
			set => SetProperty(ref _face_gravity_back, value);
		}

		[Ordinal(135)] 
		[RED("face_gravity_l")] 
		public CFloat Face_gravity_l
		{
			get => GetProperty(ref _face_gravity_l);
			set => SetProperty(ref _face_gravity_l, value);
		}

		[Ordinal(136)] 
		[RED("face_gravity_r")] 
		public CFloat Face_gravity_r
		{
			get => GetProperty(ref _face_gravity_r);
			set => SetProperty(ref _face_gravity_r, value);
		}

		[Ordinal(137)] 
		[RED("tongue_mid_base_l")] 
		public CFloat Tongue_mid_base_l
		{
			get => GetProperty(ref _tongue_mid_base_l);
			set => SetProperty(ref _tongue_mid_base_l, value);
		}

		[Ordinal(138)] 
		[RED("tongue_mid_base_r")] 
		public CFloat Tongue_mid_base_r
		{
			get => GetProperty(ref _tongue_mid_base_r);
			set => SetProperty(ref _tongue_mid_base_r, value);
		}

		[Ordinal(139)] 
		[RED("tongue_mid_base_dn")] 
		public CFloat Tongue_mid_base_dn
		{
			get => GetProperty(ref _tongue_mid_base_dn);
			set => SetProperty(ref _tongue_mid_base_dn, value);
		}

		[Ordinal(140)] 
		[RED("tongue_mid_base_up")] 
		public CFloat Tongue_mid_base_up
		{
			get => GetProperty(ref _tongue_mid_base_up);
			set => SetProperty(ref _tongue_mid_base_up, value);
		}

		[Ordinal(141)] 
		[RED("tongue_mid_base_fwd")] 
		public CFloat Tongue_mid_base_fwd
		{
			get => GetProperty(ref _tongue_mid_base_fwd);
			set => SetProperty(ref _tongue_mid_base_fwd, value);
		}

		[Ordinal(142)] 
		[RED("tongue_mid_base_front")] 
		public CFloat Tongue_mid_base_front
		{
			get => GetProperty(ref _tongue_mid_base_front);
			set => SetProperty(ref _tongue_mid_base_front, value);
		}

		[Ordinal(143)] 
		[RED("tongue_mid_base_back")] 
		public CFloat Tongue_mid_base_back
		{
			get => GetProperty(ref _tongue_mid_base_back);
			set => SetProperty(ref _tongue_mid_base_back, value);
		}

		[Ordinal(144)] 
		[RED("tongue_mid_fwd")] 
		public CFloat Tongue_mid_fwd
		{
			get => GetProperty(ref _tongue_mid_fwd);
			set => SetProperty(ref _tongue_mid_fwd, value);
		}

		[Ordinal(145)] 
		[RED("tongue_mid_lift")] 
		public CFloat Tongue_mid_lift
		{
			get => GetProperty(ref _tongue_mid_lift);
			set => SetProperty(ref _tongue_mid_lift, value);
		}

		[Ordinal(146)] 
		[RED("tongue_mid_tip_l")] 
		public CFloat Tongue_mid_tip_l
		{
			get => GetProperty(ref _tongue_mid_tip_l);
			set => SetProperty(ref _tongue_mid_tip_l, value);
		}

		[Ordinal(147)] 
		[RED("tongue_mid_tip_r")] 
		public CFloat Tongue_mid_tip_r
		{
			get => GetProperty(ref _tongue_mid_tip_r);
			set => SetProperty(ref _tongue_mid_tip_r, value);
		}

		[Ordinal(148)] 
		[RED("tongue_mid_tip_dn")] 
		public CFloat Tongue_mid_tip_dn
		{
			get => GetProperty(ref _tongue_mid_tip_dn);
			set => SetProperty(ref _tongue_mid_tip_dn, value);
		}

		[Ordinal(149)] 
		[RED("tongue_mid_tip_up")] 
		public CFloat Tongue_mid_tip_up
		{
			get => GetProperty(ref _tongue_mid_tip_up);
			set => SetProperty(ref _tongue_mid_tip_up, value);
		}

		[Ordinal(150)] 
		[RED("tongue_mid_twist_l")] 
		public CFloat Tongue_mid_twist_l
		{
			get => GetProperty(ref _tongue_mid_twist_l);
			set => SetProperty(ref _tongue_mid_twist_l, value);
		}

		[Ordinal(151)] 
		[RED("tongue_mid_twist_r")] 
		public CFloat Tongue_mid_twist_r
		{
			get => GetProperty(ref _tongue_mid_twist_r);
			set => SetProperty(ref _tongue_mid_twist_r, value);
		}

		[Ordinal(152)] 
		[RED("tongue_mid_thick")] 
		public CFloat Tongue_mid_thick
		{
			get => GetProperty(ref _tongue_mid_thick);
			set => SetProperty(ref _tongue_mid_thick, value);
		}

		[Ordinal(153)] 
		[RED("nose_l_snearAnimOverrideWeight")] 
		public CFloat Nose_l_snearAnimOverrideWeight
		{
			get => GetProperty(ref _nose_l_snearAnimOverrideWeight);
			set => SetProperty(ref _nose_l_snearAnimOverrideWeight, value);
		}

		[Ordinal(154)] 
		[RED("nose_r_snearAnimOverrideWeight")] 
		public CFloat Nose_r_snearAnimOverrideWeight
		{
			get => GetProperty(ref _nose_r_snearAnimOverrideWeight);
			set => SetProperty(ref _nose_r_snearAnimOverrideWeight, value);
		}

		[Ordinal(155)] 
		[RED("lips_l_nasolabialDeepenerAnimOverrideWeight")] 
		public CFloat Lips_l_nasolabialDeepenerAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_nasolabialDeepenerAnimOverrideWeight);
			set => SetProperty(ref _lips_l_nasolabialDeepenerAnimOverrideWeight, value);
		}

		[Ordinal(156)] 
		[RED("lips_r_nasolabialDeepenerAnimOverrideWeight")] 
		public CFloat Lips_r_nasolabialDeepenerAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_nasolabialDeepenerAnimOverrideWeight);
			set => SetProperty(ref _lips_r_nasolabialDeepenerAnimOverrideWeight, value);
		}

		[Ordinal(157)] 
		[RED("lips_l_upper_raiseAnimOverrideWeight")] 
		public CFloat Lips_l_upper_raiseAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_upper_raiseAnimOverrideWeight);
			set => SetProperty(ref _lips_l_upper_raiseAnimOverrideWeight, value);
		}

		[Ordinal(158)] 
		[RED("lips_r_upper_raiseAnimOverrideWeight")] 
		public CFloat Lips_r_upper_raiseAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_upper_raiseAnimOverrideWeight);
			set => SetProperty(ref _lips_r_upper_raiseAnimOverrideWeight, value);
		}

		[Ordinal(159)] 
		[RED("lips_l_pullAnimOverrideWeight")] 
		public CFloat Lips_l_pullAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_pullAnimOverrideWeight);
			set => SetProperty(ref _lips_l_pullAnimOverrideWeight, value);
		}

		[Ordinal(160)] 
		[RED("lips_r_pullAnimOverrideWeight")] 
		public CFloat Lips_r_pullAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_pullAnimOverrideWeight);
			set => SetProperty(ref _lips_r_pullAnimOverrideWeight, value);
		}

		[Ordinal(161)] 
		[RED("lips_l_corner_upAnimOverrideWeight")] 
		public CFloat Lips_l_corner_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_upAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_upAnimOverrideWeight, value);
		}

		[Ordinal(162)] 
		[RED("lips_r_corner_upAnimOverrideWeight")] 
		public CFloat Lips_r_corner_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_upAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_upAnimOverrideWeight, value);
		}

		[Ordinal(163)] 
		[RED("lips_l_corner_wideAnimOverrideWeight")] 
		public CFloat Lips_l_corner_wideAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_wideAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_wideAnimOverrideWeight, value);
		}

		[Ordinal(164)] 
		[RED("lips_r_corner_wideAnimOverrideWeight")] 
		public CFloat Lips_r_corner_wideAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_wideAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_wideAnimOverrideWeight, value);
		}

		[Ordinal(165)] 
		[RED("lips_l_corner_stretchAnimOverrideWeight")] 
		public CFloat Lips_l_corner_stretchAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_stretchAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_stretchAnimOverrideWeight, value);
		}

		[Ordinal(166)] 
		[RED("lips_r_corner_stretchAnimOverrideWeight")] 
		public CFloat Lips_r_corner_stretchAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_stretchAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_stretchAnimOverrideWeight, value);
		}

		[Ordinal(167)] 
		[RED("lips_l_stretchAnimOverrideWeight")] 
		public CFloat Lips_l_stretchAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_stretchAnimOverrideWeight);
			set => SetProperty(ref _lips_l_stretchAnimOverrideWeight, value);
		}

		[Ordinal(168)] 
		[RED("lips_r_stretchAnimOverrideWeight")] 
		public CFloat Lips_r_stretchAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_stretchAnimOverrideWeight);
			set => SetProperty(ref _lips_r_stretchAnimOverrideWeight, value);
		}

		[Ordinal(169)] 
		[RED("lips_l_corner_sharp_upAnimOverrideWeight")] 
		public CFloat Lips_l_corner_sharp_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_sharp_upAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_sharp_upAnimOverrideWeight, value);
		}

		[Ordinal(170)] 
		[RED("lips_r_corner_sharp_upAnimOverrideWeight")] 
		public CFloat Lips_r_corner_sharp_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_sharp_upAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_sharp_upAnimOverrideWeight, value);
		}

		[Ordinal(171)] 
		[RED("lips_suck_upAnimOverrideWeight")] 
		public CFloat Lips_suck_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_suck_upAnimOverrideWeight);
			set => SetProperty(ref _lips_suck_upAnimOverrideWeight, value);
		}

		[Ordinal(172)] 
		[RED("lips_suck_dnAnimOverrideWeight")] 
		public CFloat Lips_suck_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_suck_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_suck_dnAnimOverrideWeight, value);
		}

		[Ordinal(173)] 
		[RED("lips_puff_upAnimOverrideWeight")] 
		public CFloat Lips_puff_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_puff_upAnimOverrideWeight);
			set => SetProperty(ref _lips_puff_upAnimOverrideWeight, value);
		}

		[Ordinal(174)] 
		[RED("lips_puff_dnAnimOverrideWeight")] 
		public CFloat Lips_puff_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_puff_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_puff_dnAnimOverrideWeight, value);
		}

		[Ordinal(175)] 
		[RED("lips_apart_upAnimOverrideWeight")] 
		public CFloat Lips_apart_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_apart_upAnimOverrideWeight);
			set => SetProperty(ref _lips_apart_upAnimOverrideWeight, value);
		}

		[Ordinal(176)] 
		[RED("lips_apart_dnAnimOverrideWeight")] 
		public CFloat Lips_apart_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_apart_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_apart_dnAnimOverrideWeight, value);
		}

		[Ordinal(177)] 
		[RED("lips_l_lower_raiseAnimOverrideWeight")] 
		public CFloat Lips_l_lower_raiseAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_lower_raiseAnimOverrideWeight);
			set => SetProperty(ref _lips_l_lower_raiseAnimOverrideWeight, value);
		}

		[Ordinal(178)] 
		[RED("lips_r_lower_raiseAnimOverrideWeight")] 
		public CFloat Lips_r_lower_raiseAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_lower_raiseAnimOverrideWeight);
			set => SetProperty(ref _lips_r_lower_raiseAnimOverrideWeight, value);
		}

		[Ordinal(179)] 
		[RED("lips_l_corner_dnAnimOverrideWeight")] 
		public CFloat Lips_l_corner_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_dnAnimOverrideWeight, value);
		}

		[Ordinal(180)] 
		[RED("lips_r_corner_dnAnimOverrideWeight")] 
		public CFloat Lips_r_corner_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_dnAnimOverrideWeight, value);
		}

		[Ordinal(181)] 
		[RED("lips_chin_raiseAnimOverrideWeight")] 
		public CFloat Lips_chin_raiseAnimOverrideWeight
		{
			get => GetProperty(ref _lips_chin_raiseAnimOverrideWeight);
			set => SetProperty(ref _lips_chin_raiseAnimOverrideWeight, value);
		}

		[Ordinal(182)] 
		[RED("lips_together_upAnimOverrideWeight")] 
		public CFloat Lips_together_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_together_upAnimOverrideWeight);
			set => SetProperty(ref _lips_together_upAnimOverrideWeight, value);
		}

		[Ordinal(183)] 
		[RED("lips_together_dnAnimOverrideWeight")] 
		public CFloat Lips_together_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_together_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_together_dnAnimOverrideWeight, value);
		}

		[Ordinal(184)] 
		[RED("lips_l_purseAnimOverrideWeight")] 
		public CFloat Lips_l_purseAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_purseAnimOverrideWeight);
			set => SetProperty(ref _lips_l_purseAnimOverrideWeight, value);
		}

		[Ordinal(185)] 
		[RED("lips_r_purseAnimOverrideWeight")] 
		public CFloat Lips_r_purseAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_purseAnimOverrideWeight);
			set => SetProperty(ref _lips_r_purseAnimOverrideWeight, value);
		}

		[Ordinal(186)] 
		[RED("lips_l_funnelAnimOverrideWeight")] 
		public CFloat Lips_l_funnelAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_funnelAnimOverrideWeight);
			set => SetProperty(ref _lips_l_funnelAnimOverrideWeight, value);
		}

		[Ordinal(187)] 
		[RED("lips_r_funnelAnimOverrideWeight")] 
		public CFloat Lips_r_funnelAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_funnelAnimOverrideWeight);
			set => SetProperty(ref _lips_r_funnelAnimOverrideWeight, value);
		}

		[Ordinal(188)] 
		[RED("lips_tighten_upAnimOverrideWeight")] 
		public CFloat Lips_tighten_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_tighten_upAnimOverrideWeight);
			set => SetProperty(ref _lips_tighten_upAnimOverrideWeight, value);
		}

		[Ordinal(189)] 
		[RED("lips_tighten_dnAnimOverrideWeight")] 
		public CFloat Lips_tighten_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_tighten_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_tighten_dnAnimOverrideWeight, value);
		}

		[Ordinal(190)] 
		[RED("lips_mid_shift_lAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_lAnimOverrideWeight
		{
			get => GetProperty(ref _lips_mid_shift_lAnimOverrideWeight);
			set => SetProperty(ref _lips_mid_shift_lAnimOverrideWeight, value);
		}

		[Ordinal(191)] 
		[RED("lips_mid_shift_rAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_rAnimOverrideWeight
		{
			get => GetProperty(ref _lips_mid_shift_rAnimOverrideWeight);
			set => SetProperty(ref _lips_mid_shift_rAnimOverrideWeight, value);
		}

		[Ordinal(192)] 
		[RED("lips_mid_shift_upAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_upAnimOverrideWeight
		{
			get => GetProperty(ref _lips_mid_shift_upAnimOverrideWeight);
			set => SetProperty(ref _lips_mid_shift_upAnimOverrideWeight, value);
		}

		[Ordinal(193)] 
		[RED("lips_mid_shift_dnAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_dnAnimOverrideWeight
		{
			get => GetProperty(ref _lips_mid_shift_dnAnimOverrideWeight);
			set => SetProperty(ref _lips_mid_shift_dnAnimOverrideWeight, value);
		}

		[Ordinal(194)] 
		[RED("cheek_l_puffAnimOverrideWeight")] 
		public CFloat Cheek_l_puffAnimOverrideWeight
		{
			get => GetProperty(ref _cheek_l_puffAnimOverrideWeight);
			set => SetProperty(ref _cheek_l_puffAnimOverrideWeight, value);
		}

		[Ordinal(195)] 
		[RED("cheek_r_puffAnimOverrideWeight")] 
		public CFloat Cheek_r_puffAnimOverrideWeight
		{
			get => GetProperty(ref _cheek_r_puffAnimOverrideWeight);
			set => SetProperty(ref _cheek_r_puffAnimOverrideWeight, value);
		}

		[Ordinal(196)] 
		[RED("jaw_mid_openAnimOverrideWeight")] 
		public CFloat Jaw_mid_openAnimOverrideWeight
		{
			get => GetProperty(ref _jaw_mid_openAnimOverrideWeight);
			set => SetProperty(ref _jaw_mid_openAnimOverrideWeight, value);
		}

		[Ordinal(197)] 
		[RED("jaw_mid_closeAnimOverrideWeight")] 
		public CFloat Jaw_mid_closeAnimOverrideWeight
		{
			get => GetProperty(ref _jaw_mid_closeAnimOverrideWeight);
			set => SetProperty(ref _jaw_mid_closeAnimOverrideWeight, value);
		}

		[Ordinal(198)] 
		[RED("jaw_mid_shift_lAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_lAnimOverrideWeight
		{
			get => GetProperty(ref _jaw_mid_shift_lAnimOverrideWeight);
			set => SetProperty(ref _jaw_mid_shift_lAnimOverrideWeight, value);
		}

		[Ordinal(199)] 
		[RED("jaw_mid_shift_rAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_rAnimOverrideWeight
		{
			get => GetProperty(ref _jaw_mid_shift_rAnimOverrideWeight);
			set => SetProperty(ref _jaw_mid_shift_rAnimOverrideWeight, value);
		}

		[Ordinal(200)] 
		[RED("jaw_mid_shift_fwdAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_fwdAnimOverrideWeight
		{
			get => GetProperty(ref _jaw_mid_shift_fwdAnimOverrideWeight);
			set => SetProperty(ref _jaw_mid_shift_fwdAnimOverrideWeight, value);
		}

		[Ordinal(201)] 
		[RED("jaw_mid_shift_backAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_backAnimOverrideWeight
		{
			get => GetProperty(ref _jaw_mid_shift_backAnimOverrideWeight);
			set => SetProperty(ref _jaw_mid_shift_backAnimOverrideWeight, value);
		}

		[Ordinal(202)] 
		[RED("jaw_mid_clenchAnimOverrideWeight")] 
		public CFloat Jaw_mid_clenchAnimOverrideWeight
		{
			get => GetProperty(ref _jaw_mid_clenchAnimOverrideWeight);
			set => SetProperty(ref _jaw_mid_clenchAnimOverrideWeight, value);
		}

		[Ordinal(203)] 
		[RED("neck_l_stretchAnimOverrideWeight")] 
		public CFloat Neck_l_stretchAnimOverrideWeight
		{
			get => GetProperty(ref _neck_l_stretchAnimOverrideWeight);
			set => SetProperty(ref _neck_l_stretchAnimOverrideWeight, value);
		}

		[Ordinal(204)] 
		[RED("neck_r_stretchAnimOverrideWeight")] 
		public CFloat Neck_r_stretchAnimOverrideWeight
		{
			get => GetProperty(ref _neck_r_stretchAnimOverrideWeight);
			set => SetProperty(ref _neck_r_stretchAnimOverrideWeight, value);
		}

		[Ordinal(205)] 
		[RED("neck_tightenAnimOverrideWeight")] 
		public CFloat Neck_tightenAnimOverrideWeight
		{
			get => GetProperty(ref _neck_tightenAnimOverrideWeight);
			set => SetProperty(ref _neck_tightenAnimOverrideWeight, value);
		}

		[Ordinal(206)] 
		[RED("neck_l_sternocleidomastoid_flexAnimOverrideWeight")] 
		public CFloat Neck_l_sternocleidomastoid_flexAnimOverrideWeight
		{
			get => GetProperty(ref _neck_l_sternocleidomastoid_flexAnimOverrideWeight);
			set => SetProperty(ref _neck_l_sternocleidomastoid_flexAnimOverrideWeight, value);
		}

		[Ordinal(207)] 
		[RED("neck_r_sternocleidomastoid_flexAnimOverrideWeight")] 
		public CFloat Neck_r_sternocleidomastoid_flexAnimOverrideWeight
		{
			get => GetProperty(ref _neck_r_sternocleidomastoid_flexAnimOverrideWeight);
			set => SetProperty(ref _neck_r_sternocleidomastoid_flexAnimOverrideWeight, value);
		}

		[Ordinal(208)] 
		[RED("neck_l_platysma_flexAnimOverrideWeight")] 
		public CFloat Neck_l_platysma_flexAnimOverrideWeight
		{
			get => GetProperty(ref _neck_l_platysma_flexAnimOverrideWeight);
			set => SetProperty(ref _neck_l_platysma_flexAnimOverrideWeight, value);
		}

		[Ordinal(209)] 
		[RED("neck_r_platysma_flexAnimOverrideWeight")] 
		public CFloat Neck_r_platysma_flexAnimOverrideWeight
		{
			get => GetProperty(ref _neck_r_platysma_flexAnimOverrideWeight);
			set => SetProperty(ref _neck_r_platysma_flexAnimOverrideWeight, value);
		}

		[Ordinal(210)] 
		[RED("neck_throat_adamsApple_upAnimOverrideWeight")] 
		public CFloat Neck_throat_adamsApple_upAnimOverrideWeight
		{
			get => GetProperty(ref _neck_throat_adamsApple_upAnimOverrideWeight);
			set => SetProperty(ref _neck_throat_adamsApple_upAnimOverrideWeight, value);
		}

		[Ordinal(211)] 
		[RED("neck_throat_adamsApple_dnAnimOverrideWeight")] 
		public CFloat Neck_throat_adamsApple_dnAnimOverrideWeight
		{
			get => GetProperty(ref _neck_throat_adamsApple_dnAnimOverrideWeight);
			set => SetProperty(ref _neck_throat_adamsApple_dnAnimOverrideWeight, value);
		}

		[Ordinal(212)] 
		[RED("neck_throat_compressAnimOverrideWeight")] 
		public CFloat Neck_throat_compressAnimOverrideWeight
		{
			get => GetProperty(ref _neck_throat_compressAnimOverrideWeight);
			set => SetProperty(ref _neck_throat_compressAnimOverrideWeight, value);
		}

		[Ordinal(213)] 
		[RED("neck_throat_openAnimOverrideWeight")] 
		public CFloat Neck_throat_openAnimOverrideWeight
		{
			get => GetProperty(ref _neck_throat_openAnimOverrideWeight);
			set => SetProperty(ref _neck_throat_openAnimOverrideWeight, value);
		}

		[Ordinal(214)] 
		[RED("lips_corner_stickyAnimOverrideWeight")] 
		public CFloat Lips_corner_stickyAnimOverrideWeight
		{
			get => GetProperty(ref _lips_corner_stickyAnimOverrideWeight);
			set => SetProperty(ref _lips_corner_stickyAnimOverrideWeight, value);
		}

		[Ordinal(215)] 
		[RED("lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(216)] 
		[RED("lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(217)] 
		[RED("lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(218)] 
		[RED("lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(219)] 
		[RED("lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(220)] 
		[RED("lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(221)] 
		[RED("lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(222)] 
		[RED("lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight
		{
			get => GetProperty(ref _lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight);
			set => SetProperty(ref _lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight, value);
		}

		[Ordinal(223)] 
		[RED("tongue_mid_base_lAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_lAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_base_lAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_base_lAnimOverrideWeight, value);
		}

		[Ordinal(224)] 
		[RED("tongue_mid_base_rAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_rAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_base_rAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_base_rAnimOverrideWeight, value);
		}

		[Ordinal(225)] 
		[RED("tongue_mid_base_dnAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_dnAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_base_dnAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_base_dnAnimOverrideWeight, value);
		}

		[Ordinal(226)] 
		[RED("tongue_mid_base_upAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_upAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_base_upAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_base_upAnimOverrideWeight, value);
		}

		[Ordinal(227)] 
		[RED("tongue_mid_base_fwdAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_fwdAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_base_fwdAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_base_fwdAnimOverrideWeight, value);
		}

		[Ordinal(228)] 
		[RED("tongue_mid_base_frontAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_frontAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_base_frontAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_base_frontAnimOverrideWeight, value);
		}

		[Ordinal(229)] 
		[RED("tongue_mid_base_backAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_backAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_base_backAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_base_backAnimOverrideWeight, value);
		}

		[Ordinal(230)] 
		[RED("tongue_mid_fwdAnimOverrideWeight")] 
		public CFloat Tongue_mid_fwdAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_fwdAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_fwdAnimOverrideWeight, value);
		}

		[Ordinal(231)] 
		[RED("tongue_mid_liftAnimOverrideWeight")] 
		public CFloat Tongue_mid_liftAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_liftAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_liftAnimOverrideWeight, value);
		}

		[Ordinal(232)] 
		[RED("tongue_mid_tip_lAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_lAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_tip_lAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_tip_lAnimOverrideWeight, value);
		}

		[Ordinal(233)] 
		[RED("tongue_mid_tip_rAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_rAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_tip_rAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_tip_rAnimOverrideWeight, value);
		}

		[Ordinal(234)] 
		[RED("tongue_mid_tip_dnAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_dnAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_tip_dnAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_tip_dnAnimOverrideWeight, value);
		}

		[Ordinal(235)] 
		[RED("tongue_mid_tip_upAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_upAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_tip_upAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_tip_upAnimOverrideWeight, value);
		}

		[Ordinal(236)] 
		[RED("tongue_mid_twist_lAnimOverrideWeight")] 
		public CFloat Tongue_mid_twist_lAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_twist_lAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_twist_lAnimOverrideWeight, value);
		}

		[Ordinal(237)] 
		[RED("tongue_mid_twist_rAnimOverrideWeight")] 
		public CFloat Tongue_mid_twist_rAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_twist_rAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_twist_rAnimOverrideWeight, value);
		}

		[Ordinal(238)] 
		[RED("tongue_mid_thickAnimOverrideWeight")] 
		public CFloat Tongue_mid_thickAnimOverrideWeight
		{
			get => GetProperty(ref _tongue_mid_thickAnimOverrideWeight);
			set => SetProperty(ref _tongue_mid_thickAnimOverrideWeight, value);
		}

		[Ordinal(239)] 
		[RED("eye_l_blinkLipsyncPoseOutput")] 
		public CFloat Eye_l_blinkLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_blinkLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_blinkLipsyncPoseOutput, value);
		}

		[Ordinal(240)] 
		[RED("eye_r_blinkLipsyncPoseOutput")] 
		public CFloat Eye_r_blinkLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_blinkLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_blinkLipsyncPoseOutput, value);
		}

		[Ordinal(241)] 
		[RED("eye_l_widenLipsyncPoseOutput")] 
		public CFloat Eye_l_widenLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_widenLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_widenLipsyncPoseOutput, value);
		}

		[Ordinal(242)] 
		[RED("eye_r_widenLipsyncPoseOutput")] 
		public CFloat Eye_r_widenLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_widenLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_widenLipsyncPoseOutput, value);
		}

		[Ordinal(243)] 
		[RED("eye_l_dir_upLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_upLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_dir_upLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_dir_upLipsyncPoseOutput, value);
		}

		[Ordinal(244)] 
		[RED("eye_l_dir_dnLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_dir_dnLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_dir_dnLipsyncPoseOutput, value);
		}

		[Ordinal(245)] 
		[RED("eye_l_dir_inLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_inLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_dir_inLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_dir_inLipsyncPoseOutput, value);
		}

		[Ordinal(246)] 
		[RED("eye_l_dir_outLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_outLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_dir_outLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_dir_outLipsyncPoseOutput, value);
		}

		[Ordinal(247)] 
		[RED("eye_r_dir_upLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_upLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_dir_upLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_dir_upLipsyncPoseOutput, value);
		}

		[Ordinal(248)] 
		[RED("eye_r_dir_dnLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_dir_dnLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_dir_dnLipsyncPoseOutput, value);
		}

		[Ordinal(249)] 
		[RED("eye_r_dir_inLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_inLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_dir_inLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_dir_inLipsyncPoseOutput, value);
		}

		[Ordinal(250)] 
		[RED("eye_r_dir_outLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_outLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_dir_outLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_dir_outLipsyncPoseOutput, value);
		}

		[Ordinal(251)] 
		[RED("eye_l_pupil_narrowLipsyncPoseOutput")] 
		public CFloat Eye_l_pupil_narrowLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_pupil_narrowLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_pupil_narrowLipsyncPoseOutput, value);
		}

		[Ordinal(252)] 
		[RED("eye_r_pupil_narrowLipsyncPoseOutput")] 
		public CFloat Eye_r_pupil_narrowLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_pupil_narrowLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_pupil_narrowLipsyncPoseOutput, value);
		}

		[Ordinal(253)] 
		[RED("eye_l_pupil_wideLipsyncPoseOutput")] 
		public CFloat Eye_l_pupil_wideLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_pupil_wideLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_pupil_wideLipsyncPoseOutput, value);
		}

		[Ordinal(254)] 
		[RED("eye_r_pupil_wideLipsyncPoseOutput")] 
		public CFloat Eye_r_pupil_wideLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_pupil_wideLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_pupil_wideLipsyncPoseOutput, value);
		}

		[Ordinal(255)] 
		[RED("eye_l_brows_raise_inLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_raise_inLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_brows_raise_inLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_brows_raise_inLipsyncPoseOutput, value);
		}

		[Ordinal(256)] 
		[RED("eye_r_brows_raise_inLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_raise_inLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_brows_raise_inLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_brows_raise_inLipsyncPoseOutput, value);
		}

		[Ordinal(257)] 
		[RED("eye_l_brows_raise_outLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_raise_outLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_brows_raise_outLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_brows_raise_outLipsyncPoseOutput, value);
		}

		[Ordinal(258)] 
		[RED("eye_r_brows_raise_outLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_raise_outLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_brows_raise_outLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_brows_raise_outLipsyncPoseOutput, value);
		}

		[Ordinal(259)] 
		[RED("eye_l_brows_lowerLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_lowerLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_brows_lowerLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_brows_lowerLipsyncPoseOutput, value);
		}

		[Ordinal(260)] 
		[RED("eye_r_brows_lowerLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_lowerLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_brows_lowerLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_brows_lowerLipsyncPoseOutput, value);
		}

		[Ordinal(261)] 
		[RED("eye_l_brows_lateralLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_lateralLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_brows_lateralLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_brows_lateralLipsyncPoseOutput, value);
		}

		[Ordinal(262)] 
		[RED("eye_r_brows_lateralLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_lateralLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_brows_lateralLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_brows_lateralLipsyncPoseOutput, value);
		}

		[Ordinal(263)] 
		[RED("eye_l_oculi_squint_innerLipsyncPoseOutput")] 
		public CFloat Eye_l_oculi_squint_innerLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_oculi_squint_innerLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_oculi_squint_innerLipsyncPoseOutput, value);
		}

		[Ordinal(264)] 
		[RED("eye_r_oculi_squint_innerLipsyncPoseOutput")] 
		public CFloat Eye_r_oculi_squint_innerLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_oculi_squint_innerLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_oculi_squint_innerLipsyncPoseOutput, value);
		}

		[Ordinal(265)] 
		[RED("eye_l_oculi_squint_outer_lowerLipsyncPoseOutput")] 
		public CFloat Eye_l_oculi_squint_outer_lowerLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_oculi_squint_outer_lowerLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_oculi_squint_outer_lowerLipsyncPoseOutput, value);
		}

		[Ordinal(266)] 
		[RED("eye_r_oculi_squint_outer_lowerLipsyncPoseOutput")] 
		public CFloat Eye_r_oculi_squint_outer_lowerLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_oculi_squint_outer_lowerLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_oculi_squint_outer_lowerLipsyncPoseOutput, value);
		}

		[Ordinal(267)] 
		[RED("eye_l_oculi_squint_outer_upperLipsyncPoseOutput")] 
		public CFloat Eye_l_oculi_squint_outer_upperLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_l_oculi_squint_outer_upperLipsyncPoseOutput);
			set => SetProperty(ref _eye_l_oculi_squint_outer_upperLipsyncPoseOutput, value);
		}

		[Ordinal(268)] 
		[RED("eye_r_oculi_squint_outer_upperLipsyncPoseOutput")] 
		public CFloat Eye_r_oculi_squint_outer_upperLipsyncPoseOutput
		{
			get => GetProperty(ref _eye_r_oculi_squint_outer_upperLipsyncPoseOutput);
			set => SetProperty(ref _eye_r_oculi_squint_outer_upperLipsyncPoseOutput, value);
		}

		[Ordinal(269)] 
		[RED("nose_l_compressLipsyncPoseOutput")] 
		public CFloat Nose_l_compressLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_l_compressLipsyncPoseOutput);
			set => SetProperty(ref _nose_l_compressLipsyncPoseOutput, value);
		}

		[Ordinal(270)] 
		[RED("nose_r_compressLipsyncPoseOutput")] 
		public CFloat Nose_r_compressLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_r_compressLipsyncPoseOutput);
			set => SetProperty(ref _nose_r_compressLipsyncPoseOutput, value);
		}

		[Ordinal(271)] 
		[RED("nose_l_breathe_inLipsyncPoseOutput")] 
		public CFloat Nose_l_breathe_inLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_l_breathe_inLipsyncPoseOutput);
			set => SetProperty(ref _nose_l_breathe_inLipsyncPoseOutput, value);
		}

		[Ordinal(272)] 
		[RED("nose_r_breathe_inLipsyncPoseOutput")] 
		public CFloat Nose_r_breathe_inLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_r_breathe_inLipsyncPoseOutput);
			set => SetProperty(ref _nose_r_breathe_inLipsyncPoseOutput, value);
		}

		[Ordinal(273)] 
		[RED("nose_l_breathe_outLipsyncPoseOutput")] 
		public CFloat Nose_l_breathe_outLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_l_breathe_outLipsyncPoseOutput);
			set => SetProperty(ref _nose_l_breathe_outLipsyncPoseOutput, value);
		}

		[Ordinal(274)] 
		[RED("nose_r_breathe_outLipsyncPoseOutput")] 
		public CFloat Nose_r_breathe_outLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_r_breathe_outLipsyncPoseOutput);
			set => SetProperty(ref _nose_r_breathe_outLipsyncPoseOutput, value);
		}

		[Ordinal(275)] 
		[RED("nose_l_snearLipsyncPoseOutput")] 
		public CFloat Nose_l_snearLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_l_snearLipsyncPoseOutput);
			set => SetProperty(ref _nose_l_snearLipsyncPoseOutput, value);
		}

		[Ordinal(276)] 
		[RED("nose_r_snearLipsyncPoseOutput")] 
		public CFloat Nose_r_snearLipsyncPoseOutput
		{
			get => GetProperty(ref _nose_r_snearLipsyncPoseOutput);
			set => SetProperty(ref _nose_r_snearLipsyncPoseOutput, value);
		}

		[Ordinal(277)] 
		[RED("lips_l_nasolabialDeepenerLipsyncPoseOutput")] 
		public CFloat Lips_l_nasolabialDeepenerLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_nasolabialDeepenerLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_nasolabialDeepenerLipsyncPoseOutput, value);
		}

		[Ordinal(278)] 
		[RED("lips_r_nasolabialDeepenerLipsyncPoseOutput")] 
		public CFloat Lips_r_nasolabialDeepenerLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_nasolabialDeepenerLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_nasolabialDeepenerLipsyncPoseOutput, value);
		}

		[Ordinal(279)] 
		[RED("lips_l_upper_raiseLipsyncPoseOutput")] 
		public CFloat Lips_l_upper_raiseLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_upper_raiseLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_upper_raiseLipsyncPoseOutput, value);
		}

		[Ordinal(280)] 
		[RED("lips_r_upper_raiseLipsyncPoseOutput")] 
		public CFloat Lips_r_upper_raiseLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_upper_raiseLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_upper_raiseLipsyncPoseOutput, value);
		}

		[Ordinal(281)] 
		[RED("lips_l_pullLipsyncPoseOutput")] 
		public CFloat Lips_l_pullLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_pullLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_pullLipsyncPoseOutput, value);
		}

		[Ordinal(282)] 
		[RED("lips_r_pullLipsyncPoseOutput")] 
		public CFloat Lips_r_pullLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_pullLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_pullLipsyncPoseOutput, value);
		}

		[Ordinal(283)] 
		[RED("lips_l_corner_upLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_upLipsyncPoseOutput, value);
		}

		[Ordinal(284)] 
		[RED("lips_r_corner_upLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_upLipsyncPoseOutput, value);
		}

		[Ordinal(285)] 
		[RED("lips_l_corner_wideLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_wideLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_wideLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_wideLipsyncPoseOutput, value);
		}

		[Ordinal(286)] 
		[RED("lips_r_corner_wideLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_wideLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_wideLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_wideLipsyncPoseOutput, value);
		}

		[Ordinal(287)] 
		[RED("lips_l_corner_stretchLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_stretchLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_stretchLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_stretchLipsyncPoseOutput, value);
		}

		[Ordinal(288)] 
		[RED("lips_r_corner_stretchLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_stretchLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_stretchLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_stretchLipsyncPoseOutput, value);
		}

		[Ordinal(289)] 
		[RED("lips_l_stretchLipsyncPoseOutput")] 
		public CFloat Lips_l_stretchLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_stretchLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_stretchLipsyncPoseOutput, value);
		}

		[Ordinal(290)] 
		[RED("lips_r_stretchLipsyncPoseOutput")] 
		public CFloat Lips_r_stretchLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_stretchLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_stretchLipsyncPoseOutput, value);
		}

		[Ordinal(291)] 
		[RED("lips_l_corner_sharp_upLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_sharp_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_sharp_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_sharp_upLipsyncPoseOutput, value);
		}

		[Ordinal(292)] 
		[RED("lips_r_corner_sharp_upLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_sharp_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_sharp_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_sharp_upLipsyncPoseOutput, value);
		}

		[Ordinal(293)] 
		[RED("lips_suck_upLipsyncPoseOutput")] 
		public CFloat Lips_suck_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_suck_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_suck_upLipsyncPoseOutput, value);
		}

		[Ordinal(294)] 
		[RED("lips_suck_dnLipsyncPoseOutput")] 
		public CFloat Lips_suck_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_suck_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_suck_dnLipsyncPoseOutput, value);
		}

		[Ordinal(295)] 
		[RED("lips_puff_upLipsyncPoseOutput")] 
		public CFloat Lips_puff_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_puff_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_puff_upLipsyncPoseOutput, value);
		}

		[Ordinal(296)] 
		[RED("lips_puff_dnLipsyncPoseOutput")] 
		public CFloat Lips_puff_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_puff_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_puff_dnLipsyncPoseOutput, value);
		}

		[Ordinal(297)] 
		[RED("lips_apart_upLipsyncPoseOutput")] 
		public CFloat Lips_apart_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_apart_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_apart_upLipsyncPoseOutput, value);
		}

		[Ordinal(298)] 
		[RED("lips_apart_dnLipsyncPoseOutput")] 
		public CFloat Lips_apart_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_apart_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_apart_dnLipsyncPoseOutput, value);
		}

		[Ordinal(299)] 
		[RED("lips_l_lower_raiseLipsyncPoseOutput")] 
		public CFloat Lips_l_lower_raiseLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_lower_raiseLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_lower_raiseLipsyncPoseOutput, value);
		}

		[Ordinal(300)] 
		[RED("lips_r_lower_raiseLipsyncPoseOutput")] 
		public CFloat Lips_r_lower_raiseLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_lower_raiseLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_lower_raiseLipsyncPoseOutput, value);
		}

		[Ordinal(301)] 
		[RED("lips_l_corner_dnLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_dnLipsyncPoseOutput, value);
		}

		[Ordinal(302)] 
		[RED("lips_r_corner_dnLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_dnLipsyncPoseOutput, value);
		}

		[Ordinal(303)] 
		[RED("lips_chin_raiseLipsyncPoseOutput")] 
		public CFloat Lips_chin_raiseLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_chin_raiseLipsyncPoseOutput);
			set => SetProperty(ref _lips_chin_raiseLipsyncPoseOutput, value);
		}

		[Ordinal(304)] 
		[RED("lips_together_upLipsyncPoseOutput")] 
		public CFloat Lips_together_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_together_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_together_upLipsyncPoseOutput, value);
		}

		[Ordinal(305)] 
		[RED("lips_together_dnLipsyncPoseOutput")] 
		public CFloat Lips_together_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_together_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_together_dnLipsyncPoseOutput, value);
		}

		[Ordinal(306)] 
		[RED("lips_l_purseLipsyncPoseOutput")] 
		public CFloat Lips_l_purseLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_purseLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_purseLipsyncPoseOutput, value);
		}

		[Ordinal(307)] 
		[RED("lips_r_purseLipsyncPoseOutput")] 
		public CFloat Lips_r_purseLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_purseLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_purseLipsyncPoseOutput, value);
		}

		[Ordinal(308)] 
		[RED("lips_l_funnelLipsyncPoseOutput")] 
		public CFloat Lips_l_funnelLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_funnelLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_funnelLipsyncPoseOutput, value);
		}

		[Ordinal(309)] 
		[RED("lips_r_funnelLipsyncPoseOutput")] 
		public CFloat Lips_r_funnelLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_funnelLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_funnelLipsyncPoseOutput, value);
		}

		[Ordinal(310)] 
		[RED("lips_tighten_upLipsyncPoseOutput")] 
		public CFloat Lips_tighten_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_tighten_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_tighten_upLipsyncPoseOutput, value);
		}

		[Ordinal(311)] 
		[RED("lips_tighten_dnLipsyncPoseOutput")] 
		public CFloat Lips_tighten_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_tighten_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_tighten_dnLipsyncPoseOutput, value);
		}

		[Ordinal(312)] 
		[RED("lips_mid_shift_lLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_lLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_mid_shift_lLipsyncPoseOutput);
			set => SetProperty(ref _lips_mid_shift_lLipsyncPoseOutput, value);
		}

		[Ordinal(313)] 
		[RED("lips_mid_shift_rLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_rLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_mid_shift_rLipsyncPoseOutput);
			set => SetProperty(ref _lips_mid_shift_rLipsyncPoseOutput, value);
		}

		[Ordinal(314)] 
		[RED("lips_mid_shift_upLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_upLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_mid_shift_upLipsyncPoseOutput);
			set => SetProperty(ref _lips_mid_shift_upLipsyncPoseOutput, value);
		}

		[Ordinal(315)] 
		[RED("lips_mid_shift_dnLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_mid_shift_dnLipsyncPoseOutput);
			set => SetProperty(ref _lips_mid_shift_dnLipsyncPoseOutput, value);
		}

		[Ordinal(316)] 
		[RED("lips_corner_stickyLipsyncPoseOutput")] 
		public CFloat Lips_corner_stickyLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_corner_stickyLipsyncPoseOutput);
			set => SetProperty(ref _lips_corner_stickyLipsyncPoseOutput, value);
		}

		[Ordinal(317)] 
		[RED("lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(318)] 
		[RED("lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(319)] 
		[RED("lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(320)] 
		[RED("lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(321)] 
		[RED("lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(322)] 
		[RED("lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(323)] 
		[RED("lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(324)] 
		[RED("lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput
		{
			get => GetProperty(ref _lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput);
			set => SetProperty(ref _lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput, value);
		}

		[Ordinal(325)] 
		[RED("cheek_l_suckLipsyncPoseOutput")] 
		public CFloat Cheek_l_suckLipsyncPoseOutput
		{
			get => GetProperty(ref _cheek_l_suckLipsyncPoseOutput);
			set => SetProperty(ref _cheek_l_suckLipsyncPoseOutput, value);
		}

		[Ordinal(326)] 
		[RED("cheek_r_suckLipsyncPoseOutput")] 
		public CFloat Cheek_r_suckLipsyncPoseOutput
		{
			get => GetProperty(ref _cheek_r_suckLipsyncPoseOutput);
			set => SetProperty(ref _cheek_r_suckLipsyncPoseOutput, value);
		}

		[Ordinal(327)] 
		[RED("cheek_l_puffLipsyncPoseOutput")] 
		public CFloat Cheek_l_puffLipsyncPoseOutput
		{
			get => GetProperty(ref _cheek_l_puffLipsyncPoseOutput);
			set => SetProperty(ref _cheek_l_puffLipsyncPoseOutput, value);
		}

		[Ordinal(328)] 
		[RED("cheek_r_puffLipsyncPoseOutput")] 
		public CFloat Cheek_r_puffLipsyncPoseOutput
		{
			get => GetProperty(ref _cheek_r_puffLipsyncPoseOutput);
			set => SetProperty(ref _cheek_r_puffLipsyncPoseOutput, value);
		}

		[Ordinal(329)] 
		[RED("jaw_mid_openLipsyncPoseOutput")] 
		public CFloat Jaw_mid_openLipsyncPoseOutput
		{
			get => GetProperty(ref _jaw_mid_openLipsyncPoseOutput);
			set => SetProperty(ref _jaw_mid_openLipsyncPoseOutput, value);
		}

		[Ordinal(330)] 
		[RED("jaw_mid_closeLipsyncPoseOutput")] 
		public CFloat Jaw_mid_closeLipsyncPoseOutput
		{
			get => GetProperty(ref _jaw_mid_closeLipsyncPoseOutput);
			set => SetProperty(ref _jaw_mid_closeLipsyncPoseOutput, value);
		}

		[Ordinal(331)] 
		[RED("jaw_mid_shift_lLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_lLipsyncPoseOutput
		{
			get => GetProperty(ref _jaw_mid_shift_lLipsyncPoseOutput);
			set => SetProperty(ref _jaw_mid_shift_lLipsyncPoseOutput, value);
		}

		[Ordinal(332)] 
		[RED("jaw_mid_shift_rLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_rLipsyncPoseOutput
		{
			get => GetProperty(ref _jaw_mid_shift_rLipsyncPoseOutput);
			set => SetProperty(ref _jaw_mid_shift_rLipsyncPoseOutput, value);
		}

		[Ordinal(333)] 
		[RED("jaw_mid_shift_fwdLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_fwdLipsyncPoseOutput
		{
			get => GetProperty(ref _jaw_mid_shift_fwdLipsyncPoseOutput);
			set => SetProperty(ref _jaw_mid_shift_fwdLipsyncPoseOutput, value);
		}

		[Ordinal(334)] 
		[RED("jaw_mid_shift_backLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_backLipsyncPoseOutput
		{
			get => GetProperty(ref _jaw_mid_shift_backLipsyncPoseOutput);
			set => SetProperty(ref _jaw_mid_shift_backLipsyncPoseOutput, value);
		}

		[Ordinal(335)] 
		[RED("jaw_mid_clenchLipsyncPoseOutput")] 
		public CFloat Jaw_mid_clenchLipsyncPoseOutput
		{
			get => GetProperty(ref _jaw_mid_clenchLipsyncPoseOutput);
			set => SetProperty(ref _jaw_mid_clenchLipsyncPoseOutput, value);
		}

		[Ordinal(336)] 
		[RED("neck_l_stretchLipsyncPoseOutput")] 
		public CFloat Neck_l_stretchLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_l_stretchLipsyncPoseOutput);
			set => SetProperty(ref _neck_l_stretchLipsyncPoseOutput, value);
		}

		[Ordinal(337)] 
		[RED("neck_r_stretchLipsyncPoseOutput")] 
		public CFloat Neck_r_stretchLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_r_stretchLipsyncPoseOutput);
			set => SetProperty(ref _neck_r_stretchLipsyncPoseOutput, value);
		}

		[Ordinal(338)] 
		[RED("neck_tightenLipsyncPoseOutput")] 
		public CFloat Neck_tightenLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_tightenLipsyncPoseOutput);
			set => SetProperty(ref _neck_tightenLipsyncPoseOutput, value);
		}

		[Ordinal(339)] 
		[RED("neck_l_sternocleidomastoid_flexLipsyncPoseOutput")] 
		public CFloat Neck_l_sternocleidomastoid_flexLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_l_sternocleidomastoid_flexLipsyncPoseOutput);
			set => SetProperty(ref _neck_l_sternocleidomastoid_flexLipsyncPoseOutput, value);
		}

		[Ordinal(340)] 
		[RED("neck_r_sternocleidomastoid_flexLipsyncPoseOutput")] 
		public CFloat Neck_r_sternocleidomastoid_flexLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_r_sternocleidomastoid_flexLipsyncPoseOutput);
			set => SetProperty(ref _neck_r_sternocleidomastoid_flexLipsyncPoseOutput, value);
		}

		[Ordinal(341)] 
		[RED("neck_l_platysma_flexLipsyncPoseOutput")] 
		public CFloat Neck_l_platysma_flexLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_l_platysma_flexLipsyncPoseOutput);
			set => SetProperty(ref _neck_l_platysma_flexLipsyncPoseOutput, value);
		}

		[Ordinal(342)] 
		[RED("neck_r_platysma_flexLipsyncPoseOutput")] 
		public CFloat Neck_r_platysma_flexLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_r_platysma_flexLipsyncPoseOutput);
			set => SetProperty(ref _neck_r_platysma_flexLipsyncPoseOutput, value);
		}

		[Ordinal(343)] 
		[RED("neck_throat_adamsApple_upLipsyncPoseOutput")] 
		public CFloat Neck_throat_adamsApple_upLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_throat_adamsApple_upLipsyncPoseOutput);
			set => SetProperty(ref _neck_throat_adamsApple_upLipsyncPoseOutput, value);
		}

		[Ordinal(344)] 
		[RED("neck_throat_adamsApple_dnLipsyncPoseOutput")] 
		public CFloat Neck_throat_adamsApple_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_throat_adamsApple_dnLipsyncPoseOutput);
			set => SetProperty(ref _neck_throat_adamsApple_dnLipsyncPoseOutput, value);
		}

		[Ordinal(345)] 
		[RED("neck_throat_compressLipsyncPoseOutput")] 
		public CFloat Neck_throat_compressLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_throat_compressLipsyncPoseOutput);
			set => SetProperty(ref _neck_throat_compressLipsyncPoseOutput, value);
		}

		[Ordinal(346)] 
		[RED("neck_throat_openLipsyncPoseOutput")] 
		public CFloat Neck_throat_openLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_throat_openLipsyncPoseOutput);
			set => SetProperty(ref _neck_throat_openLipsyncPoseOutput, value);
		}

		[Ordinal(347)] 
		[RED("neck_l_turnLipsyncPoseOutput")] 
		public CFloat Neck_l_turnLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_l_turnLipsyncPoseOutput);
			set => SetProperty(ref _neck_l_turnLipsyncPoseOutput, value);
		}

		[Ordinal(348)] 
		[RED("neck_r_turnLipsyncPoseOutput")] 
		public CFloat Neck_r_turnLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_r_turnLipsyncPoseOutput);
			set => SetProperty(ref _neck_r_turnLipsyncPoseOutput, value);
		}

		[Ordinal(349)] 
		[RED("neck_up_turnLipsyncPoseOutput")] 
		public CFloat Neck_up_turnLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_up_turnLipsyncPoseOutput);
			set => SetProperty(ref _neck_up_turnLipsyncPoseOutput, value);
		}

		[Ordinal(350)] 
		[RED("neck_dn_turnLipsyncPoseOutput")] 
		public CFloat Neck_dn_turnLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_dn_turnLipsyncPoseOutput);
			set => SetProperty(ref _neck_dn_turnLipsyncPoseOutput, value);
		}

		[Ordinal(351)] 
		[RED("neck_l_tiltLipsyncPoseOutput")] 
		public CFloat Neck_l_tiltLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_l_tiltLipsyncPoseOutput);
			set => SetProperty(ref _neck_l_tiltLipsyncPoseOutput, value);
		}

		[Ordinal(352)] 
		[RED("neck_r_tiltLipsyncPoseOutput")] 
		public CFloat Neck_r_tiltLipsyncPoseOutput
		{
			get => GetProperty(ref _neck_r_tiltLipsyncPoseOutput);
			set => SetProperty(ref _neck_r_tiltLipsyncPoseOutput, value);
		}

		[Ordinal(353)] 
		[RED("head_neck_up_turnLipsyncPoseOutput")] 
		public CFloat Head_neck_up_turnLipsyncPoseOutput
		{
			get => GetProperty(ref _head_neck_up_turnLipsyncPoseOutput);
			set => SetProperty(ref _head_neck_up_turnLipsyncPoseOutput, value);
		}

		[Ordinal(354)] 
		[RED("head_neck_dn_turnLipsyncPoseOutput")] 
		public CFloat Head_neck_dn_turnLipsyncPoseOutput
		{
			get => GetProperty(ref _head_neck_dn_turnLipsyncPoseOutput);
			set => SetProperty(ref _head_neck_dn_turnLipsyncPoseOutput, value);
		}

		[Ordinal(355)] 
		[RED("head_neck_l_tiltLipsyncPoseOutput")] 
		public CFloat Head_neck_l_tiltLipsyncPoseOutput
		{
			get => GetProperty(ref _head_neck_l_tiltLipsyncPoseOutput);
			set => SetProperty(ref _head_neck_l_tiltLipsyncPoseOutput, value);
		}

		[Ordinal(356)] 
		[RED("head_neck_r_tiltLipsyncPoseOutput")] 
		public CFloat Head_neck_r_tiltLipsyncPoseOutput
		{
			get => GetProperty(ref _head_neck_r_tiltLipsyncPoseOutput);
			set => SetProperty(ref _head_neck_r_tiltLipsyncPoseOutput, value);
		}

		[Ordinal(357)] 
		[RED("ear_l_shift_upLipsyncPoseOutput")] 
		public CFloat Ear_l_shift_upLipsyncPoseOutput
		{
			get => GetProperty(ref _ear_l_shift_upLipsyncPoseOutput);
			set => SetProperty(ref _ear_l_shift_upLipsyncPoseOutput, value);
		}

		[Ordinal(358)] 
		[RED("ear_r_shift_upLipsyncPoseOutput")] 
		public CFloat Ear_r_shift_upLipsyncPoseOutput
		{
			get => GetProperty(ref _ear_r_shift_upLipsyncPoseOutput);
			set => SetProperty(ref _ear_r_shift_upLipsyncPoseOutput, value);
		}

		[Ordinal(359)] 
		[RED("sculp_mid_slideLipsyncPoseOutput")] 
		public CFloat Sculp_mid_slideLipsyncPoseOutput
		{
			get => GetProperty(ref _sculp_mid_slideLipsyncPoseOutput);
			set => SetProperty(ref _sculp_mid_slideLipsyncPoseOutput, value);
		}

		[Ordinal(360)] 
		[RED("face_gravity_fwdLipsyncPoseOutput")] 
		public CFloat Face_gravity_fwdLipsyncPoseOutput
		{
			get => GetProperty(ref _face_gravity_fwdLipsyncPoseOutput);
			set => SetProperty(ref _face_gravity_fwdLipsyncPoseOutput, value);
		}

		[Ordinal(361)] 
		[RED("face_gravity_backLipsyncPoseOutput")] 
		public CFloat Face_gravity_backLipsyncPoseOutput
		{
			get => GetProperty(ref _face_gravity_backLipsyncPoseOutput);
			set => SetProperty(ref _face_gravity_backLipsyncPoseOutput, value);
		}

		[Ordinal(362)] 
		[RED("face_gravity_lLipsyncPoseOutput")] 
		public CFloat Face_gravity_lLipsyncPoseOutput
		{
			get => GetProperty(ref _face_gravity_lLipsyncPoseOutput);
			set => SetProperty(ref _face_gravity_lLipsyncPoseOutput, value);
		}

		[Ordinal(363)] 
		[RED("face_gravity_rLipsyncPoseOutput")] 
		public CFloat Face_gravity_rLipsyncPoseOutput
		{
			get => GetProperty(ref _face_gravity_rLipsyncPoseOutput);
			set => SetProperty(ref _face_gravity_rLipsyncPoseOutput, value);
		}

		[Ordinal(364)] 
		[RED("tongue_mid_base_lLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_lLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_base_lLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_base_lLipsyncPoseOutput, value);
		}

		[Ordinal(365)] 
		[RED("tongue_mid_base_rLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_rLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_base_rLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_base_rLipsyncPoseOutput, value);
		}

		[Ordinal(366)] 
		[RED("tongue_mid_base_dnLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_base_dnLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_base_dnLipsyncPoseOutput, value);
		}

		[Ordinal(367)] 
		[RED("tongue_mid_base_upLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_upLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_base_upLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_base_upLipsyncPoseOutput, value);
		}

		[Ordinal(368)] 
		[RED("tongue_mid_base_fwdLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_fwdLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_base_fwdLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_base_fwdLipsyncPoseOutput, value);
		}

		[Ordinal(369)] 
		[RED("tongue_mid_base_frontLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_frontLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_base_frontLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_base_frontLipsyncPoseOutput, value);
		}

		[Ordinal(370)] 
		[RED("tongue_mid_base_backLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_backLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_base_backLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_base_backLipsyncPoseOutput, value);
		}

		[Ordinal(371)] 
		[RED("tongue_mid_fwdLipsyncPoseOutput")] 
		public CFloat Tongue_mid_fwdLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_fwdLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_fwdLipsyncPoseOutput, value);
		}

		[Ordinal(372)] 
		[RED("tongue_mid_liftLipsyncPoseOutput")] 
		public CFloat Tongue_mid_liftLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_liftLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_liftLipsyncPoseOutput, value);
		}

		[Ordinal(373)] 
		[RED("tongue_mid_tip_lLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_lLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_tip_lLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_tip_lLipsyncPoseOutput, value);
		}

		[Ordinal(374)] 
		[RED("tongue_mid_tip_rLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_rLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_tip_rLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_tip_rLipsyncPoseOutput, value);
		}

		[Ordinal(375)] 
		[RED("tongue_mid_tip_dnLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_dnLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_tip_dnLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_tip_dnLipsyncPoseOutput, value);
		}

		[Ordinal(376)] 
		[RED("tongue_mid_tip_upLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_upLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_tip_upLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_tip_upLipsyncPoseOutput, value);
		}

		[Ordinal(377)] 
		[RED("tongue_mid_twist_lLipsyncPoseOutput")] 
		public CFloat Tongue_mid_twist_lLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_twist_lLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_twist_lLipsyncPoseOutput, value);
		}

		[Ordinal(378)] 
		[RED("tongue_mid_twist_rLipsyncPoseOutput")] 
		public CFloat Tongue_mid_twist_rLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_twist_rLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_twist_rLipsyncPoseOutput, value);
		}

		[Ordinal(379)] 
		[RED("tongue_mid_thickLipsyncPoseOutput")] 
		public CFloat Tongue_mid_thickLipsyncPoseOutput
		{
			get => GetProperty(ref _tongue_mid_thickLipsyncPoseOutput);
			set => SetProperty(ref _tongue_mid_thickLipsyncPoseOutput, value);
		}

		[Ordinal(380)] 
		[RED("eye_l_oculi_squint_outer_lowerWrnkl")] 
		public CFloat Eye_l_oculi_squint_outer_lowerWrnkl
		{
			get => GetProperty(ref _eye_l_oculi_squint_outer_lowerWrnkl);
			set => SetProperty(ref _eye_l_oculi_squint_outer_lowerWrnkl, value);
		}

		[Ordinal(381)] 
		[RED("eye_r_oculi_squint_outer_lowerWrnkl")] 
		public CFloat Eye_r_oculi_squint_outer_lowerWrnkl
		{
			get => GetProperty(ref _eye_r_oculi_squint_outer_lowerWrnkl);
			set => SetProperty(ref _eye_r_oculi_squint_outer_lowerWrnkl, value);
		}

		[Ordinal(382)] 
		[RED("eye_l_oculi_squint_outer_upperWrnkl")] 
		public CFloat Eye_l_oculi_squint_outer_upperWrnkl
		{
			get => GetProperty(ref _eye_l_oculi_squint_outer_upperWrnkl);
			set => SetProperty(ref _eye_l_oculi_squint_outer_upperWrnkl, value);
		}

		[Ordinal(383)] 
		[RED("eye_r_oculi_squint_outer_upperWrnkl")] 
		public CFloat Eye_r_oculi_squint_outer_upperWrnkl
		{
			get => GetProperty(ref _eye_r_oculi_squint_outer_upperWrnkl);
			set => SetProperty(ref _eye_r_oculi_squint_outer_upperWrnkl, value);
		}

		[Ordinal(384)] 
		[RED("eye_l_brows_raise_inWrnkl")] 
		public CFloat Eye_l_brows_raise_inWrnkl
		{
			get => GetProperty(ref _eye_l_brows_raise_inWrnkl);
			set => SetProperty(ref _eye_l_brows_raise_inWrnkl, value);
		}

		[Ordinal(385)] 
		[RED("eye_r_brows_raise_inWrnkl")] 
		public CFloat Eye_r_brows_raise_inWrnkl
		{
			get => GetProperty(ref _eye_r_brows_raise_inWrnkl);
			set => SetProperty(ref _eye_r_brows_raise_inWrnkl, value);
		}

		[Ordinal(386)] 
		[RED("eye_l_brows_raise_outWrnkl")] 
		public CFloat Eye_l_brows_raise_outWrnkl
		{
			get => GetProperty(ref _eye_l_brows_raise_outWrnkl);
			set => SetProperty(ref _eye_l_brows_raise_outWrnkl, value);
		}

		[Ordinal(387)] 
		[RED("eye_r_brows_raise_outWrnkl")] 
		public CFloat Eye_r_brows_raise_outWrnkl
		{
			get => GetProperty(ref _eye_r_brows_raise_outWrnkl);
			set => SetProperty(ref _eye_r_brows_raise_outWrnkl, value);
		}

		[Ordinal(388)] 
		[RED("eye_l_brows_lowerWrnkl")] 
		public CFloat Eye_l_brows_lowerWrnkl
		{
			get => GetProperty(ref _eye_l_brows_lowerWrnkl);
			set => SetProperty(ref _eye_l_brows_lowerWrnkl, value);
		}

		[Ordinal(389)] 
		[RED("eye_r_brows_lowerWrnkl")] 
		public CFloat Eye_r_brows_lowerWrnkl
		{
			get => GetProperty(ref _eye_r_brows_lowerWrnkl);
			set => SetProperty(ref _eye_r_brows_lowerWrnkl, value);
		}

		[Ordinal(390)] 
		[RED("eye_l_brows_lateralWrnkl")] 
		public CFloat Eye_l_brows_lateralWrnkl
		{
			get => GetProperty(ref _eye_l_brows_lateralWrnkl);
			set => SetProperty(ref _eye_l_brows_lateralWrnkl, value);
		}

		[Ordinal(391)] 
		[RED("eye_r_brows_lateralWrnkl")] 
		public CFloat Eye_r_brows_lateralWrnkl
		{
			get => GetProperty(ref _eye_r_brows_lateralWrnkl);
			set => SetProperty(ref _eye_r_brows_lateralWrnkl, value);
		}

		[Ordinal(392)] 
		[RED("nose_l_snearWrnkl")] 
		public CFloat Nose_l_snearWrnkl
		{
			get => GetProperty(ref _nose_l_snearWrnkl);
			set => SetProperty(ref _nose_l_snearWrnkl, value);
		}

		[Ordinal(393)] 
		[RED("nose_r_snearWrnkl")] 
		public CFloat Nose_r_snearWrnkl
		{
			get => GetProperty(ref _nose_r_snearWrnkl);
			set => SetProperty(ref _nose_r_snearWrnkl, value);
		}

		[Ordinal(394)] 
		[RED("lips_l_upper_raiseWrnkl")] 
		public CFloat Lips_l_upper_raiseWrnkl
		{
			get => GetProperty(ref _lips_l_upper_raiseWrnkl);
			set => SetProperty(ref _lips_l_upper_raiseWrnkl, value);
		}

		[Ordinal(395)] 
		[RED("lips_r_upper_raiseWrnkl")] 
		public CFloat Lips_r_upper_raiseWrnkl
		{
			get => GetProperty(ref _lips_r_upper_raiseWrnkl);
			set => SetProperty(ref _lips_r_upper_raiseWrnkl, value);
		}

		[Ordinal(396)] 
		[RED("lips_l_corner_upWrnkl")] 
		public CFloat Lips_l_corner_upWrnkl
		{
			get => GetProperty(ref _lips_l_corner_upWrnkl);
			set => SetProperty(ref _lips_l_corner_upWrnkl, value);
		}

		[Ordinal(397)] 
		[RED("lips_r_corner_upWrnkl")] 
		public CFloat Lips_r_corner_upWrnkl
		{
			get => GetProperty(ref _lips_r_corner_upWrnkl);
			set => SetProperty(ref _lips_r_corner_upWrnkl, value);
		}

		[Ordinal(398)] 
		[RED("lips_l_corner_wideWrnkl")] 
		public CFloat Lips_l_corner_wideWrnkl
		{
			get => GetProperty(ref _lips_l_corner_wideWrnkl);
			set => SetProperty(ref _lips_l_corner_wideWrnkl, value);
		}

		[Ordinal(399)] 
		[RED("lips_r_corner_wideWrnkl")] 
		public CFloat Lips_r_corner_wideWrnkl
		{
			get => GetProperty(ref _lips_r_corner_wideWrnkl);
			set => SetProperty(ref _lips_r_corner_wideWrnkl, value);
		}

		[Ordinal(400)] 
		[RED("lips_l_corner_stretchWrnkl")] 
		public CFloat Lips_l_corner_stretchWrnkl
		{
			get => GetProperty(ref _lips_l_corner_stretchWrnkl);
			set => SetProperty(ref _lips_l_corner_stretchWrnkl, value);
		}

		[Ordinal(401)] 
		[RED("lips_r_corner_stretchWrnkl")] 
		public CFloat Lips_r_corner_stretchWrnkl
		{
			get => GetProperty(ref _lips_r_corner_stretchWrnkl);
			set => SetProperty(ref _lips_r_corner_stretchWrnkl, value);
		}

		[Ordinal(402)] 
		[RED("lips_l_lower_raiseWrnkl")] 
		public CFloat Lips_l_lower_raiseWrnkl
		{
			get => GetProperty(ref _lips_l_lower_raiseWrnkl);
			set => SetProperty(ref _lips_l_lower_raiseWrnkl, value);
		}

		[Ordinal(403)] 
		[RED("lips_r_lower_raiseWrnkl")] 
		public CFloat Lips_r_lower_raiseWrnkl
		{
			get => GetProperty(ref _lips_r_lower_raiseWrnkl);
			set => SetProperty(ref _lips_r_lower_raiseWrnkl, value);
		}

		[Ordinal(404)] 
		[RED("lips_chin_raiseWrnkl")] 
		public CFloat Lips_chin_raiseWrnkl
		{
			get => GetProperty(ref _lips_chin_raiseWrnkl);
			set => SetProperty(ref _lips_chin_raiseWrnkl, value);
		}

		[Ordinal(405)] 
		[RED("lips_l_purseWrnkl")] 
		public CFloat Lips_l_purseWrnkl
		{
			get => GetProperty(ref _lips_l_purseWrnkl);
			set => SetProperty(ref _lips_l_purseWrnkl, value);
		}

		[Ordinal(406)] 
		[RED("lips_r_purseWrnkl")] 
		public CFloat Lips_r_purseWrnkl
		{
			get => GetProperty(ref _lips_r_purseWrnkl);
			set => SetProperty(ref _lips_r_purseWrnkl, value);
		}

		[Ordinal(407)] 
		[RED("lips_l_funnelWrnkl")] 
		public CFloat Lips_l_funnelWrnkl
		{
			get => GetProperty(ref _lips_l_funnelWrnkl);
			set => SetProperty(ref _lips_l_funnelWrnkl, value);
		}

		[Ordinal(408)] 
		[RED("lips_r_funnelWrnkl")] 
		public CFloat Lips_r_funnelWrnkl
		{
			get => GetProperty(ref _lips_r_funnelWrnkl);
			set => SetProperty(ref _lips_r_funnelWrnkl, value);
		}

		[Ordinal(409)] 
		[RED("jaw_mid_openWrnkl")] 
		public CFloat Jaw_mid_openWrnkl
		{
			get => GetProperty(ref _jaw_mid_openWrnkl);
			set => SetProperty(ref _jaw_mid_openWrnkl, value);
		}

		[Ordinal(410)] 
		[RED("neck_l_stretchWrnkl")] 
		public CFloat Neck_l_stretchWrnkl
		{
			get => GetProperty(ref _neck_l_stretchWrnkl);
			set => SetProperty(ref _neck_l_stretchWrnkl, value);
		}

		[Ordinal(411)] 
		[RED("neck_r_stretchWrnkl")] 
		public CFloat Neck_r_stretchWrnkl
		{
			get => GetProperty(ref _neck_r_stretchWrnkl);
			set => SetProperty(ref _neck_r_stretchWrnkl, value);
		}

		[Ordinal(412)] 
		[RED("head_neck_dn_turnWrnkl")] 
		public CFloat Head_neck_dn_turnWrnkl
		{
			get => GetProperty(ref _head_neck_dn_turnWrnkl);
			set => SetProperty(ref _head_neck_dn_turnWrnkl, value);
		}

		public animSermoTestController()
		{
			_faceEnvelope = 1.000000F;
			_upperFace = 1.000000F;
			_lowerFace = 1.000000F;
			_lipSyncLeftEnvelope = 1.000000F;
			_lipSyncRightEnvelope = 1.000000F;
			_jaliJaw = 1.000000F;
			_jaliLips = 1.000000F;
			_nose_l_snearAnimOverrideWeight = 1.000000F;
			_nose_r_snearAnimOverrideWeight = 1.000000F;
			_lips_l_nasolabialDeepenerAnimOverrideWeight = 1.000000F;
			_lips_r_nasolabialDeepenerAnimOverrideWeight = 1.000000F;
			_lips_l_upper_raiseAnimOverrideWeight = 1.000000F;
			_lips_r_upper_raiseAnimOverrideWeight = 1.000000F;
			_lips_l_pullAnimOverrideWeight = 1.000000F;
			_lips_r_pullAnimOverrideWeight = 1.000000F;
			_lips_l_corner_upAnimOverrideWeight = 1.000000F;
			_lips_r_corner_upAnimOverrideWeight = 1.000000F;
			_lips_l_corner_wideAnimOverrideWeight = 1.000000F;
			_lips_r_corner_wideAnimOverrideWeight = 1.000000F;
			_lips_l_corner_stretchAnimOverrideWeight = 1.000000F;
			_lips_r_corner_stretchAnimOverrideWeight = 1.000000F;
			_lips_l_stretchAnimOverrideWeight = 1.000000F;
			_lips_r_stretchAnimOverrideWeight = 1.000000F;
			_lips_l_corner_sharp_upAnimOverrideWeight = 1.000000F;
			_lips_r_corner_sharp_upAnimOverrideWeight = 1.000000F;
			_lips_suck_upAnimOverrideWeight = 1.000000F;
			_lips_suck_dnAnimOverrideWeight = 1.000000F;
			_lips_puff_upAnimOverrideWeight = 1.000000F;
			_lips_puff_dnAnimOverrideWeight = 1.000000F;
			_lips_apart_upAnimOverrideWeight = 1.000000F;
			_lips_apart_dnAnimOverrideWeight = 1.000000F;
			_lips_l_lower_raiseAnimOverrideWeight = 1.000000F;
			_lips_r_lower_raiseAnimOverrideWeight = 1.000000F;
			_lips_l_corner_dnAnimOverrideWeight = 1.000000F;
			_lips_r_corner_dnAnimOverrideWeight = 1.000000F;
			_lips_chin_raiseAnimOverrideWeight = 1.000000F;
			_lips_together_upAnimOverrideWeight = 1.000000F;
			_lips_together_dnAnimOverrideWeight = 1.000000F;
			_lips_l_purseAnimOverrideWeight = 1.000000F;
			_lips_r_purseAnimOverrideWeight = 1.000000F;
			_lips_l_funnelAnimOverrideWeight = 1.000000F;
			_lips_r_funnelAnimOverrideWeight = 1.000000F;
			_lips_tighten_upAnimOverrideWeight = 1.000000F;
			_lips_tighten_dnAnimOverrideWeight = 1.000000F;
			_lips_mid_shift_lAnimOverrideWeight = 1.000000F;
			_lips_mid_shift_rAnimOverrideWeight = 1.000000F;
			_lips_mid_shift_upAnimOverrideWeight = 1.000000F;
			_lips_mid_shift_dnAnimOverrideWeight = 1.000000F;
			_cheek_l_puffAnimOverrideWeight = 1.000000F;
			_cheek_r_puffAnimOverrideWeight = 1.000000F;
			_jaw_mid_openAnimOverrideWeight = 1.000000F;
			_jaw_mid_closeAnimOverrideWeight = 1.000000F;
			_jaw_mid_shift_lAnimOverrideWeight = 1.000000F;
			_jaw_mid_shift_rAnimOverrideWeight = 1.000000F;
			_jaw_mid_shift_fwdAnimOverrideWeight = 1.000000F;
			_jaw_mid_shift_backAnimOverrideWeight = 1.000000F;
			_jaw_mid_clenchAnimOverrideWeight = 1.000000F;
			_neck_l_stretchAnimOverrideWeight = 1.000000F;
			_neck_r_stretchAnimOverrideWeight = 1.000000F;
			_neck_tightenAnimOverrideWeight = 1.000000F;
			_neck_l_sternocleidomastoid_flexAnimOverrideWeight = 1.000000F;
			_neck_r_sternocleidomastoid_flexAnimOverrideWeight = 1.000000F;
			_neck_l_platysma_flexAnimOverrideWeight = 1.000000F;
			_neck_r_platysma_flexAnimOverrideWeight = 1.000000F;
			_neck_throat_adamsApple_upAnimOverrideWeight = 1.000000F;
			_neck_throat_adamsApple_dnAnimOverrideWeight = 1.000000F;
			_neck_throat_compressAnimOverrideWeight = 1.000000F;
			_neck_throat_openAnimOverrideWeight = 1.000000F;
			_lips_corner_stickyAnimOverrideWeight = 1.000000F;
			_lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight = 1.000000F;
			_tongue_mid_base_lAnimOverrideWeight = 1.000000F;
			_tongue_mid_base_rAnimOverrideWeight = 1.000000F;
			_tongue_mid_base_dnAnimOverrideWeight = 1.000000F;
			_tongue_mid_base_upAnimOverrideWeight = 1.000000F;
			_tongue_mid_base_fwdAnimOverrideWeight = 1.000000F;
			_tongue_mid_base_frontAnimOverrideWeight = 1.000000F;
			_tongue_mid_base_backAnimOverrideWeight = 1.000000F;
			_tongue_mid_fwdAnimOverrideWeight = 1.000000F;
			_tongue_mid_liftAnimOverrideWeight = 1.000000F;
			_tongue_mid_tip_lAnimOverrideWeight = 1.000000F;
			_tongue_mid_tip_rAnimOverrideWeight = 1.000000F;
			_tongue_mid_tip_dnAnimOverrideWeight = 1.000000F;
			_tongue_mid_tip_upAnimOverrideWeight = 1.000000F;
			_tongue_mid_twist_lAnimOverrideWeight = 1.000000F;
			_tongue_mid_twist_rAnimOverrideWeight = 1.000000F;
			_tongue_mid_thickAnimOverrideWeight = 1.000000F;
		}
	}
}
