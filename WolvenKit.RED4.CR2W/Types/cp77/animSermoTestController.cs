using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSermoTestController : CVariable
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
			get
			{
				if (_faceEnvelope == null)
				{
					_faceEnvelope = (CFloat) CR2WTypeManager.Create("Float", "faceEnvelope", cr2w, this);
				}
				return _faceEnvelope;
			}
			set
			{
				if (_faceEnvelope == value)
				{
					return;
				}
				_faceEnvelope = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("upperFace")] 
		public CFloat UpperFace
		{
			get
			{
				if (_upperFace == null)
				{
					_upperFace = (CFloat) CR2WTypeManager.Create("Float", "upperFace", cr2w, this);
				}
				return _upperFace;
			}
			set
			{
				if (_upperFace == value)
				{
					return;
				}
				_upperFace = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lowerFace")] 
		public CFloat LowerFace
		{
			get
			{
				if (_lowerFace == null)
				{
					_lowerFace = (CFloat) CR2WTypeManager.Create("Float", "lowerFace", cr2w, this);
				}
				return _lowerFace;
			}
			set
			{
				if (_lowerFace == value)
				{
					return;
				}
				_lowerFace = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lipSyncEnvelope")] 
		public CFloat LipSyncEnvelope
		{
			get
			{
				if (_lipSyncEnvelope == null)
				{
					_lipSyncEnvelope = (CFloat) CR2WTypeManager.Create("Float", "lipSyncEnvelope", cr2w, this);
				}
				return _lipSyncEnvelope;
			}
			set
			{
				if (_lipSyncEnvelope == value)
				{
					return;
				}
				_lipSyncEnvelope = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lipSyncLeftEnvelope")] 
		public CFloat LipSyncLeftEnvelope
		{
			get
			{
				if (_lipSyncLeftEnvelope == null)
				{
					_lipSyncLeftEnvelope = (CFloat) CR2WTypeManager.Create("Float", "lipSyncLeftEnvelope", cr2w, this);
				}
				return _lipSyncLeftEnvelope;
			}
			set
			{
				if (_lipSyncLeftEnvelope == value)
				{
					return;
				}
				_lipSyncLeftEnvelope = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lipSyncRightEnvelope")] 
		public CFloat LipSyncRightEnvelope
		{
			get
			{
				if (_lipSyncRightEnvelope == null)
				{
					_lipSyncRightEnvelope = (CFloat) CR2WTypeManager.Create("Float", "lipSyncRightEnvelope", cr2w, this);
				}
				return _lipSyncRightEnvelope;
			}
			set
			{
				if (_lipSyncRightEnvelope == value)
				{
					return;
				}
				_lipSyncRightEnvelope = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("jaliJaw")] 
		public CFloat JaliJaw
		{
			get
			{
				if (_jaliJaw == null)
				{
					_jaliJaw = (CFloat) CR2WTypeManager.Create("Float", "jaliJaw", cr2w, this);
				}
				return _jaliJaw;
			}
			set
			{
				if (_jaliJaw == value)
				{
					return;
				}
				_jaliJaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("jaliLips")] 
		public CFloat JaliLips
		{
			get
			{
				if (_jaliLips == null)
				{
					_jaliLips = (CFloat) CR2WTypeManager.Create("Float", "jaliLips", cr2w, this);
				}
				return _jaliLips;
			}
			set
			{
				if (_jaliLips == value)
				{
					return;
				}
				_jaliLips = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("muzzleLips")] 
		public CFloat MuzzleLips
		{
			get
			{
				if (_muzzleLips == null)
				{
					_muzzleLips = (CFloat) CR2WTypeManager.Create("Float", "muzzleLips", cr2w, this);
				}
				return _muzzleLips;
			}
			set
			{
				if (_muzzleLips == value)
				{
					return;
				}
				_muzzleLips = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("muzzleEyes")] 
		public CFloat MuzzleEyes
		{
			get
			{
				if (_muzzleEyes == null)
				{
					_muzzleEyes = (CFloat) CR2WTypeManager.Create("Float", "muzzleEyes", cr2w, this);
				}
				return _muzzleEyes;
			}
			set
			{
				if (_muzzleEyes == value)
				{
					return;
				}
				_muzzleEyes = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("muzzleBrows")] 
		public CFloat MuzzleBrows
		{
			get
			{
				if (_muzzleBrows == null)
				{
					_muzzleBrows = (CFloat) CR2WTypeManager.Create("Float", "muzzleBrows", cr2w, this);
				}
				return _muzzleBrows;
			}
			set
			{
				if (_muzzleBrows == value)
				{
					return;
				}
				_muzzleBrows = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("muzzleEyeDirections")] 
		public CFloat MuzzleEyeDirections
		{
			get
			{
				if (_muzzleEyeDirections == null)
				{
					_muzzleEyeDirections = (CFloat) CR2WTypeManager.Create("Float", "muzzleEyeDirections", cr2w, this);
				}
				return _muzzleEyeDirections;
			}
			set
			{
				if (_muzzleEyeDirections == value)
				{
					return;
				}
				_muzzleEyeDirections = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("eye_l_blink")] 
		public CFloat Eye_l_blink
		{
			get
			{
				if (_eye_l_blink == null)
				{
					_eye_l_blink = (CFloat) CR2WTypeManager.Create("Float", "eye_l_blink", cr2w, this);
				}
				return _eye_l_blink;
			}
			set
			{
				if (_eye_l_blink == value)
				{
					return;
				}
				_eye_l_blink = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("eye_r_blink")] 
		public CFloat Eye_r_blink
		{
			get
			{
				if (_eye_r_blink == null)
				{
					_eye_r_blink = (CFloat) CR2WTypeManager.Create("Float", "eye_r_blink", cr2w, this);
				}
				return _eye_r_blink;
			}
			set
			{
				if (_eye_r_blink == value)
				{
					return;
				}
				_eye_r_blink = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("eye_l_widen")] 
		public CFloat Eye_l_widen
		{
			get
			{
				if (_eye_l_widen == null)
				{
					_eye_l_widen = (CFloat) CR2WTypeManager.Create("Float", "eye_l_widen", cr2w, this);
				}
				return _eye_l_widen;
			}
			set
			{
				if (_eye_l_widen == value)
				{
					return;
				}
				_eye_l_widen = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("eye_r_widen")] 
		public CFloat Eye_r_widen
		{
			get
			{
				if (_eye_r_widen == null)
				{
					_eye_r_widen = (CFloat) CR2WTypeManager.Create("Float", "eye_r_widen", cr2w, this);
				}
				return _eye_r_widen;
			}
			set
			{
				if (_eye_r_widen == value)
				{
					return;
				}
				_eye_r_widen = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("eye_l_dir_up")] 
		public CFloat Eye_l_dir_up
		{
			get
			{
				if (_eye_l_dir_up == null)
				{
					_eye_l_dir_up = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_up", cr2w, this);
				}
				return _eye_l_dir_up;
			}
			set
			{
				if (_eye_l_dir_up == value)
				{
					return;
				}
				_eye_l_dir_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("eye_l_dir_dn")] 
		public CFloat Eye_l_dir_dn
		{
			get
			{
				if (_eye_l_dir_dn == null)
				{
					_eye_l_dir_dn = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_dn", cr2w, this);
				}
				return _eye_l_dir_dn;
			}
			set
			{
				if (_eye_l_dir_dn == value)
				{
					return;
				}
				_eye_l_dir_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("eye_l_dir_in")] 
		public CFloat Eye_l_dir_in
		{
			get
			{
				if (_eye_l_dir_in == null)
				{
					_eye_l_dir_in = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_in", cr2w, this);
				}
				return _eye_l_dir_in;
			}
			set
			{
				if (_eye_l_dir_in == value)
				{
					return;
				}
				_eye_l_dir_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("eye_l_dir_out")] 
		public CFloat Eye_l_dir_out
		{
			get
			{
				if (_eye_l_dir_out == null)
				{
					_eye_l_dir_out = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_out", cr2w, this);
				}
				return _eye_l_dir_out;
			}
			set
			{
				if (_eye_l_dir_out == value)
				{
					return;
				}
				_eye_l_dir_out = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("eye_r_dir_up")] 
		public CFloat Eye_r_dir_up
		{
			get
			{
				if (_eye_r_dir_up == null)
				{
					_eye_r_dir_up = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_up", cr2w, this);
				}
				return _eye_r_dir_up;
			}
			set
			{
				if (_eye_r_dir_up == value)
				{
					return;
				}
				_eye_r_dir_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("eye_r_dir_dn")] 
		public CFloat Eye_r_dir_dn
		{
			get
			{
				if (_eye_r_dir_dn == null)
				{
					_eye_r_dir_dn = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_dn", cr2w, this);
				}
				return _eye_r_dir_dn;
			}
			set
			{
				if (_eye_r_dir_dn == value)
				{
					return;
				}
				_eye_r_dir_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("eye_r_dir_in")] 
		public CFloat Eye_r_dir_in
		{
			get
			{
				if (_eye_r_dir_in == null)
				{
					_eye_r_dir_in = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_in", cr2w, this);
				}
				return _eye_r_dir_in;
			}
			set
			{
				if (_eye_r_dir_in == value)
				{
					return;
				}
				_eye_r_dir_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("eye_r_dir_out")] 
		public CFloat Eye_r_dir_out
		{
			get
			{
				if (_eye_r_dir_out == null)
				{
					_eye_r_dir_out = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_out", cr2w, this);
				}
				return _eye_r_dir_out;
			}
			set
			{
				if (_eye_r_dir_out == value)
				{
					return;
				}
				_eye_r_dir_out = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("eye_l_pupil_narrow")] 
		public CFloat Eye_l_pupil_narrow
		{
			get
			{
				if (_eye_l_pupil_narrow == null)
				{
					_eye_l_pupil_narrow = (CFloat) CR2WTypeManager.Create("Float", "eye_l_pupil_narrow", cr2w, this);
				}
				return _eye_l_pupil_narrow;
			}
			set
			{
				if (_eye_l_pupil_narrow == value)
				{
					return;
				}
				_eye_l_pupil_narrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("eye_r_pupil_narrow")] 
		public CFloat Eye_r_pupil_narrow
		{
			get
			{
				if (_eye_r_pupil_narrow == null)
				{
					_eye_r_pupil_narrow = (CFloat) CR2WTypeManager.Create("Float", "eye_r_pupil_narrow", cr2w, this);
				}
				return _eye_r_pupil_narrow;
			}
			set
			{
				if (_eye_r_pupil_narrow == value)
				{
					return;
				}
				_eye_r_pupil_narrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("eye_l_pupil_wide")] 
		public CFloat Eye_l_pupil_wide
		{
			get
			{
				if (_eye_l_pupil_wide == null)
				{
					_eye_l_pupil_wide = (CFloat) CR2WTypeManager.Create("Float", "eye_l_pupil_wide", cr2w, this);
				}
				return _eye_l_pupil_wide;
			}
			set
			{
				if (_eye_l_pupil_wide == value)
				{
					return;
				}
				_eye_l_pupil_wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("eye_r_pupil_wide")] 
		public CFloat Eye_r_pupil_wide
		{
			get
			{
				if (_eye_r_pupil_wide == null)
				{
					_eye_r_pupil_wide = (CFloat) CR2WTypeManager.Create("Float", "eye_r_pupil_wide", cr2w, this);
				}
				return _eye_r_pupil_wide;
			}
			set
			{
				if (_eye_r_pupil_wide == value)
				{
					return;
				}
				_eye_r_pupil_wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("eye_l_brows_raise_in")] 
		public CFloat Eye_l_brows_raise_in
		{
			get
			{
				if (_eye_l_brows_raise_in == null)
				{
					_eye_l_brows_raise_in = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_raise_in", cr2w, this);
				}
				return _eye_l_brows_raise_in;
			}
			set
			{
				if (_eye_l_brows_raise_in == value)
				{
					return;
				}
				_eye_l_brows_raise_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("eye_r_brows_raise_in")] 
		public CFloat Eye_r_brows_raise_in
		{
			get
			{
				if (_eye_r_brows_raise_in == null)
				{
					_eye_r_brows_raise_in = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_raise_in", cr2w, this);
				}
				return _eye_r_brows_raise_in;
			}
			set
			{
				if (_eye_r_brows_raise_in == value)
				{
					return;
				}
				_eye_r_brows_raise_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("eye_l_brows_raise_out")] 
		public CFloat Eye_l_brows_raise_out
		{
			get
			{
				if (_eye_l_brows_raise_out == null)
				{
					_eye_l_brows_raise_out = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_raise_out", cr2w, this);
				}
				return _eye_l_brows_raise_out;
			}
			set
			{
				if (_eye_l_brows_raise_out == value)
				{
					return;
				}
				_eye_l_brows_raise_out = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("eye_r_brows_raise_out")] 
		public CFloat Eye_r_brows_raise_out
		{
			get
			{
				if (_eye_r_brows_raise_out == null)
				{
					_eye_r_brows_raise_out = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_raise_out", cr2w, this);
				}
				return _eye_r_brows_raise_out;
			}
			set
			{
				if (_eye_r_brows_raise_out == value)
				{
					return;
				}
				_eye_r_brows_raise_out = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("eye_l_brows_lower")] 
		public CFloat Eye_l_brows_lower
		{
			get
			{
				if (_eye_l_brows_lower == null)
				{
					_eye_l_brows_lower = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_lower", cr2w, this);
				}
				return _eye_l_brows_lower;
			}
			set
			{
				if (_eye_l_brows_lower == value)
				{
					return;
				}
				_eye_l_brows_lower = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("eye_r_brows_lower")] 
		public CFloat Eye_r_brows_lower
		{
			get
			{
				if (_eye_r_brows_lower == null)
				{
					_eye_r_brows_lower = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_lower", cr2w, this);
				}
				return _eye_r_brows_lower;
			}
			set
			{
				if (_eye_r_brows_lower == value)
				{
					return;
				}
				_eye_r_brows_lower = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("eye_l_brows_lateral")] 
		public CFloat Eye_l_brows_lateral
		{
			get
			{
				if (_eye_l_brows_lateral == null)
				{
					_eye_l_brows_lateral = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_lateral", cr2w, this);
				}
				return _eye_l_brows_lateral;
			}
			set
			{
				if (_eye_l_brows_lateral == value)
				{
					return;
				}
				_eye_l_brows_lateral = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("eye_r_brows_lateral")] 
		public CFloat Eye_r_brows_lateral
		{
			get
			{
				if (_eye_r_brows_lateral == null)
				{
					_eye_r_brows_lateral = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_lateral", cr2w, this);
				}
				return _eye_r_brows_lateral;
			}
			set
			{
				if (_eye_r_brows_lateral == value)
				{
					return;
				}
				_eye_r_brows_lateral = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("eye_l_oculi_squint_inner")] 
		public CFloat Eye_l_oculi_squint_inner
		{
			get
			{
				if (_eye_l_oculi_squint_inner == null)
				{
					_eye_l_oculi_squint_inner = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_inner", cr2w, this);
				}
				return _eye_l_oculi_squint_inner;
			}
			set
			{
				if (_eye_l_oculi_squint_inner == value)
				{
					return;
				}
				_eye_l_oculi_squint_inner = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("eye_r_oculi_squint_inner")] 
		public CFloat Eye_r_oculi_squint_inner
		{
			get
			{
				if (_eye_r_oculi_squint_inner == null)
				{
					_eye_r_oculi_squint_inner = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_inner", cr2w, this);
				}
				return _eye_r_oculi_squint_inner;
			}
			set
			{
				if (_eye_r_oculi_squint_inner == value)
				{
					return;
				}
				_eye_r_oculi_squint_inner = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("eye_l_oculi_squint_outer_lower")] 
		public CFloat Eye_l_oculi_squint_outer_lower
		{
			get
			{
				if (_eye_l_oculi_squint_outer_lower == null)
				{
					_eye_l_oculi_squint_outer_lower = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_outer_lower", cr2w, this);
				}
				return _eye_l_oculi_squint_outer_lower;
			}
			set
			{
				if (_eye_l_oculi_squint_outer_lower == value)
				{
					return;
				}
				_eye_l_oculi_squint_outer_lower = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("eye_r_oculi_squint_outer_lower")] 
		public CFloat Eye_r_oculi_squint_outer_lower
		{
			get
			{
				if (_eye_r_oculi_squint_outer_lower == null)
				{
					_eye_r_oculi_squint_outer_lower = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_outer_lower", cr2w, this);
				}
				return _eye_r_oculi_squint_outer_lower;
			}
			set
			{
				if (_eye_r_oculi_squint_outer_lower == value)
				{
					return;
				}
				_eye_r_oculi_squint_outer_lower = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("eye_l_oculi_squint_outer_upper")] 
		public CFloat Eye_l_oculi_squint_outer_upper
		{
			get
			{
				if (_eye_l_oculi_squint_outer_upper == null)
				{
					_eye_l_oculi_squint_outer_upper = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_outer_upper", cr2w, this);
				}
				return _eye_l_oculi_squint_outer_upper;
			}
			set
			{
				if (_eye_l_oculi_squint_outer_upper == value)
				{
					return;
				}
				_eye_l_oculi_squint_outer_upper = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("eye_r_oculi_squint_outer_upper")] 
		public CFloat Eye_r_oculi_squint_outer_upper
		{
			get
			{
				if (_eye_r_oculi_squint_outer_upper == null)
				{
					_eye_r_oculi_squint_outer_upper = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_outer_upper", cr2w, this);
				}
				return _eye_r_oculi_squint_outer_upper;
			}
			set
			{
				if (_eye_r_oculi_squint_outer_upper == value)
				{
					return;
				}
				_eye_r_oculi_squint_outer_upper = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("nose_l_compress")] 
		public CFloat Nose_l_compress
		{
			get
			{
				if (_nose_l_compress == null)
				{
					_nose_l_compress = (CFloat) CR2WTypeManager.Create("Float", "nose_l_compress", cr2w, this);
				}
				return _nose_l_compress;
			}
			set
			{
				if (_nose_l_compress == value)
				{
					return;
				}
				_nose_l_compress = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("nose_r_compress")] 
		public CFloat Nose_r_compress
		{
			get
			{
				if (_nose_r_compress == null)
				{
					_nose_r_compress = (CFloat) CR2WTypeManager.Create("Float", "nose_r_compress", cr2w, this);
				}
				return _nose_r_compress;
			}
			set
			{
				if (_nose_r_compress == value)
				{
					return;
				}
				_nose_r_compress = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("nose_l_breathe_in")] 
		public CFloat Nose_l_breathe_in
		{
			get
			{
				if (_nose_l_breathe_in == null)
				{
					_nose_l_breathe_in = (CFloat) CR2WTypeManager.Create("Float", "nose_l_breathe_in", cr2w, this);
				}
				return _nose_l_breathe_in;
			}
			set
			{
				if (_nose_l_breathe_in == value)
				{
					return;
				}
				_nose_l_breathe_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("nose_r_breathe_in")] 
		public CFloat Nose_r_breathe_in
		{
			get
			{
				if (_nose_r_breathe_in == null)
				{
					_nose_r_breathe_in = (CFloat) CR2WTypeManager.Create("Float", "nose_r_breathe_in", cr2w, this);
				}
				return _nose_r_breathe_in;
			}
			set
			{
				if (_nose_r_breathe_in == value)
				{
					return;
				}
				_nose_r_breathe_in = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("nose_l_breathe_out")] 
		public CFloat Nose_l_breathe_out
		{
			get
			{
				if (_nose_l_breathe_out == null)
				{
					_nose_l_breathe_out = (CFloat) CR2WTypeManager.Create("Float", "nose_l_breathe_out", cr2w, this);
				}
				return _nose_l_breathe_out;
			}
			set
			{
				if (_nose_l_breathe_out == value)
				{
					return;
				}
				_nose_l_breathe_out = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("nose_r_breathe_out")] 
		public CFloat Nose_r_breathe_out
		{
			get
			{
				if (_nose_r_breathe_out == null)
				{
					_nose_r_breathe_out = (CFloat) CR2WTypeManager.Create("Float", "nose_r_breathe_out", cr2w, this);
				}
				return _nose_r_breathe_out;
			}
			set
			{
				if (_nose_r_breathe_out == value)
				{
					return;
				}
				_nose_r_breathe_out = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("nose_l_snear")] 
		public CFloat Nose_l_snear
		{
			get
			{
				if (_nose_l_snear == null)
				{
					_nose_l_snear = (CFloat) CR2WTypeManager.Create("Float", "nose_l_snear", cr2w, this);
				}
				return _nose_l_snear;
			}
			set
			{
				if (_nose_l_snear == value)
				{
					return;
				}
				_nose_l_snear = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("nose_r_snear")] 
		public CFloat Nose_r_snear
		{
			get
			{
				if (_nose_r_snear == null)
				{
					_nose_r_snear = (CFloat) CR2WTypeManager.Create("Float", "nose_r_snear", cr2w, this);
				}
				return _nose_r_snear;
			}
			set
			{
				if (_nose_r_snear == value)
				{
					return;
				}
				_nose_r_snear = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("lips_l_nasolabialDeepener")] 
		public CFloat Lips_l_nasolabialDeepener
		{
			get
			{
				if (_lips_l_nasolabialDeepener == null)
				{
					_lips_l_nasolabialDeepener = (CFloat) CR2WTypeManager.Create("Float", "lips_l_nasolabialDeepener", cr2w, this);
				}
				return _lips_l_nasolabialDeepener;
			}
			set
			{
				if (_lips_l_nasolabialDeepener == value)
				{
					return;
				}
				_lips_l_nasolabialDeepener = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("lips_r_nasolabialDeepener")] 
		public CFloat Lips_r_nasolabialDeepener
		{
			get
			{
				if (_lips_r_nasolabialDeepener == null)
				{
					_lips_r_nasolabialDeepener = (CFloat) CR2WTypeManager.Create("Float", "lips_r_nasolabialDeepener", cr2w, this);
				}
				return _lips_r_nasolabialDeepener;
			}
			set
			{
				if (_lips_r_nasolabialDeepener == value)
				{
					return;
				}
				_lips_r_nasolabialDeepener = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("lips_l_upper_raise")] 
		public CFloat Lips_l_upper_raise
		{
			get
			{
				if (_lips_l_upper_raise == null)
				{
					_lips_l_upper_raise = (CFloat) CR2WTypeManager.Create("Float", "lips_l_upper_raise", cr2w, this);
				}
				return _lips_l_upper_raise;
			}
			set
			{
				if (_lips_l_upper_raise == value)
				{
					return;
				}
				_lips_l_upper_raise = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("lips_r_upper_raise")] 
		public CFloat Lips_r_upper_raise
		{
			get
			{
				if (_lips_r_upper_raise == null)
				{
					_lips_r_upper_raise = (CFloat) CR2WTypeManager.Create("Float", "lips_r_upper_raise", cr2w, this);
				}
				return _lips_r_upper_raise;
			}
			set
			{
				if (_lips_r_upper_raise == value)
				{
					return;
				}
				_lips_r_upper_raise = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("lips_l_pull")] 
		public CFloat Lips_l_pull
		{
			get
			{
				if (_lips_l_pull == null)
				{
					_lips_l_pull = (CFloat) CR2WTypeManager.Create("Float", "lips_l_pull", cr2w, this);
				}
				return _lips_l_pull;
			}
			set
			{
				if (_lips_l_pull == value)
				{
					return;
				}
				_lips_l_pull = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("lips_r_pull")] 
		public CFloat Lips_r_pull
		{
			get
			{
				if (_lips_r_pull == null)
				{
					_lips_r_pull = (CFloat) CR2WTypeManager.Create("Float", "lips_r_pull", cr2w, this);
				}
				return _lips_r_pull;
			}
			set
			{
				if (_lips_r_pull == value)
				{
					return;
				}
				_lips_r_pull = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("lips_l_corner_up")] 
		public CFloat Lips_l_corner_up
		{
			get
			{
				if (_lips_l_corner_up == null)
				{
					_lips_l_corner_up = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_up", cr2w, this);
				}
				return _lips_l_corner_up;
			}
			set
			{
				if (_lips_l_corner_up == value)
				{
					return;
				}
				_lips_l_corner_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("lips_r_corner_up")] 
		public CFloat Lips_r_corner_up
		{
			get
			{
				if (_lips_r_corner_up == null)
				{
					_lips_r_corner_up = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_up", cr2w, this);
				}
				return _lips_r_corner_up;
			}
			set
			{
				if (_lips_r_corner_up == value)
				{
					return;
				}
				_lips_r_corner_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("lips_l_corner_wide")] 
		public CFloat Lips_l_corner_wide
		{
			get
			{
				if (_lips_l_corner_wide == null)
				{
					_lips_l_corner_wide = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_wide", cr2w, this);
				}
				return _lips_l_corner_wide;
			}
			set
			{
				if (_lips_l_corner_wide == value)
				{
					return;
				}
				_lips_l_corner_wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("lips_r_corner_wide")] 
		public CFloat Lips_r_corner_wide
		{
			get
			{
				if (_lips_r_corner_wide == null)
				{
					_lips_r_corner_wide = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_wide", cr2w, this);
				}
				return _lips_r_corner_wide;
			}
			set
			{
				if (_lips_r_corner_wide == value)
				{
					return;
				}
				_lips_r_corner_wide = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("lips_l_corner_stretch")] 
		public CFloat Lips_l_corner_stretch
		{
			get
			{
				if (_lips_l_corner_stretch == null)
				{
					_lips_l_corner_stretch = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_stretch", cr2w, this);
				}
				return _lips_l_corner_stretch;
			}
			set
			{
				if (_lips_l_corner_stretch == value)
				{
					return;
				}
				_lips_l_corner_stretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("lips_r_corner_stretch")] 
		public CFloat Lips_r_corner_stretch
		{
			get
			{
				if (_lips_r_corner_stretch == null)
				{
					_lips_r_corner_stretch = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_stretch", cr2w, this);
				}
				return _lips_r_corner_stretch;
			}
			set
			{
				if (_lips_r_corner_stretch == value)
				{
					return;
				}
				_lips_r_corner_stretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("lips_l_stretch")] 
		public CFloat Lips_l_stretch
		{
			get
			{
				if (_lips_l_stretch == null)
				{
					_lips_l_stretch = (CFloat) CR2WTypeManager.Create("Float", "lips_l_stretch", cr2w, this);
				}
				return _lips_l_stretch;
			}
			set
			{
				if (_lips_l_stretch == value)
				{
					return;
				}
				_lips_l_stretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("lips_r_stretch")] 
		public CFloat Lips_r_stretch
		{
			get
			{
				if (_lips_r_stretch == null)
				{
					_lips_r_stretch = (CFloat) CR2WTypeManager.Create("Float", "lips_r_stretch", cr2w, this);
				}
				return _lips_r_stretch;
			}
			set
			{
				if (_lips_r_stretch == value)
				{
					return;
				}
				_lips_r_stretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("lips_l_corner_sharp_up")] 
		public CFloat Lips_l_corner_sharp_up
		{
			get
			{
				if (_lips_l_corner_sharp_up == null)
				{
					_lips_l_corner_sharp_up = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_sharp_up", cr2w, this);
				}
				return _lips_l_corner_sharp_up;
			}
			set
			{
				if (_lips_l_corner_sharp_up == value)
				{
					return;
				}
				_lips_l_corner_sharp_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("lips_r_corner_sharp_up")] 
		public CFloat Lips_r_corner_sharp_up
		{
			get
			{
				if (_lips_r_corner_sharp_up == null)
				{
					_lips_r_corner_sharp_up = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_sharp_up", cr2w, this);
				}
				return _lips_r_corner_sharp_up;
			}
			set
			{
				if (_lips_r_corner_sharp_up == value)
				{
					return;
				}
				_lips_r_corner_sharp_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("lips_suck_up")] 
		public CFloat Lips_suck_up
		{
			get
			{
				if (_lips_suck_up == null)
				{
					_lips_suck_up = (CFloat) CR2WTypeManager.Create("Float", "lips_suck_up", cr2w, this);
				}
				return _lips_suck_up;
			}
			set
			{
				if (_lips_suck_up == value)
				{
					return;
				}
				_lips_suck_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("lips_suck_dn")] 
		public CFloat Lips_suck_dn
		{
			get
			{
				if (_lips_suck_dn == null)
				{
					_lips_suck_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_suck_dn", cr2w, this);
				}
				return _lips_suck_dn;
			}
			set
			{
				if (_lips_suck_dn == value)
				{
					return;
				}
				_lips_suck_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("lips_puff_up")] 
		public CFloat Lips_puff_up
		{
			get
			{
				if (_lips_puff_up == null)
				{
					_lips_puff_up = (CFloat) CR2WTypeManager.Create("Float", "lips_puff_up", cr2w, this);
				}
				return _lips_puff_up;
			}
			set
			{
				if (_lips_puff_up == value)
				{
					return;
				}
				_lips_puff_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("lips_puff_dn")] 
		public CFloat Lips_puff_dn
		{
			get
			{
				if (_lips_puff_dn == null)
				{
					_lips_puff_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_puff_dn", cr2w, this);
				}
				return _lips_puff_dn;
			}
			set
			{
				if (_lips_puff_dn == value)
				{
					return;
				}
				_lips_puff_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("lips_apart_up")] 
		public CFloat Lips_apart_up
		{
			get
			{
				if (_lips_apart_up == null)
				{
					_lips_apart_up = (CFloat) CR2WTypeManager.Create("Float", "lips_apart_up", cr2w, this);
				}
				return _lips_apart_up;
			}
			set
			{
				if (_lips_apart_up == value)
				{
					return;
				}
				_lips_apart_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("lips_apart_dn")] 
		public CFloat Lips_apart_dn
		{
			get
			{
				if (_lips_apart_dn == null)
				{
					_lips_apart_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_apart_dn", cr2w, this);
				}
				return _lips_apart_dn;
			}
			set
			{
				if (_lips_apart_dn == value)
				{
					return;
				}
				_lips_apart_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("lips_l_lower_raise")] 
		public CFloat Lips_l_lower_raise
		{
			get
			{
				if (_lips_l_lower_raise == null)
				{
					_lips_l_lower_raise = (CFloat) CR2WTypeManager.Create("Float", "lips_l_lower_raise", cr2w, this);
				}
				return _lips_l_lower_raise;
			}
			set
			{
				if (_lips_l_lower_raise == value)
				{
					return;
				}
				_lips_l_lower_raise = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("lips_r_lower_raise")] 
		public CFloat Lips_r_lower_raise
		{
			get
			{
				if (_lips_r_lower_raise == null)
				{
					_lips_r_lower_raise = (CFloat) CR2WTypeManager.Create("Float", "lips_r_lower_raise", cr2w, this);
				}
				return _lips_r_lower_raise;
			}
			set
			{
				if (_lips_r_lower_raise == value)
				{
					return;
				}
				_lips_r_lower_raise = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("lips_l_corner_dn")] 
		public CFloat Lips_l_corner_dn
		{
			get
			{
				if (_lips_l_corner_dn == null)
				{
					_lips_l_corner_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dn", cr2w, this);
				}
				return _lips_l_corner_dn;
			}
			set
			{
				if (_lips_l_corner_dn == value)
				{
					return;
				}
				_lips_l_corner_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("lips_r_corner_dn")] 
		public CFloat Lips_r_corner_dn
		{
			get
			{
				if (_lips_r_corner_dn == null)
				{
					_lips_r_corner_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dn", cr2w, this);
				}
				return _lips_r_corner_dn;
			}
			set
			{
				if (_lips_r_corner_dn == value)
				{
					return;
				}
				_lips_r_corner_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("lips_chin_raise")] 
		public CFloat Lips_chin_raise
		{
			get
			{
				if (_lips_chin_raise == null)
				{
					_lips_chin_raise = (CFloat) CR2WTypeManager.Create("Float", "lips_chin_raise", cr2w, this);
				}
				return _lips_chin_raise;
			}
			set
			{
				if (_lips_chin_raise == value)
				{
					return;
				}
				_lips_chin_raise = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("lips_together_up")] 
		public CFloat Lips_together_up
		{
			get
			{
				if (_lips_together_up == null)
				{
					_lips_together_up = (CFloat) CR2WTypeManager.Create("Float", "lips_together_up", cr2w, this);
				}
				return _lips_together_up;
			}
			set
			{
				if (_lips_together_up == value)
				{
					return;
				}
				_lips_together_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("lips_together_dn")] 
		public CFloat Lips_together_dn
		{
			get
			{
				if (_lips_together_dn == null)
				{
					_lips_together_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_together_dn", cr2w, this);
				}
				return _lips_together_dn;
			}
			set
			{
				if (_lips_together_dn == value)
				{
					return;
				}
				_lips_together_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("lips_l_purse")] 
		public CFloat Lips_l_purse
		{
			get
			{
				if (_lips_l_purse == null)
				{
					_lips_l_purse = (CFloat) CR2WTypeManager.Create("Float", "lips_l_purse", cr2w, this);
				}
				return _lips_l_purse;
			}
			set
			{
				if (_lips_l_purse == value)
				{
					return;
				}
				_lips_l_purse = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("lips_r_purse")] 
		public CFloat Lips_r_purse
		{
			get
			{
				if (_lips_r_purse == null)
				{
					_lips_r_purse = (CFloat) CR2WTypeManager.Create("Float", "lips_r_purse", cr2w, this);
				}
				return _lips_r_purse;
			}
			set
			{
				if (_lips_r_purse == value)
				{
					return;
				}
				_lips_r_purse = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("lips_l_funnel")] 
		public CFloat Lips_l_funnel
		{
			get
			{
				if (_lips_l_funnel == null)
				{
					_lips_l_funnel = (CFloat) CR2WTypeManager.Create("Float", "lips_l_funnel", cr2w, this);
				}
				return _lips_l_funnel;
			}
			set
			{
				if (_lips_l_funnel == value)
				{
					return;
				}
				_lips_l_funnel = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("lips_r_funnel")] 
		public CFloat Lips_r_funnel
		{
			get
			{
				if (_lips_r_funnel == null)
				{
					_lips_r_funnel = (CFloat) CR2WTypeManager.Create("Float", "lips_r_funnel", cr2w, this);
				}
				return _lips_r_funnel;
			}
			set
			{
				if (_lips_r_funnel == value)
				{
					return;
				}
				_lips_r_funnel = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("lips_tighten_up")] 
		public CFloat Lips_tighten_up
		{
			get
			{
				if (_lips_tighten_up == null)
				{
					_lips_tighten_up = (CFloat) CR2WTypeManager.Create("Float", "lips_tighten_up", cr2w, this);
				}
				return _lips_tighten_up;
			}
			set
			{
				if (_lips_tighten_up == value)
				{
					return;
				}
				_lips_tighten_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("lips_tighten_dn")] 
		public CFloat Lips_tighten_dn
		{
			get
			{
				if (_lips_tighten_dn == null)
				{
					_lips_tighten_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_tighten_dn", cr2w, this);
				}
				return _lips_tighten_dn;
			}
			set
			{
				if (_lips_tighten_dn == value)
				{
					return;
				}
				_lips_tighten_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("lips_mid_shift_l")] 
		public CFloat Lips_mid_shift_l
		{
			get
			{
				if (_lips_mid_shift_l == null)
				{
					_lips_mid_shift_l = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_l", cr2w, this);
				}
				return _lips_mid_shift_l;
			}
			set
			{
				if (_lips_mid_shift_l == value)
				{
					return;
				}
				_lips_mid_shift_l = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("lips_mid_shift_r")] 
		public CFloat Lips_mid_shift_r
		{
			get
			{
				if (_lips_mid_shift_r == null)
				{
					_lips_mid_shift_r = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_r", cr2w, this);
				}
				return _lips_mid_shift_r;
			}
			set
			{
				if (_lips_mid_shift_r == value)
				{
					return;
				}
				_lips_mid_shift_r = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("lips_mid_shift_up")] 
		public CFloat Lips_mid_shift_up
		{
			get
			{
				if (_lips_mid_shift_up == null)
				{
					_lips_mid_shift_up = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_up", cr2w, this);
				}
				return _lips_mid_shift_up;
			}
			set
			{
				if (_lips_mid_shift_up == value)
				{
					return;
				}
				_lips_mid_shift_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("lips_mid_shift_dn")] 
		public CFloat Lips_mid_shift_dn
		{
			get
			{
				if (_lips_mid_shift_dn == null)
				{
					_lips_mid_shift_dn = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_dn", cr2w, this);
				}
				return _lips_mid_shift_dn;
			}
			set
			{
				if (_lips_mid_shift_dn == value)
				{
					return;
				}
				_lips_mid_shift_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("lips_corner_sticky")] 
		public CFloat Lips_corner_sticky
		{
			get
			{
				if (_lips_corner_sticky == null)
				{
					_lips_corner_sticky = (CFloat) CR2WTypeManager.Create("Float", "lips_corner_sticky", cr2w, this);
				}
				return _lips_corner_sticky;
			}
			set
			{
				if (_lips_corner_sticky == value)
				{
					return;
				}
				_lips_corner_sticky = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("lips_l_corner_up_in_sticky_cutScene")] 
		public CFloat Lips_l_corner_up_in_sticky_cutScene
		{
			get
			{
				if (_lips_l_corner_up_in_sticky_cutScene == null)
				{
					_lips_l_corner_up_in_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_up_in_sticky_cutScene", cr2w, this);
				}
				return _lips_l_corner_up_in_sticky_cutScene;
			}
			set
			{
				if (_lips_l_corner_up_in_sticky_cutScene == value)
				{
					return;
				}
				_lips_l_corner_up_in_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("lips_l_corner_dn_in_sticky_cutScene")] 
		public CFloat Lips_l_corner_dn_in_sticky_cutScene
		{
			get
			{
				if (_lips_l_corner_dn_in_sticky_cutScene == null)
				{
					_lips_l_corner_dn_in_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dn_in_sticky_cutScene", cr2w, this);
				}
				return _lips_l_corner_dn_in_sticky_cutScene;
			}
			set
			{
				if (_lips_l_corner_dn_in_sticky_cutScene == value)
				{
					return;
				}
				_lips_l_corner_dn_in_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(92)] 
		[RED("lips_l_corner_up_out_sticky_cutScene")] 
		public CFloat Lips_l_corner_up_out_sticky_cutScene
		{
			get
			{
				if (_lips_l_corner_up_out_sticky_cutScene == null)
				{
					_lips_l_corner_up_out_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_up_out_sticky_cutScene", cr2w, this);
				}
				return _lips_l_corner_up_out_sticky_cutScene;
			}
			set
			{
				if (_lips_l_corner_up_out_sticky_cutScene == value)
				{
					return;
				}
				_lips_l_corner_up_out_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(93)] 
		[RED("lips_l_corner_dn_out_sticky_cutScene")] 
		public CFloat Lips_l_corner_dn_out_sticky_cutScene
		{
			get
			{
				if (_lips_l_corner_dn_out_sticky_cutScene == null)
				{
					_lips_l_corner_dn_out_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dn_out_sticky_cutScene", cr2w, this);
				}
				return _lips_l_corner_dn_out_sticky_cutScene;
			}
			set
			{
				if (_lips_l_corner_dn_out_sticky_cutScene == value)
				{
					return;
				}
				_lips_l_corner_dn_out_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("lips_r_corner_up_in_sticky_cutScene")] 
		public CFloat Lips_r_corner_up_in_sticky_cutScene
		{
			get
			{
				if (_lips_r_corner_up_in_sticky_cutScene == null)
				{
					_lips_r_corner_up_in_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_up_in_sticky_cutScene", cr2w, this);
				}
				return _lips_r_corner_up_in_sticky_cutScene;
			}
			set
			{
				if (_lips_r_corner_up_in_sticky_cutScene == value)
				{
					return;
				}
				_lips_r_corner_up_in_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("lips_r_corner_up_out_sticky_cutScene")] 
		public CFloat Lips_r_corner_up_out_sticky_cutScene
		{
			get
			{
				if (_lips_r_corner_up_out_sticky_cutScene == null)
				{
					_lips_r_corner_up_out_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_up_out_sticky_cutScene", cr2w, this);
				}
				return _lips_r_corner_up_out_sticky_cutScene;
			}
			set
			{
				if (_lips_r_corner_up_out_sticky_cutScene == value)
				{
					return;
				}
				_lips_r_corner_up_out_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("lips_r_corner_dn_in_sticky_cutScene")] 
		public CFloat Lips_r_corner_dn_in_sticky_cutScene
		{
			get
			{
				if (_lips_r_corner_dn_in_sticky_cutScene == null)
				{
					_lips_r_corner_dn_in_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dn_in_sticky_cutScene", cr2w, this);
				}
				return _lips_r_corner_dn_in_sticky_cutScene;
			}
			set
			{
				if (_lips_r_corner_dn_in_sticky_cutScene == value)
				{
					return;
				}
				_lips_r_corner_dn_in_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("lips_r_corner_dn_out_sticky_cutScene")] 
		public CFloat Lips_r_corner_dn_out_sticky_cutScene
		{
			get
			{
				if (_lips_r_corner_dn_out_sticky_cutScene == null)
				{
					_lips_r_corner_dn_out_sticky_cutScene = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dn_out_sticky_cutScene", cr2w, this);
				}
				return _lips_r_corner_dn_out_sticky_cutScene;
			}
			set
			{
				if (_lips_r_corner_dn_out_sticky_cutScene == value)
				{
					return;
				}
				_lips_r_corner_dn_out_sticky_cutScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("cheek_l_suck")] 
		public CFloat Cheek_l_suck
		{
			get
			{
				if (_cheek_l_suck == null)
				{
					_cheek_l_suck = (CFloat) CR2WTypeManager.Create("Float", "cheek_l_suck", cr2w, this);
				}
				return _cheek_l_suck;
			}
			set
			{
				if (_cheek_l_suck == value)
				{
					return;
				}
				_cheek_l_suck = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("cheek_r_suck")] 
		public CFloat Cheek_r_suck
		{
			get
			{
				if (_cheek_r_suck == null)
				{
					_cheek_r_suck = (CFloat) CR2WTypeManager.Create("Float", "cheek_r_suck", cr2w, this);
				}
				return _cheek_r_suck;
			}
			set
			{
				if (_cheek_r_suck == value)
				{
					return;
				}
				_cheek_r_suck = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("cheek_l_puff")] 
		public CFloat Cheek_l_puff
		{
			get
			{
				if (_cheek_l_puff == null)
				{
					_cheek_l_puff = (CFloat) CR2WTypeManager.Create("Float", "cheek_l_puff", cr2w, this);
				}
				return _cheek_l_puff;
			}
			set
			{
				if (_cheek_l_puff == value)
				{
					return;
				}
				_cheek_l_puff = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("cheek_r_puff")] 
		public CFloat Cheek_r_puff
		{
			get
			{
				if (_cheek_r_puff == null)
				{
					_cheek_r_puff = (CFloat) CR2WTypeManager.Create("Float", "cheek_r_puff", cr2w, this);
				}
				return _cheek_r_puff;
			}
			set
			{
				if (_cheek_r_puff == value)
				{
					return;
				}
				_cheek_r_puff = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("jaw_mid_open")] 
		public CFloat Jaw_mid_open
		{
			get
			{
				if (_jaw_mid_open == null)
				{
					_jaw_mid_open = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_open", cr2w, this);
				}
				return _jaw_mid_open;
			}
			set
			{
				if (_jaw_mid_open == value)
				{
					return;
				}
				_jaw_mid_open = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("jaw_mid_close")] 
		public CFloat Jaw_mid_close
		{
			get
			{
				if (_jaw_mid_close == null)
				{
					_jaw_mid_close = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_close", cr2w, this);
				}
				return _jaw_mid_close;
			}
			set
			{
				if (_jaw_mid_close == value)
				{
					return;
				}
				_jaw_mid_close = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("jaw_mid_shift_l")] 
		public CFloat Jaw_mid_shift_l
		{
			get
			{
				if (_jaw_mid_shift_l == null)
				{
					_jaw_mid_shift_l = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_l", cr2w, this);
				}
				return _jaw_mid_shift_l;
			}
			set
			{
				if (_jaw_mid_shift_l == value)
				{
					return;
				}
				_jaw_mid_shift_l = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("jaw_mid_shift_r")] 
		public CFloat Jaw_mid_shift_r
		{
			get
			{
				if (_jaw_mid_shift_r == null)
				{
					_jaw_mid_shift_r = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_r", cr2w, this);
				}
				return _jaw_mid_shift_r;
			}
			set
			{
				if (_jaw_mid_shift_r == value)
				{
					return;
				}
				_jaw_mid_shift_r = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("jaw_mid_shift_fwd")] 
		public CFloat Jaw_mid_shift_fwd
		{
			get
			{
				if (_jaw_mid_shift_fwd == null)
				{
					_jaw_mid_shift_fwd = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_fwd", cr2w, this);
				}
				return _jaw_mid_shift_fwd;
			}
			set
			{
				if (_jaw_mid_shift_fwd == value)
				{
					return;
				}
				_jaw_mid_shift_fwd = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("jaw_mid_shift_back")] 
		public CFloat Jaw_mid_shift_back
		{
			get
			{
				if (_jaw_mid_shift_back == null)
				{
					_jaw_mid_shift_back = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_back", cr2w, this);
				}
				return _jaw_mid_shift_back;
			}
			set
			{
				if (_jaw_mid_shift_back == value)
				{
					return;
				}
				_jaw_mid_shift_back = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("jaw_mid_clench")] 
		public CFloat Jaw_mid_clench
		{
			get
			{
				if (_jaw_mid_clench == null)
				{
					_jaw_mid_clench = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_clench", cr2w, this);
				}
				return _jaw_mid_clench;
			}
			set
			{
				if (_jaw_mid_clench == value)
				{
					return;
				}
				_jaw_mid_clench = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("neck_l_stretch")] 
		public CFloat Neck_l_stretch
		{
			get
			{
				if (_neck_l_stretch == null)
				{
					_neck_l_stretch = (CFloat) CR2WTypeManager.Create("Float", "neck_l_stretch", cr2w, this);
				}
				return _neck_l_stretch;
			}
			set
			{
				if (_neck_l_stretch == value)
				{
					return;
				}
				_neck_l_stretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("neck_r_stretch")] 
		public CFloat Neck_r_stretch
		{
			get
			{
				if (_neck_r_stretch == null)
				{
					_neck_r_stretch = (CFloat) CR2WTypeManager.Create("Float", "neck_r_stretch", cr2w, this);
				}
				return _neck_r_stretch;
			}
			set
			{
				if (_neck_r_stretch == value)
				{
					return;
				}
				_neck_r_stretch = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("neck_tighten")] 
		public CFloat Neck_tighten
		{
			get
			{
				if (_neck_tighten == null)
				{
					_neck_tighten = (CFloat) CR2WTypeManager.Create("Float", "neck_tighten", cr2w, this);
				}
				return _neck_tighten;
			}
			set
			{
				if (_neck_tighten == value)
				{
					return;
				}
				_neck_tighten = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("neck_l_sternocleidomastoid_flex")] 
		public CFloat Neck_l_sternocleidomastoid_flex
		{
			get
			{
				if (_neck_l_sternocleidomastoid_flex == null)
				{
					_neck_l_sternocleidomastoid_flex = (CFloat) CR2WTypeManager.Create("Float", "neck_l_sternocleidomastoid_flex", cr2w, this);
				}
				return _neck_l_sternocleidomastoid_flex;
			}
			set
			{
				if (_neck_l_sternocleidomastoid_flex == value)
				{
					return;
				}
				_neck_l_sternocleidomastoid_flex = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("neck_r_sternocleidomastoid_flex")] 
		public CFloat Neck_r_sternocleidomastoid_flex
		{
			get
			{
				if (_neck_r_sternocleidomastoid_flex == null)
				{
					_neck_r_sternocleidomastoid_flex = (CFloat) CR2WTypeManager.Create("Float", "neck_r_sternocleidomastoid_flex", cr2w, this);
				}
				return _neck_r_sternocleidomastoid_flex;
			}
			set
			{
				if (_neck_r_sternocleidomastoid_flex == value)
				{
					return;
				}
				_neck_r_sternocleidomastoid_flex = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("neck_l_platysma_flex")] 
		public CFloat Neck_l_platysma_flex
		{
			get
			{
				if (_neck_l_platysma_flex == null)
				{
					_neck_l_platysma_flex = (CFloat) CR2WTypeManager.Create("Float", "neck_l_platysma_flex", cr2w, this);
				}
				return _neck_l_platysma_flex;
			}
			set
			{
				if (_neck_l_platysma_flex == value)
				{
					return;
				}
				_neck_l_platysma_flex = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("neck_r_platysma_flex")] 
		public CFloat Neck_r_platysma_flex
		{
			get
			{
				if (_neck_r_platysma_flex == null)
				{
					_neck_r_platysma_flex = (CFloat) CR2WTypeManager.Create("Float", "neck_r_platysma_flex", cr2w, this);
				}
				return _neck_r_platysma_flex;
			}
			set
			{
				if (_neck_r_platysma_flex == value)
				{
					return;
				}
				_neck_r_platysma_flex = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("neck_throat_adamsApple_up")] 
		public CFloat Neck_throat_adamsApple_up
		{
			get
			{
				if (_neck_throat_adamsApple_up == null)
				{
					_neck_throat_adamsApple_up = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_adamsApple_up", cr2w, this);
				}
				return _neck_throat_adamsApple_up;
			}
			set
			{
				if (_neck_throat_adamsApple_up == value)
				{
					return;
				}
				_neck_throat_adamsApple_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("neck_throat_adamsApple_dn")] 
		public CFloat Neck_throat_adamsApple_dn
		{
			get
			{
				if (_neck_throat_adamsApple_dn == null)
				{
					_neck_throat_adamsApple_dn = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_adamsApple_dn", cr2w, this);
				}
				return _neck_throat_adamsApple_dn;
			}
			set
			{
				if (_neck_throat_adamsApple_dn == value)
				{
					return;
				}
				_neck_throat_adamsApple_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("neck_throat_compress")] 
		public CFloat Neck_throat_compress
		{
			get
			{
				if (_neck_throat_compress == null)
				{
					_neck_throat_compress = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_compress", cr2w, this);
				}
				return _neck_throat_compress;
			}
			set
			{
				if (_neck_throat_compress == value)
				{
					return;
				}
				_neck_throat_compress = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("neck_throat_open")] 
		public CFloat Neck_throat_open
		{
			get
			{
				if (_neck_throat_open == null)
				{
					_neck_throat_open = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_open", cr2w, this);
				}
				return _neck_throat_open;
			}
			set
			{
				if (_neck_throat_open == value)
				{
					return;
				}
				_neck_throat_open = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("neck_l_turn")] 
		public CFloat Neck_l_turn
		{
			get
			{
				if (_neck_l_turn == null)
				{
					_neck_l_turn = (CFloat) CR2WTypeManager.Create("Float", "neck_l_turn", cr2w, this);
				}
				return _neck_l_turn;
			}
			set
			{
				if (_neck_l_turn == value)
				{
					return;
				}
				_neck_l_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("neck_r_turn")] 
		public CFloat Neck_r_turn
		{
			get
			{
				if (_neck_r_turn == null)
				{
					_neck_r_turn = (CFloat) CR2WTypeManager.Create("Float", "neck_r_turn", cr2w, this);
				}
				return _neck_r_turn;
			}
			set
			{
				if (_neck_r_turn == value)
				{
					return;
				}
				_neck_r_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("neck_up_turn")] 
		public CFloat Neck_up_turn
		{
			get
			{
				if (_neck_up_turn == null)
				{
					_neck_up_turn = (CFloat) CR2WTypeManager.Create("Float", "neck_up_turn", cr2w, this);
				}
				return _neck_up_turn;
			}
			set
			{
				if (_neck_up_turn == value)
				{
					return;
				}
				_neck_up_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("neck_dn_turn")] 
		public CFloat Neck_dn_turn
		{
			get
			{
				if (_neck_dn_turn == null)
				{
					_neck_dn_turn = (CFloat) CR2WTypeManager.Create("Float", "neck_dn_turn", cr2w, this);
				}
				return _neck_dn_turn;
			}
			set
			{
				if (_neck_dn_turn == value)
				{
					return;
				}
				_neck_dn_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("neck_l_tilt")] 
		public CFloat Neck_l_tilt
		{
			get
			{
				if (_neck_l_tilt == null)
				{
					_neck_l_tilt = (CFloat) CR2WTypeManager.Create("Float", "neck_l_tilt", cr2w, this);
				}
				return _neck_l_tilt;
			}
			set
			{
				if (_neck_l_tilt == value)
				{
					return;
				}
				_neck_l_tilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("neck_r_tilt")] 
		public CFloat Neck_r_tilt
		{
			get
			{
				if (_neck_r_tilt == null)
				{
					_neck_r_tilt = (CFloat) CR2WTypeManager.Create("Float", "neck_r_tilt", cr2w, this);
				}
				return _neck_r_tilt;
			}
			set
			{
				if (_neck_r_tilt == value)
				{
					return;
				}
				_neck_r_tilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("head_neck_up_turn")] 
		public CFloat Head_neck_up_turn
		{
			get
			{
				if (_head_neck_up_turn == null)
				{
					_head_neck_up_turn = (CFloat) CR2WTypeManager.Create("Float", "head_neck_up_turn", cr2w, this);
				}
				return _head_neck_up_turn;
			}
			set
			{
				if (_head_neck_up_turn == value)
				{
					return;
				}
				_head_neck_up_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(127)] 
		[RED("head_neck_dn_turn")] 
		public CFloat Head_neck_dn_turn
		{
			get
			{
				if (_head_neck_dn_turn == null)
				{
					_head_neck_dn_turn = (CFloat) CR2WTypeManager.Create("Float", "head_neck_dn_turn", cr2w, this);
				}
				return _head_neck_dn_turn;
			}
			set
			{
				if (_head_neck_dn_turn == value)
				{
					return;
				}
				_head_neck_dn_turn = value;
				PropertySet(this);
			}
		}

		[Ordinal(128)] 
		[RED("head_neck_l_tilt")] 
		public CFloat Head_neck_l_tilt
		{
			get
			{
				if (_head_neck_l_tilt == null)
				{
					_head_neck_l_tilt = (CFloat) CR2WTypeManager.Create("Float", "head_neck_l_tilt", cr2w, this);
				}
				return _head_neck_l_tilt;
			}
			set
			{
				if (_head_neck_l_tilt == value)
				{
					return;
				}
				_head_neck_l_tilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(129)] 
		[RED("head_neck_r_tilt")] 
		public CFloat Head_neck_r_tilt
		{
			get
			{
				if (_head_neck_r_tilt == null)
				{
					_head_neck_r_tilt = (CFloat) CR2WTypeManager.Create("Float", "head_neck_r_tilt", cr2w, this);
				}
				return _head_neck_r_tilt;
			}
			set
			{
				if (_head_neck_r_tilt == value)
				{
					return;
				}
				_head_neck_r_tilt = value;
				PropertySet(this);
			}
		}

		[Ordinal(130)] 
		[RED("ear_l_shift_up")] 
		public CFloat Ear_l_shift_up
		{
			get
			{
				if (_ear_l_shift_up == null)
				{
					_ear_l_shift_up = (CFloat) CR2WTypeManager.Create("Float", "ear_l_shift_up", cr2w, this);
				}
				return _ear_l_shift_up;
			}
			set
			{
				if (_ear_l_shift_up == value)
				{
					return;
				}
				_ear_l_shift_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(131)] 
		[RED("ear_r_shift_up")] 
		public CFloat Ear_r_shift_up
		{
			get
			{
				if (_ear_r_shift_up == null)
				{
					_ear_r_shift_up = (CFloat) CR2WTypeManager.Create("Float", "ear_r_shift_up", cr2w, this);
				}
				return _ear_r_shift_up;
			}
			set
			{
				if (_ear_r_shift_up == value)
				{
					return;
				}
				_ear_r_shift_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(132)] 
		[RED("sculp_mid_slide")] 
		public CFloat Sculp_mid_slide
		{
			get
			{
				if (_sculp_mid_slide == null)
				{
					_sculp_mid_slide = (CFloat) CR2WTypeManager.Create("Float", "sculp_mid_slide", cr2w, this);
				}
				return _sculp_mid_slide;
			}
			set
			{
				if (_sculp_mid_slide == value)
				{
					return;
				}
				_sculp_mid_slide = value;
				PropertySet(this);
			}
		}

		[Ordinal(133)] 
		[RED("face_gravity_fwd")] 
		public CFloat Face_gravity_fwd
		{
			get
			{
				if (_face_gravity_fwd == null)
				{
					_face_gravity_fwd = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_fwd", cr2w, this);
				}
				return _face_gravity_fwd;
			}
			set
			{
				if (_face_gravity_fwd == value)
				{
					return;
				}
				_face_gravity_fwd = value;
				PropertySet(this);
			}
		}

		[Ordinal(134)] 
		[RED("face_gravity_back")] 
		public CFloat Face_gravity_back
		{
			get
			{
				if (_face_gravity_back == null)
				{
					_face_gravity_back = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_back", cr2w, this);
				}
				return _face_gravity_back;
			}
			set
			{
				if (_face_gravity_back == value)
				{
					return;
				}
				_face_gravity_back = value;
				PropertySet(this);
			}
		}

		[Ordinal(135)] 
		[RED("face_gravity_l")] 
		public CFloat Face_gravity_l
		{
			get
			{
				if (_face_gravity_l == null)
				{
					_face_gravity_l = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_l", cr2w, this);
				}
				return _face_gravity_l;
			}
			set
			{
				if (_face_gravity_l == value)
				{
					return;
				}
				_face_gravity_l = value;
				PropertySet(this);
			}
		}

		[Ordinal(136)] 
		[RED("face_gravity_r")] 
		public CFloat Face_gravity_r
		{
			get
			{
				if (_face_gravity_r == null)
				{
					_face_gravity_r = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_r", cr2w, this);
				}
				return _face_gravity_r;
			}
			set
			{
				if (_face_gravity_r == value)
				{
					return;
				}
				_face_gravity_r = value;
				PropertySet(this);
			}
		}

		[Ordinal(137)] 
		[RED("tongue_mid_base_l")] 
		public CFloat Tongue_mid_base_l
		{
			get
			{
				if (_tongue_mid_base_l == null)
				{
					_tongue_mid_base_l = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_l", cr2w, this);
				}
				return _tongue_mid_base_l;
			}
			set
			{
				if (_tongue_mid_base_l == value)
				{
					return;
				}
				_tongue_mid_base_l = value;
				PropertySet(this);
			}
		}

		[Ordinal(138)] 
		[RED("tongue_mid_base_r")] 
		public CFloat Tongue_mid_base_r
		{
			get
			{
				if (_tongue_mid_base_r == null)
				{
					_tongue_mid_base_r = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_r", cr2w, this);
				}
				return _tongue_mid_base_r;
			}
			set
			{
				if (_tongue_mid_base_r == value)
				{
					return;
				}
				_tongue_mid_base_r = value;
				PropertySet(this);
			}
		}

		[Ordinal(139)] 
		[RED("tongue_mid_base_dn")] 
		public CFloat Tongue_mid_base_dn
		{
			get
			{
				if (_tongue_mid_base_dn == null)
				{
					_tongue_mid_base_dn = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_dn", cr2w, this);
				}
				return _tongue_mid_base_dn;
			}
			set
			{
				if (_tongue_mid_base_dn == value)
				{
					return;
				}
				_tongue_mid_base_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(140)] 
		[RED("tongue_mid_base_up")] 
		public CFloat Tongue_mid_base_up
		{
			get
			{
				if (_tongue_mid_base_up == null)
				{
					_tongue_mid_base_up = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_up", cr2w, this);
				}
				return _tongue_mid_base_up;
			}
			set
			{
				if (_tongue_mid_base_up == value)
				{
					return;
				}
				_tongue_mid_base_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(141)] 
		[RED("tongue_mid_base_fwd")] 
		public CFloat Tongue_mid_base_fwd
		{
			get
			{
				if (_tongue_mid_base_fwd == null)
				{
					_tongue_mid_base_fwd = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_fwd", cr2w, this);
				}
				return _tongue_mid_base_fwd;
			}
			set
			{
				if (_tongue_mid_base_fwd == value)
				{
					return;
				}
				_tongue_mid_base_fwd = value;
				PropertySet(this);
			}
		}

		[Ordinal(142)] 
		[RED("tongue_mid_base_front")] 
		public CFloat Tongue_mid_base_front
		{
			get
			{
				if (_tongue_mid_base_front == null)
				{
					_tongue_mid_base_front = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_front", cr2w, this);
				}
				return _tongue_mid_base_front;
			}
			set
			{
				if (_tongue_mid_base_front == value)
				{
					return;
				}
				_tongue_mid_base_front = value;
				PropertySet(this);
			}
		}

		[Ordinal(143)] 
		[RED("tongue_mid_base_back")] 
		public CFloat Tongue_mid_base_back
		{
			get
			{
				if (_tongue_mid_base_back == null)
				{
					_tongue_mid_base_back = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_back", cr2w, this);
				}
				return _tongue_mid_base_back;
			}
			set
			{
				if (_tongue_mid_base_back == value)
				{
					return;
				}
				_tongue_mid_base_back = value;
				PropertySet(this);
			}
		}

		[Ordinal(144)] 
		[RED("tongue_mid_fwd")] 
		public CFloat Tongue_mid_fwd
		{
			get
			{
				if (_tongue_mid_fwd == null)
				{
					_tongue_mid_fwd = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_fwd", cr2w, this);
				}
				return _tongue_mid_fwd;
			}
			set
			{
				if (_tongue_mid_fwd == value)
				{
					return;
				}
				_tongue_mid_fwd = value;
				PropertySet(this);
			}
		}

		[Ordinal(145)] 
		[RED("tongue_mid_lift")] 
		public CFloat Tongue_mid_lift
		{
			get
			{
				if (_tongue_mid_lift == null)
				{
					_tongue_mid_lift = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_lift", cr2w, this);
				}
				return _tongue_mid_lift;
			}
			set
			{
				if (_tongue_mid_lift == value)
				{
					return;
				}
				_tongue_mid_lift = value;
				PropertySet(this);
			}
		}

		[Ordinal(146)] 
		[RED("tongue_mid_tip_l")] 
		public CFloat Tongue_mid_tip_l
		{
			get
			{
				if (_tongue_mid_tip_l == null)
				{
					_tongue_mid_tip_l = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_l", cr2w, this);
				}
				return _tongue_mid_tip_l;
			}
			set
			{
				if (_tongue_mid_tip_l == value)
				{
					return;
				}
				_tongue_mid_tip_l = value;
				PropertySet(this);
			}
		}

		[Ordinal(147)] 
		[RED("tongue_mid_tip_r")] 
		public CFloat Tongue_mid_tip_r
		{
			get
			{
				if (_tongue_mid_tip_r == null)
				{
					_tongue_mid_tip_r = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_r", cr2w, this);
				}
				return _tongue_mid_tip_r;
			}
			set
			{
				if (_tongue_mid_tip_r == value)
				{
					return;
				}
				_tongue_mid_tip_r = value;
				PropertySet(this);
			}
		}

		[Ordinal(148)] 
		[RED("tongue_mid_tip_dn")] 
		public CFloat Tongue_mid_tip_dn
		{
			get
			{
				if (_tongue_mid_tip_dn == null)
				{
					_tongue_mid_tip_dn = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_dn", cr2w, this);
				}
				return _tongue_mid_tip_dn;
			}
			set
			{
				if (_tongue_mid_tip_dn == value)
				{
					return;
				}
				_tongue_mid_tip_dn = value;
				PropertySet(this);
			}
		}

		[Ordinal(149)] 
		[RED("tongue_mid_tip_up")] 
		public CFloat Tongue_mid_tip_up
		{
			get
			{
				if (_tongue_mid_tip_up == null)
				{
					_tongue_mid_tip_up = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_up", cr2w, this);
				}
				return _tongue_mid_tip_up;
			}
			set
			{
				if (_tongue_mid_tip_up == value)
				{
					return;
				}
				_tongue_mid_tip_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(150)] 
		[RED("tongue_mid_twist_l")] 
		public CFloat Tongue_mid_twist_l
		{
			get
			{
				if (_tongue_mid_twist_l == null)
				{
					_tongue_mid_twist_l = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_twist_l", cr2w, this);
				}
				return _tongue_mid_twist_l;
			}
			set
			{
				if (_tongue_mid_twist_l == value)
				{
					return;
				}
				_tongue_mid_twist_l = value;
				PropertySet(this);
			}
		}

		[Ordinal(151)] 
		[RED("tongue_mid_twist_r")] 
		public CFloat Tongue_mid_twist_r
		{
			get
			{
				if (_tongue_mid_twist_r == null)
				{
					_tongue_mid_twist_r = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_twist_r", cr2w, this);
				}
				return _tongue_mid_twist_r;
			}
			set
			{
				if (_tongue_mid_twist_r == value)
				{
					return;
				}
				_tongue_mid_twist_r = value;
				PropertySet(this);
			}
		}

		[Ordinal(152)] 
		[RED("tongue_mid_thick")] 
		public CFloat Tongue_mid_thick
		{
			get
			{
				if (_tongue_mid_thick == null)
				{
					_tongue_mid_thick = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_thick", cr2w, this);
				}
				return _tongue_mid_thick;
			}
			set
			{
				if (_tongue_mid_thick == value)
				{
					return;
				}
				_tongue_mid_thick = value;
				PropertySet(this);
			}
		}

		[Ordinal(153)] 
		[RED("nose_l_snearAnimOverrideWeight")] 
		public CFloat Nose_l_snearAnimOverrideWeight
		{
			get
			{
				if (_nose_l_snearAnimOverrideWeight == null)
				{
					_nose_l_snearAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "nose_l_snearAnimOverrideWeight", cr2w, this);
				}
				return _nose_l_snearAnimOverrideWeight;
			}
			set
			{
				if (_nose_l_snearAnimOverrideWeight == value)
				{
					return;
				}
				_nose_l_snearAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(154)] 
		[RED("nose_r_snearAnimOverrideWeight")] 
		public CFloat Nose_r_snearAnimOverrideWeight
		{
			get
			{
				if (_nose_r_snearAnimOverrideWeight == null)
				{
					_nose_r_snearAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "nose_r_snearAnimOverrideWeight", cr2w, this);
				}
				return _nose_r_snearAnimOverrideWeight;
			}
			set
			{
				if (_nose_r_snearAnimOverrideWeight == value)
				{
					return;
				}
				_nose_r_snearAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(155)] 
		[RED("lips_l_nasolabialDeepenerAnimOverrideWeight")] 
		public CFloat Lips_l_nasolabialDeepenerAnimOverrideWeight
		{
			get
			{
				if (_lips_l_nasolabialDeepenerAnimOverrideWeight == null)
				{
					_lips_l_nasolabialDeepenerAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_nasolabialDeepenerAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_nasolabialDeepenerAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_nasolabialDeepenerAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_nasolabialDeepenerAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(156)] 
		[RED("lips_r_nasolabialDeepenerAnimOverrideWeight")] 
		public CFloat Lips_r_nasolabialDeepenerAnimOverrideWeight
		{
			get
			{
				if (_lips_r_nasolabialDeepenerAnimOverrideWeight == null)
				{
					_lips_r_nasolabialDeepenerAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_nasolabialDeepenerAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_nasolabialDeepenerAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_nasolabialDeepenerAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_nasolabialDeepenerAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(157)] 
		[RED("lips_l_upper_raiseAnimOverrideWeight")] 
		public CFloat Lips_l_upper_raiseAnimOverrideWeight
		{
			get
			{
				if (_lips_l_upper_raiseAnimOverrideWeight == null)
				{
					_lips_l_upper_raiseAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_upper_raiseAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_upper_raiseAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_upper_raiseAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_upper_raiseAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(158)] 
		[RED("lips_r_upper_raiseAnimOverrideWeight")] 
		public CFloat Lips_r_upper_raiseAnimOverrideWeight
		{
			get
			{
				if (_lips_r_upper_raiseAnimOverrideWeight == null)
				{
					_lips_r_upper_raiseAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_upper_raiseAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_upper_raiseAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_upper_raiseAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_upper_raiseAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(159)] 
		[RED("lips_l_pullAnimOverrideWeight")] 
		public CFloat Lips_l_pullAnimOverrideWeight
		{
			get
			{
				if (_lips_l_pullAnimOverrideWeight == null)
				{
					_lips_l_pullAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_pullAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_pullAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_pullAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_pullAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(160)] 
		[RED("lips_r_pullAnimOverrideWeight")] 
		public CFloat Lips_r_pullAnimOverrideWeight
		{
			get
			{
				if (_lips_r_pullAnimOverrideWeight == null)
				{
					_lips_r_pullAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_pullAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_pullAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_pullAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_pullAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(161)] 
		[RED("lips_l_corner_upAnimOverrideWeight")] 
		public CFloat Lips_l_corner_upAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_upAnimOverrideWeight == null)
				{
					_lips_l_corner_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(162)] 
		[RED("lips_r_corner_upAnimOverrideWeight")] 
		public CFloat Lips_r_corner_upAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_upAnimOverrideWeight == null)
				{
					_lips_r_corner_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(163)] 
		[RED("lips_l_corner_wideAnimOverrideWeight")] 
		public CFloat Lips_l_corner_wideAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_wideAnimOverrideWeight == null)
				{
					_lips_l_corner_wideAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_wideAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_wideAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_wideAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_wideAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(164)] 
		[RED("lips_r_corner_wideAnimOverrideWeight")] 
		public CFloat Lips_r_corner_wideAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_wideAnimOverrideWeight == null)
				{
					_lips_r_corner_wideAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_wideAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_wideAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_wideAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_wideAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(165)] 
		[RED("lips_l_corner_stretchAnimOverrideWeight")] 
		public CFloat Lips_l_corner_stretchAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_stretchAnimOverrideWeight == null)
				{
					_lips_l_corner_stretchAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_stretchAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_stretchAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_stretchAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_stretchAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(166)] 
		[RED("lips_r_corner_stretchAnimOverrideWeight")] 
		public CFloat Lips_r_corner_stretchAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_stretchAnimOverrideWeight == null)
				{
					_lips_r_corner_stretchAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_stretchAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_stretchAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_stretchAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_stretchAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(167)] 
		[RED("lips_l_stretchAnimOverrideWeight")] 
		public CFloat Lips_l_stretchAnimOverrideWeight
		{
			get
			{
				if (_lips_l_stretchAnimOverrideWeight == null)
				{
					_lips_l_stretchAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_stretchAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_stretchAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_stretchAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_stretchAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(168)] 
		[RED("lips_r_stretchAnimOverrideWeight")] 
		public CFloat Lips_r_stretchAnimOverrideWeight
		{
			get
			{
				if (_lips_r_stretchAnimOverrideWeight == null)
				{
					_lips_r_stretchAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_stretchAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_stretchAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_stretchAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_stretchAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(169)] 
		[RED("lips_l_corner_sharp_upAnimOverrideWeight")] 
		public CFloat Lips_l_corner_sharp_upAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_sharp_upAnimOverrideWeight == null)
				{
					_lips_l_corner_sharp_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_sharp_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_sharp_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_sharp_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_sharp_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(170)] 
		[RED("lips_r_corner_sharp_upAnimOverrideWeight")] 
		public CFloat Lips_r_corner_sharp_upAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_sharp_upAnimOverrideWeight == null)
				{
					_lips_r_corner_sharp_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_sharp_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_sharp_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_sharp_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_sharp_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(171)] 
		[RED("lips_suck_upAnimOverrideWeight")] 
		public CFloat Lips_suck_upAnimOverrideWeight
		{
			get
			{
				if (_lips_suck_upAnimOverrideWeight == null)
				{
					_lips_suck_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_suck_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_suck_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_suck_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_suck_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(172)] 
		[RED("lips_suck_dnAnimOverrideWeight")] 
		public CFloat Lips_suck_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_suck_dnAnimOverrideWeight == null)
				{
					_lips_suck_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_suck_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_suck_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_suck_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_suck_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(173)] 
		[RED("lips_puff_upAnimOverrideWeight")] 
		public CFloat Lips_puff_upAnimOverrideWeight
		{
			get
			{
				if (_lips_puff_upAnimOverrideWeight == null)
				{
					_lips_puff_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_puff_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_puff_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_puff_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_puff_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(174)] 
		[RED("lips_puff_dnAnimOverrideWeight")] 
		public CFloat Lips_puff_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_puff_dnAnimOverrideWeight == null)
				{
					_lips_puff_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_puff_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_puff_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_puff_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_puff_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(175)] 
		[RED("lips_apart_upAnimOverrideWeight")] 
		public CFloat Lips_apart_upAnimOverrideWeight
		{
			get
			{
				if (_lips_apart_upAnimOverrideWeight == null)
				{
					_lips_apart_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_apart_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_apart_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_apart_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_apart_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(176)] 
		[RED("lips_apart_dnAnimOverrideWeight")] 
		public CFloat Lips_apart_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_apart_dnAnimOverrideWeight == null)
				{
					_lips_apart_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_apart_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_apart_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_apart_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_apart_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(177)] 
		[RED("lips_l_lower_raiseAnimOverrideWeight")] 
		public CFloat Lips_l_lower_raiseAnimOverrideWeight
		{
			get
			{
				if (_lips_l_lower_raiseAnimOverrideWeight == null)
				{
					_lips_l_lower_raiseAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_lower_raiseAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_lower_raiseAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_lower_raiseAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_lower_raiseAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(178)] 
		[RED("lips_r_lower_raiseAnimOverrideWeight")] 
		public CFloat Lips_r_lower_raiseAnimOverrideWeight
		{
			get
			{
				if (_lips_r_lower_raiseAnimOverrideWeight == null)
				{
					_lips_r_lower_raiseAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_lower_raiseAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_lower_raiseAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_lower_raiseAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_lower_raiseAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(179)] 
		[RED("lips_l_corner_dnAnimOverrideWeight")] 
		public CFloat Lips_l_corner_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_dnAnimOverrideWeight == null)
				{
					_lips_l_corner_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(180)] 
		[RED("lips_r_corner_dnAnimOverrideWeight")] 
		public CFloat Lips_r_corner_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_dnAnimOverrideWeight == null)
				{
					_lips_r_corner_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(181)] 
		[RED("lips_chin_raiseAnimOverrideWeight")] 
		public CFloat Lips_chin_raiseAnimOverrideWeight
		{
			get
			{
				if (_lips_chin_raiseAnimOverrideWeight == null)
				{
					_lips_chin_raiseAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_chin_raiseAnimOverrideWeight", cr2w, this);
				}
				return _lips_chin_raiseAnimOverrideWeight;
			}
			set
			{
				if (_lips_chin_raiseAnimOverrideWeight == value)
				{
					return;
				}
				_lips_chin_raiseAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(182)] 
		[RED("lips_together_upAnimOverrideWeight")] 
		public CFloat Lips_together_upAnimOverrideWeight
		{
			get
			{
				if (_lips_together_upAnimOverrideWeight == null)
				{
					_lips_together_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_together_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_together_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_together_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_together_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(183)] 
		[RED("lips_together_dnAnimOverrideWeight")] 
		public CFloat Lips_together_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_together_dnAnimOverrideWeight == null)
				{
					_lips_together_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_together_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_together_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_together_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_together_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(184)] 
		[RED("lips_l_purseAnimOverrideWeight")] 
		public CFloat Lips_l_purseAnimOverrideWeight
		{
			get
			{
				if (_lips_l_purseAnimOverrideWeight == null)
				{
					_lips_l_purseAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_purseAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_purseAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_purseAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_purseAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(185)] 
		[RED("lips_r_purseAnimOverrideWeight")] 
		public CFloat Lips_r_purseAnimOverrideWeight
		{
			get
			{
				if (_lips_r_purseAnimOverrideWeight == null)
				{
					_lips_r_purseAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_purseAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_purseAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_purseAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_purseAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(186)] 
		[RED("lips_l_funnelAnimOverrideWeight")] 
		public CFloat Lips_l_funnelAnimOverrideWeight
		{
			get
			{
				if (_lips_l_funnelAnimOverrideWeight == null)
				{
					_lips_l_funnelAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_funnelAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_funnelAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_funnelAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_funnelAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(187)] 
		[RED("lips_r_funnelAnimOverrideWeight")] 
		public CFloat Lips_r_funnelAnimOverrideWeight
		{
			get
			{
				if (_lips_r_funnelAnimOverrideWeight == null)
				{
					_lips_r_funnelAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_funnelAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_funnelAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_funnelAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_funnelAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(188)] 
		[RED("lips_tighten_upAnimOverrideWeight")] 
		public CFloat Lips_tighten_upAnimOverrideWeight
		{
			get
			{
				if (_lips_tighten_upAnimOverrideWeight == null)
				{
					_lips_tighten_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_tighten_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_tighten_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_tighten_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_tighten_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(189)] 
		[RED("lips_tighten_dnAnimOverrideWeight")] 
		public CFloat Lips_tighten_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_tighten_dnAnimOverrideWeight == null)
				{
					_lips_tighten_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_tighten_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_tighten_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_tighten_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_tighten_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(190)] 
		[RED("lips_mid_shift_lAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_lAnimOverrideWeight
		{
			get
			{
				if (_lips_mid_shift_lAnimOverrideWeight == null)
				{
					_lips_mid_shift_lAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_lAnimOverrideWeight", cr2w, this);
				}
				return _lips_mid_shift_lAnimOverrideWeight;
			}
			set
			{
				if (_lips_mid_shift_lAnimOverrideWeight == value)
				{
					return;
				}
				_lips_mid_shift_lAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(191)] 
		[RED("lips_mid_shift_rAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_rAnimOverrideWeight
		{
			get
			{
				if (_lips_mid_shift_rAnimOverrideWeight == null)
				{
					_lips_mid_shift_rAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_rAnimOverrideWeight", cr2w, this);
				}
				return _lips_mid_shift_rAnimOverrideWeight;
			}
			set
			{
				if (_lips_mid_shift_rAnimOverrideWeight == value)
				{
					return;
				}
				_lips_mid_shift_rAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(192)] 
		[RED("lips_mid_shift_upAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_upAnimOverrideWeight
		{
			get
			{
				if (_lips_mid_shift_upAnimOverrideWeight == null)
				{
					_lips_mid_shift_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_upAnimOverrideWeight", cr2w, this);
				}
				return _lips_mid_shift_upAnimOverrideWeight;
			}
			set
			{
				if (_lips_mid_shift_upAnimOverrideWeight == value)
				{
					return;
				}
				_lips_mid_shift_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(193)] 
		[RED("lips_mid_shift_dnAnimOverrideWeight")] 
		public CFloat Lips_mid_shift_dnAnimOverrideWeight
		{
			get
			{
				if (_lips_mid_shift_dnAnimOverrideWeight == null)
				{
					_lips_mid_shift_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_dnAnimOverrideWeight", cr2w, this);
				}
				return _lips_mid_shift_dnAnimOverrideWeight;
			}
			set
			{
				if (_lips_mid_shift_dnAnimOverrideWeight == value)
				{
					return;
				}
				_lips_mid_shift_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(194)] 
		[RED("cheek_l_puffAnimOverrideWeight")] 
		public CFloat Cheek_l_puffAnimOverrideWeight
		{
			get
			{
				if (_cheek_l_puffAnimOverrideWeight == null)
				{
					_cheek_l_puffAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "cheek_l_puffAnimOverrideWeight", cr2w, this);
				}
				return _cheek_l_puffAnimOverrideWeight;
			}
			set
			{
				if (_cheek_l_puffAnimOverrideWeight == value)
				{
					return;
				}
				_cheek_l_puffAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(195)] 
		[RED("cheek_r_puffAnimOverrideWeight")] 
		public CFloat Cheek_r_puffAnimOverrideWeight
		{
			get
			{
				if (_cheek_r_puffAnimOverrideWeight == null)
				{
					_cheek_r_puffAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "cheek_r_puffAnimOverrideWeight", cr2w, this);
				}
				return _cheek_r_puffAnimOverrideWeight;
			}
			set
			{
				if (_cheek_r_puffAnimOverrideWeight == value)
				{
					return;
				}
				_cheek_r_puffAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(196)] 
		[RED("jaw_mid_openAnimOverrideWeight")] 
		public CFloat Jaw_mid_openAnimOverrideWeight
		{
			get
			{
				if (_jaw_mid_openAnimOverrideWeight == null)
				{
					_jaw_mid_openAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_openAnimOverrideWeight", cr2w, this);
				}
				return _jaw_mid_openAnimOverrideWeight;
			}
			set
			{
				if (_jaw_mid_openAnimOverrideWeight == value)
				{
					return;
				}
				_jaw_mid_openAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(197)] 
		[RED("jaw_mid_closeAnimOverrideWeight")] 
		public CFloat Jaw_mid_closeAnimOverrideWeight
		{
			get
			{
				if (_jaw_mid_closeAnimOverrideWeight == null)
				{
					_jaw_mid_closeAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_closeAnimOverrideWeight", cr2w, this);
				}
				return _jaw_mid_closeAnimOverrideWeight;
			}
			set
			{
				if (_jaw_mid_closeAnimOverrideWeight == value)
				{
					return;
				}
				_jaw_mid_closeAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(198)] 
		[RED("jaw_mid_shift_lAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_lAnimOverrideWeight
		{
			get
			{
				if (_jaw_mid_shift_lAnimOverrideWeight == null)
				{
					_jaw_mid_shift_lAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_lAnimOverrideWeight", cr2w, this);
				}
				return _jaw_mid_shift_lAnimOverrideWeight;
			}
			set
			{
				if (_jaw_mid_shift_lAnimOverrideWeight == value)
				{
					return;
				}
				_jaw_mid_shift_lAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(199)] 
		[RED("jaw_mid_shift_rAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_rAnimOverrideWeight
		{
			get
			{
				if (_jaw_mid_shift_rAnimOverrideWeight == null)
				{
					_jaw_mid_shift_rAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_rAnimOverrideWeight", cr2w, this);
				}
				return _jaw_mid_shift_rAnimOverrideWeight;
			}
			set
			{
				if (_jaw_mid_shift_rAnimOverrideWeight == value)
				{
					return;
				}
				_jaw_mid_shift_rAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(200)] 
		[RED("jaw_mid_shift_fwdAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_fwdAnimOverrideWeight
		{
			get
			{
				if (_jaw_mid_shift_fwdAnimOverrideWeight == null)
				{
					_jaw_mid_shift_fwdAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_fwdAnimOverrideWeight", cr2w, this);
				}
				return _jaw_mid_shift_fwdAnimOverrideWeight;
			}
			set
			{
				if (_jaw_mid_shift_fwdAnimOverrideWeight == value)
				{
					return;
				}
				_jaw_mid_shift_fwdAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(201)] 
		[RED("jaw_mid_shift_backAnimOverrideWeight")] 
		public CFloat Jaw_mid_shift_backAnimOverrideWeight
		{
			get
			{
				if (_jaw_mid_shift_backAnimOverrideWeight == null)
				{
					_jaw_mid_shift_backAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_backAnimOverrideWeight", cr2w, this);
				}
				return _jaw_mid_shift_backAnimOverrideWeight;
			}
			set
			{
				if (_jaw_mid_shift_backAnimOverrideWeight == value)
				{
					return;
				}
				_jaw_mid_shift_backAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(202)] 
		[RED("jaw_mid_clenchAnimOverrideWeight")] 
		public CFloat Jaw_mid_clenchAnimOverrideWeight
		{
			get
			{
				if (_jaw_mid_clenchAnimOverrideWeight == null)
				{
					_jaw_mid_clenchAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_clenchAnimOverrideWeight", cr2w, this);
				}
				return _jaw_mid_clenchAnimOverrideWeight;
			}
			set
			{
				if (_jaw_mid_clenchAnimOverrideWeight == value)
				{
					return;
				}
				_jaw_mid_clenchAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(203)] 
		[RED("neck_l_stretchAnimOverrideWeight")] 
		public CFloat Neck_l_stretchAnimOverrideWeight
		{
			get
			{
				if (_neck_l_stretchAnimOverrideWeight == null)
				{
					_neck_l_stretchAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_l_stretchAnimOverrideWeight", cr2w, this);
				}
				return _neck_l_stretchAnimOverrideWeight;
			}
			set
			{
				if (_neck_l_stretchAnimOverrideWeight == value)
				{
					return;
				}
				_neck_l_stretchAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(204)] 
		[RED("neck_r_stretchAnimOverrideWeight")] 
		public CFloat Neck_r_stretchAnimOverrideWeight
		{
			get
			{
				if (_neck_r_stretchAnimOverrideWeight == null)
				{
					_neck_r_stretchAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_r_stretchAnimOverrideWeight", cr2w, this);
				}
				return _neck_r_stretchAnimOverrideWeight;
			}
			set
			{
				if (_neck_r_stretchAnimOverrideWeight == value)
				{
					return;
				}
				_neck_r_stretchAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(205)] 
		[RED("neck_tightenAnimOverrideWeight")] 
		public CFloat Neck_tightenAnimOverrideWeight
		{
			get
			{
				if (_neck_tightenAnimOverrideWeight == null)
				{
					_neck_tightenAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_tightenAnimOverrideWeight", cr2w, this);
				}
				return _neck_tightenAnimOverrideWeight;
			}
			set
			{
				if (_neck_tightenAnimOverrideWeight == value)
				{
					return;
				}
				_neck_tightenAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(206)] 
		[RED("neck_l_sternocleidomastoid_flexAnimOverrideWeight")] 
		public CFloat Neck_l_sternocleidomastoid_flexAnimOverrideWeight
		{
			get
			{
				if (_neck_l_sternocleidomastoid_flexAnimOverrideWeight == null)
				{
					_neck_l_sternocleidomastoid_flexAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_l_sternocleidomastoid_flexAnimOverrideWeight", cr2w, this);
				}
				return _neck_l_sternocleidomastoid_flexAnimOverrideWeight;
			}
			set
			{
				if (_neck_l_sternocleidomastoid_flexAnimOverrideWeight == value)
				{
					return;
				}
				_neck_l_sternocleidomastoid_flexAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(207)] 
		[RED("neck_r_sternocleidomastoid_flexAnimOverrideWeight")] 
		public CFloat Neck_r_sternocleidomastoid_flexAnimOverrideWeight
		{
			get
			{
				if (_neck_r_sternocleidomastoid_flexAnimOverrideWeight == null)
				{
					_neck_r_sternocleidomastoid_flexAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_r_sternocleidomastoid_flexAnimOverrideWeight", cr2w, this);
				}
				return _neck_r_sternocleidomastoid_flexAnimOverrideWeight;
			}
			set
			{
				if (_neck_r_sternocleidomastoid_flexAnimOverrideWeight == value)
				{
					return;
				}
				_neck_r_sternocleidomastoid_flexAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(208)] 
		[RED("neck_l_platysma_flexAnimOverrideWeight")] 
		public CFloat Neck_l_platysma_flexAnimOverrideWeight
		{
			get
			{
				if (_neck_l_platysma_flexAnimOverrideWeight == null)
				{
					_neck_l_platysma_flexAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_l_platysma_flexAnimOverrideWeight", cr2w, this);
				}
				return _neck_l_platysma_flexAnimOverrideWeight;
			}
			set
			{
				if (_neck_l_platysma_flexAnimOverrideWeight == value)
				{
					return;
				}
				_neck_l_platysma_flexAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(209)] 
		[RED("neck_r_platysma_flexAnimOverrideWeight")] 
		public CFloat Neck_r_platysma_flexAnimOverrideWeight
		{
			get
			{
				if (_neck_r_platysma_flexAnimOverrideWeight == null)
				{
					_neck_r_platysma_flexAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_r_platysma_flexAnimOverrideWeight", cr2w, this);
				}
				return _neck_r_platysma_flexAnimOverrideWeight;
			}
			set
			{
				if (_neck_r_platysma_flexAnimOverrideWeight == value)
				{
					return;
				}
				_neck_r_platysma_flexAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(210)] 
		[RED("neck_throat_adamsApple_upAnimOverrideWeight")] 
		public CFloat Neck_throat_adamsApple_upAnimOverrideWeight
		{
			get
			{
				if (_neck_throat_adamsApple_upAnimOverrideWeight == null)
				{
					_neck_throat_adamsApple_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_adamsApple_upAnimOverrideWeight", cr2w, this);
				}
				return _neck_throat_adamsApple_upAnimOverrideWeight;
			}
			set
			{
				if (_neck_throat_adamsApple_upAnimOverrideWeight == value)
				{
					return;
				}
				_neck_throat_adamsApple_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(211)] 
		[RED("neck_throat_adamsApple_dnAnimOverrideWeight")] 
		public CFloat Neck_throat_adamsApple_dnAnimOverrideWeight
		{
			get
			{
				if (_neck_throat_adamsApple_dnAnimOverrideWeight == null)
				{
					_neck_throat_adamsApple_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_adamsApple_dnAnimOverrideWeight", cr2w, this);
				}
				return _neck_throat_adamsApple_dnAnimOverrideWeight;
			}
			set
			{
				if (_neck_throat_adamsApple_dnAnimOverrideWeight == value)
				{
					return;
				}
				_neck_throat_adamsApple_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(212)] 
		[RED("neck_throat_compressAnimOverrideWeight")] 
		public CFloat Neck_throat_compressAnimOverrideWeight
		{
			get
			{
				if (_neck_throat_compressAnimOverrideWeight == null)
				{
					_neck_throat_compressAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_compressAnimOverrideWeight", cr2w, this);
				}
				return _neck_throat_compressAnimOverrideWeight;
			}
			set
			{
				if (_neck_throat_compressAnimOverrideWeight == value)
				{
					return;
				}
				_neck_throat_compressAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(213)] 
		[RED("neck_throat_openAnimOverrideWeight")] 
		public CFloat Neck_throat_openAnimOverrideWeight
		{
			get
			{
				if (_neck_throat_openAnimOverrideWeight == null)
				{
					_neck_throat_openAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_openAnimOverrideWeight", cr2w, this);
				}
				return _neck_throat_openAnimOverrideWeight;
			}
			set
			{
				if (_neck_throat_openAnimOverrideWeight == value)
				{
					return;
				}
				_neck_throat_openAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(214)] 
		[RED("lips_corner_stickyAnimOverrideWeight")] 
		public CFloat Lips_corner_stickyAnimOverrideWeight
		{
			get
			{
				if (_lips_corner_stickyAnimOverrideWeight == null)
				{
					_lips_corner_stickyAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_corner_stickyAnimOverrideWeight", cr2w, this);
				}
				return _lips_corner_stickyAnimOverrideWeight;
			}
			set
			{
				if (_lips_corner_stickyAnimOverrideWeight == value)
				{
					return;
				}
				_lips_corner_stickyAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(215)] 
		[RED("lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_up_in_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(216)] 
		[RED("lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_dn_in_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(217)] 
		[RED("lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_up_out_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(218)] 
		[RED("lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_l_corner_dn_out_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(219)] 
		[RED("lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_up_in_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(220)] 
		[RED("lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_up_out_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(221)] 
		[RED("lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_dn_in_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(222)] 
		[RED("lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight")] 
		public CFloat Lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight
		{
			get
			{
				if (_lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight == null)
				{
					_lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight", cr2w, this);
				}
				return _lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight;
			}
			set
			{
				if (_lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight == value)
				{
					return;
				}
				_lips_r_corner_dn_out_sticky_cutSceneAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(223)] 
		[RED("tongue_mid_base_lAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_lAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_base_lAnimOverrideWeight == null)
				{
					_tongue_mid_base_lAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_lAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_base_lAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_base_lAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_base_lAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(224)] 
		[RED("tongue_mid_base_rAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_rAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_base_rAnimOverrideWeight == null)
				{
					_tongue_mid_base_rAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_rAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_base_rAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_base_rAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_base_rAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(225)] 
		[RED("tongue_mid_base_dnAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_dnAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_base_dnAnimOverrideWeight == null)
				{
					_tongue_mid_base_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_dnAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_base_dnAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_base_dnAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_base_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(226)] 
		[RED("tongue_mid_base_upAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_upAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_base_upAnimOverrideWeight == null)
				{
					_tongue_mid_base_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_upAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_base_upAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_base_upAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_base_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(227)] 
		[RED("tongue_mid_base_fwdAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_fwdAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_base_fwdAnimOverrideWeight == null)
				{
					_tongue_mid_base_fwdAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_fwdAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_base_fwdAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_base_fwdAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_base_fwdAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(228)] 
		[RED("tongue_mid_base_frontAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_frontAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_base_frontAnimOverrideWeight == null)
				{
					_tongue_mid_base_frontAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_frontAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_base_frontAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_base_frontAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_base_frontAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(229)] 
		[RED("tongue_mid_base_backAnimOverrideWeight")] 
		public CFloat Tongue_mid_base_backAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_base_backAnimOverrideWeight == null)
				{
					_tongue_mid_base_backAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_backAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_base_backAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_base_backAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_base_backAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(230)] 
		[RED("tongue_mid_fwdAnimOverrideWeight")] 
		public CFloat Tongue_mid_fwdAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_fwdAnimOverrideWeight == null)
				{
					_tongue_mid_fwdAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_fwdAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_fwdAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_fwdAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_fwdAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(231)] 
		[RED("tongue_mid_liftAnimOverrideWeight")] 
		public CFloat Tongue_mid_liftAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_liftAnimOverrideWeight == null)
				{
					_tongue_mid_liftAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_liftAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_liftAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_liftAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_liftAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(232)] 
		[RED("tongue_mid_tip_lAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_lAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_tip_lAnimOverrideWeight == null)
				{
					_tongue_mid_tip_lAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_lAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_tip_lAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_tip_lAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_tip_lAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(233)] 
		[RED("tongue_mid_tip_rAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_rAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_tip_rAnimOverrideWeight == null)
				{
					_tongue_mid_tip_rAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_rAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_tip_rAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_tip_rAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_tip_rAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(234)] 
		[RED("tongue_mid_tip_dnAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_dnAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_tip_dnAnimOverrideWeight == null)
				{
					_tongue_mid_tip_dnAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_dnAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_tip_dnAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_tip_dnAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_tip_dnAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(235)] 
		[RED("tongue_mid_tip_upAnimOverrideWeight")] 
		public CFloat Tongue_mid_tip_upAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_tip_upAnimOverrideWeight == null)
				{
					_tongue_mid_tip_upAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_upAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_tip_upAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_tip_upAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_tip_upAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(236)] 
		[RED("tongue_mid_twist_lAnimOverrideWeight")] 
		public CFloat Tongue_mid_twist_lAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_twist_lAnimOverrideWeight == null)
				{
					_tongue_mid_twist_lAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_twist_lAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_twist_lAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_twist_lAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_twist_lAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(237)] 
		[RED("tongue_mid_twist_rAnimOverrideWeight")] 
		public CFloat Tongue_mid_twist_rAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_twist_rAnimOverrideWeight == null)
				{
					_tongue_mid_twist_rAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_twist_rAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_twist_rAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_twist_rAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_twist_rAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(238)] 
		[RED("tongue_mid_thickAnimOverrideWeight")] 
		public CFloat Tongue_mid_thickAnimOverrideWeight
		{
			get
			{
				if (_tongue_mid_thickAnimOverrideWeight == null)
				{
					_tongue_mid_thickAnimOverrideWeight = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_thickAnimOverrideWeight", cr2w, this);
				}
				return _tongue_mid_thickAnimOverrideWeight;
			}
			set
			{
				if (_tongue_mid_thickAnimOverrideWeight == value)
				{
					return;
				}
				_tongue_mid_thickAnimOverrideWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(239)] 
		[RED("eye_l_blinkLipsyncPoseOutput")] 
		public CFloat Eye_l_blinkLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_blinkLipsyncPoseOutput == null)
				{
					_eye_l_blinkLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_blinkLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_blinkLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_blinkLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_blinkLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(240)] 
		[RED("eye_r_blinkLipsyncPoseOutput")] 
		public CFloat Eye_r_blinkLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_blinkLipsyncPoseOutput == null)
				{
					_eye_r_blinkLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_blinkLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_blinkLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_blinkLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_blinkLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(241)] 
		[RED("eye_l_widenLipsyncPoseOutput")] 
		public CFloat Eye_l_widenLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_widenLipsyncPoseOutput == null)
				{
					_eye_l_widenLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_widenLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_widenLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_widenLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_widenLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(242)] 
		[RED("eye_r_widenLipsyncPoseOutput")] 
		public CFloat Eye_r_widenLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_widenLipsyncPoseOutput == null)
				{
					_eye_r_widenLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_widenLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_widenLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_widenLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_widenLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(243)] 
		[RED("eye_l_dir_upLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_upLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_dir_upLipsyncPoseOutput == null)
				{
					_eye_l_dir_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_upLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_dir_upLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_dir_upLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_dir_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(244)] 
		[RED("eye_l_dir_dnLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_dnLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_dir_dnLipsyncPoseOutput == null)
				{
					_eye_l_dir_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_dnLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_dir_dnLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_dir_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_dir_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(245)] 
		[RED("eye_l_dir_inLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_inLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_dir_inLipsyncPoseOutput == null)
				{
					_eye_l_dir_inLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_inLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_dir_inLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_dir_inLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_dir_inLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(246)] 
		[RED("eye_l_dir_outLipsyncPoseOutput")] 
		public CFloat Eye_l_dir_outLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_dir_outLipsyncPoseOutput == null)
				{
					_eye_l_dir_outLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_dir_outLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_dir_outLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_dir_outLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_dir_outLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(247)] 
		[RED("eye_r_dir_upLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_upLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_dir_upLipsyncPoseOutput == null)
				{
					_eye_r_dir_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_upLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_dir_upLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_dir_upLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_dir_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(248)] 
		[RED("eye_r_dir_dnLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_dnLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_dir_dnLipsyncPoseOutput == null)
				{
					_eye_r_dir_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_dnLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_dir_dnLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_dir_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_dir_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(249)] 
		[RED("eye_r_dir_inLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_inLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_dir_inLipsyncPoseOutput == null)
				{
					_eye_r_dir_inLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_inLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_dir_inLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_dir_inLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_dir_inLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(250)] 
		[RED("eye_r_dir_outLipsyncPoseOutput")] 
		public CFloat Eye_r_dir_outLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_dir_outLipsyncPoseOutput == null)
				{
					_eye_r_dir_outLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_dir_outLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_dir_outLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_dir_outLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_dir_outLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(251)] 
		[RED("eye_l_pupil_narrowLipsyncPoseOutput")] 
		public CFloat Eye_l_pupil_narrowLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_pupil_narrowLipsyncPoseOutput == null)
				{
					_eye_l_pupil_narrowLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_pupil_narrowLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_pupil_narrowLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_pupil_narrowLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_pupil_narrowLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(252)] 
		[RED("eye_r_pupil_narrowLipsyncPoseOutput")] 
		public CFloat Eye_r_pupil_narrowLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_pupil_narrowLipsyncPoseOutput == null)
				{
					_eye_r_pupil_narrowLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_pupil_narrowLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_pupil_narrowLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_pupil_narrowLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_pupil_narrowLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(253)] 
		[RED("eye_l_pupil_wideLipsyncPoseOutput")] 
		public CFloat Eye_l_pupil_wideLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_pupil_wideLipsyncPoseOutput == null)
				{
					_eye_l_pupil_wideLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_pupil_wideLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_pupil_wideLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_pupil_wideLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_pupil_wideLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(254)] 
		[RED("eye_r_pupil_wideLipsyncPoseOutput")] 
		public CFloat Eye_r_pupil_wideLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_pupil_wideLipsyncPoseOutput == null)
				{
					_eye_r_pupil_wideLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_pupil_wideLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_pupil_wideLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_pupil_wideLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_pupil_wideLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(255)] 
		[RED("eye_l_brows_raise_inLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_raise_inLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_brows_raise_inLipsyncPoseOutput == null)
				{
					_eye_l_brows_raise_inLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_raise_inLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_brows_raise_inLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_brows_raise_inLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_brows_raise_inLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(256)] 
		[RED("eye_r_brows_raise_inLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_raise_inLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_brows_raise_inLipsyncPoseOutput == null)
				{
					_eye_r_brows_raise_inLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_raise_inLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_brows_raise_inLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_brows_raise_inLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_brows_raise_inLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(257)] 
		[RED("eye_l_brows_raise_outLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_raise_outLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_brows_raise_outLipsyncPoseOutput == null)
				{
					_eye_l_brows_raise_outLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_raise_outLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_brows_raise_outLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_brows_raise_outLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_brows_raise_outLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(258)] 
		[RED("eye_r_brows_raise_outLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_raise_outLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_brows_raise_outLipsyncPoseOutput == null)
				{
					_eye_r_brows_raise_outLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_raise_outLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_brows_raise_outLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_brows_raise_outLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_brows_raise_outLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(259)] 
		[RED("eye_l_brows_lowerLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_lowerLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_brows_lowerLipsyncPoseOutput == null)
				{
					_eye_l_brows_lowerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_lowerLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_brows_lowerLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_brows_lowerLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_brows_lowerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(260)] 
		[RED("eye_r_brows_lowerLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_lowerLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_brows_lowerLipsyncPoseOutput == null)
				{
					_eye_r_brows_lowerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_lowerLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_brows_lowerLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_brows_lowerLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_brows_lowerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(261)] 
		[RED("eye_l_brows_lateralLipsyncPoseOutput")] 
		public CFloat Eye_l_brows_lateralLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_brows_lateralLipsyncPoseOutput == null)
				{
					_eye_l_brows_lateralLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_lateralLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_brows_lateralLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_brows_lateralLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_brows_lateralLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(262)] 
		[RED("eye_r_brows_lateralLipsyncPoseOutput")] 
		public CFloat Eye_r_brows_lateralLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_brows_lateralLipsyncPoseOutput == null)
				{
					_eye_r_brows_lateralLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_lateralLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_brows_lateralLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_brows_lateralLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_brows_lateralLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(263)] 
		[RED("eye_l_oculi_squint_innerLipsyncPoseOutput")] 
		public CFloat Eye_l_oculi_squint_innerLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_oculi_squint_innerLipsyncPoseOutput == null)
				{
					_eye_l_oculi_squint_innerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_innerLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_oculi_squint_innerLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_oculi_squint_innerLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_oculi_squint_innerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(264)] 
		[RED("eye_r_oculi_squint_innerLipsyncPoseOutput")] 
		public CFloat Eye_r_oculi_squint_innerLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_oculi_squint_innerLipsyncPoseOutput == null)
				{
					_eye_r_oculi_squint_innerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_innerLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_oculi_squint_innerLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_oculi_squint_innerLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_oculi_squint_innerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(265)] 
		[RED("eye_l_oculi_squint_outer_lowerLipsyncPoseOutput")] 
		public CFloat Eye_l_oculi_squint_outer_lowerLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_oculi_squint_outer_lowerLipsyncPoseOutput == null)
				{
					_eye_l_oculi_squint_outer_lowerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_outer_lowerLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_oculi_squint_outer_lowerLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_oculi_squint_outer_lowerLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_oculi_squint_outer_lowerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(266)] 
		[RED("eye_r_oculi_squint_outer_lowerLipsyncPoseOutput")] 
		public CFloat Eye_r_oculi_squint_outer_lowerLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_oculi_squint_outer_lowerLipsyncPoseOutput == null)
				{
					_eye_r_oculi_squint_outer_lowerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_outer_lowerLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_oculi_squint_outer_lowerLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_oculi_squint_outer_lowerLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_oculi_squint_outer_lowerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(267)] 
		[RED("eye_l_oculi_squint_outer_upperLipsyncPoseOutput")] 
		public CFloat Eye_l_oculi_squint_outer_upperLipsyncPoseOutput
		{
			get
			{
				if (_eye_l_oculi_squint_outer_upperLipsyncPoseOutput == null)
				{
					_eye_l_oculi_squint_outer_upperLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_outer_upperLipsyncPoseOutput", cr2w, this);
				}
				return _eye_l_oculi_squint_outer_upperLipsyncPoseOutput;
			}
			set
			{
				if (_eye_l_oculi_squint_outer_upperLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_l_oculi_squint_outer_upperLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(268)] 
		[RED("eye_r_oculi_squint_outer_upperLipsyncPoseOutput")] 
		public CFloat Eye_r_oculi_squint_outer_upperLipsyncPoseOutput
		{
			get
			{
				if (_eye_r_oculi_squint_outer_upperLipsyncPoseOutput == null)
				{
					_eye_r_oculi_squint_outer_upperLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_outer_upperLipsyncPoseOutput", cr2w, this);
				}
				return _eye_r_oculi_squint_outer_upperLipsyncPoseOutput;
			}
			set
			{
				if (_eye_r_oculi_squint_outer_upperLipsyncPoseOutput == value)
				{
					return;
				}
				_eye_r_oculi_squint_outer_upperLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(269)] 
		[RED("nose_l_compressLipsyncPoseOutput")] 
		public CFloat Nose_l_compressLipsyncPoseOutput
		{
			get
			{
				if (_nose_l_compressLipsyncPoseOutput == null)
				{
					_nose_l_compressLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_l_compressLipsyncPoseOutput", cr2w, this);
				}
				return _nose_l_compressLipsyncPoseOutput;
			}
			set
			{
				if (_nose_l_compressLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_l_compressLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(270)] 
		[RED("nose_r_compressLipsyncPoseOutput")] 
		public CFloat Nose_r_compressLipsyncPoseOutput
		{
			get
			{
				if (_nose_r_compressLipsyncPoseOutput == null)
				{
					_nose_r_compressLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_r_compressLipsyncPoseOutput", cr2w, this);
				}
				return _nose_r_compressLipsyncPoseOutput;
			}
			set
			{
				if (_nose_r_compressLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_r_compressLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(271)] 
		[RED("nose_l_breathe_inLipsyncPoseOutput")] 
		public CFloat Nose_l_breathe_inLipsyncPoseOutput
		{
			get
			{
				if (_nose_l_breathe_inLipsyncPoseOutput == null)
				{
					_nose_l_breathe_inLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_l_breathe_inLipsyncPoseOutput", cr2w, this);
				}
				return _nose_l_breathe_inLipsyncPoseOutput;
			}
			set
			{
				if (_nose_l_breathe_inLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_l_breathe_inLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(272)] 
		[RED("nose_r_breathe_inLipsyncPoseOutput")] 
		public CFloat Nose_r_breathe_inLipsyncPoseOutput
		{
			get
			{
				if (_nose_r_breathe_inLipsyncPoseOutput == null)
				{
					_nose_r_breathe_inLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_r_breathe_inLipsyncPoseOutput", cr2w, this);
				}
				return _nose_r_breathe_inLipsyncPoseOutput;
			}
			set
			{
				if (_nose_r_breathe_inLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_r_breathe_inLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(273)] 
		[RED("nose_l_breathe_outLipsyncPoseOutput")] 
		public CFloat Nose_l_breathe_outLipsyncPoseOutput
		{
			get
			{
				if (_nose_l_breathe_outLipsyncPoseOutput == null)
				{
					_nose_l_breathe_outLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_l_breathe_outLipsyncPoseOutput", cr2w, this);
				}
				return _nose_l_breathe_outLipsyncPoseOutput;
			}
			set
			{
				if (_nose_l_breathe_outLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_l_breathe_outLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(274)] 
		[RED("nose_r_breathe_outLipsyncPoseOutput")] 
		public CFloat Nose_r_breathe_outLipsyncPoseOutput
		{
			get
			{
				if (_nose_r_breathe_outLipsyncPoseOutput == null)
				{
					_nose_r_breathe_outLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_r_breathe_outLipsyncPoseOutput", cr2w, this);
				}
				return _nose_r_breathe_outLipsyncPoseOutput;
			}
			set
			{
				if (_nose_r_breathe_outLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_r_breathe_outLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(275)] 
		[RED("nose_l_snearLipsyncPoseOutput")] 
		public CFloat Nose_l_snearLipsyncPoseOutput
		{
			get
			{
				if (_nose_l_snearLipsyncPoseOutput == null)
				{
					_nose_l_snearLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_l_snearLipsyncPoseOutput", cr2w, this);
				}
				return _nose_l_snearLipsyncPoseOutput;
			}
			set
			{
				if (_nose_l_snearLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_l_snearLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(276)] 
		[RED("nose_r_snearLipsyncPoseOutput")] 
		public CFloat Nose_r_snearLipsyncPoseOutput
		{
			get
			{
				if (_nose_r_snearLipsyncPoseOutput == null)
				{
					_nose_r_snearLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "nose_r_snearLipsyncPoseOutput", cr2w, this);
				}
				return _nose_r_snearLipsyncPoseOutput;
			}
			set
			{
				if (_nose_r_snearLipsyncPoseOutput == value)
				{
					return;
				}
				_nose_r_snearLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(277)] 
		[RED("lips_l_nasolabialDeepenerLipsyncPoseOutput")] 
		public CFloat Lips_l_nasolabialDeepenerLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_nasolabialDeepenerLipsyncPoseOutput == null)
				{
					_lips_l_nasolabialDeepenerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_nasolabialDeepenerLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_nasolabialDeepenerLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_nasolabialDeepenerLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_nasolabialDeepenerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(278)] 
		[RED("lips_r_nasolabialDeepenerLipsyncPoseOutput")] 
		public CFloat Lips_r_nasolabialDeepenerLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_nasolabialDeepenerLipsyncPoseOutput == null)
				{
					_lips_r_nasolabialDeepenerLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_nasolabialDeepenerLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_nasolabialDeepenerLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_nasolabialDeepenerLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_nasolabialDeepenerLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(279)] 
		[RED("lips_l_upper_raiseLipsyncPoseOutput")] 
		public CFloat Lips_l_upper_raiseLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_upper_raiseLipsyncPoseOutput == null)
				{
					_lips_l_upper_raiseLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_upper_raiseLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_upper_raiseLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_upper_raiseLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_upper_raiseLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(280)] 
		[RED("lips_r_upper_raiseLipsyncPoseOutput")] 
		public CFloat Lips_r_upper_raiseLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_upper_raiseLipsyncPoseOutput == null)
				{
					_lips_r_upper_raiseLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_upper_raiseLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_upper_raiseLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_upper_raiseLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_upper_raiseLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(281)] 
		[RED("lips_l_pullLipsyncPoseOutput")] 
		public CFloat Lips_l_pullLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_pullLipsyncPoseOutput == null)
				{
					_lips_l_pullLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_pullLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_pullLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_pullLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_pullLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(282)] 
		[RED("lips_r_pullLipsyncPoseOutput")] 
		public CFloat Lips_r_pullLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_pullLipsyncPoseOutput == null)
				{
					_lips_r_pullLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_pullLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_pullLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_pullLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_pullLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(283)] 
		[RED("lips_l_corner_upLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_upLipsyncPoseOutput == null)
				{
					_lips_l_corner_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(284)] 
		[RED("lips_r_corner_upLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_upLipsyncPoseOutput == null)
				{
					_lips_r_corner_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(285)] 
		[RED("lips_l_corner_wideLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_wideLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_wideLipsyncPoseOutput == null)
				{
					_lips_l_corner_wideLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_wideLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_wideLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_wideLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_wideLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(286)] 
		[RED("lips_r_corner_wideLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_wideLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_wideLipsyncPoseOutput == null)
				{
					_lips_r_corner_wideLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_wideLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_wideLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_wideLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_wideLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(287)] 
		[RED("lips_l_corner_stretchLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_stretchLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_stretchLipsyncPoseOutput == null)
				{
					_lips_l_corner_stretchLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_stretchLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_stretchLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_stretchLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_stretchLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(288)] 
		[RED("lips_r_corner_stretchLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_stretchLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_stretchLipsyncPoseOutput == null)
				{
					_lips_r_corner_stretchLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_stretchLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_stretchLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_stretchLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_stretchLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(289)] 
		[RED("lips_l_stretchLipsyncPoseOutput")] 
		public CFloat Lips_l_stretchLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_stretchLipsyncPoseOutput == null)
				{
					_lips_l_stretchLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_stretchLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_stretchLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_stretchLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_stretchLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(290)] 
		[RED("lips_r_stretchLipsyncPoseOutput")] 
		public CFloat Lips_r_stretchLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_stretchLipsyncPoseOutput == null)
				{
					_lips_r_stretchLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_stretchLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_stretchLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_stretchLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_stretchLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(291)] 
		[RED("lips_l_corner_sharp_upLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_sharp_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_sharp_upLipsyncPoseOutput == null)
				{
					_lips_l_corner_sharp_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_sharp_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_sharp_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_sharp_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_sharp_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(292)] 
		[RED("lips_r_corner_sharp_upLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_sharp_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_sharp_upLipsyncPoseOutput == null)
				{
					_lips_r_corner_sharp_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_sharp_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_sharp_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_sharp_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_sharp_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(293)] 
		[RED("lips_suck_upLipsyncPoseOutput")] 
		public CFloat Lips_suck_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_suck_upLipsyncPoseOutput == null)
				{
					_lips_suck_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_suck_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_suck_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_suck_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_suck_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(294)] 
		[RED("lips_suck_dnLipsyncPoseOutput")] 
		public CFloat Lips_suck_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_suck_dnLipsyncPoseOutput == null)
				{
					_lips_suck_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_suck_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_suck_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_suck_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_suck_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(295)] 
		[RED("lips_puff_upLipsyncPoseOutput")] 
		public CFloat Lips_puff_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_puff_upLipsyncPoseOutput == null)
				{
					_lips_puff_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_puff_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_puff_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_puff_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_puff_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(296)] 
		[RED("lips_puff_dnLipsyncPoseOutput")] 
		public CFloat Lips_puff_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_puff_dnLipsyncPoseOutput == null)
				{
					_lips_puff_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_puff_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_puff_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_puff_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_puff_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(297)] 
		[RED("lips_apart_upLipsyncPoseOutput")] 
		public CFloat Lips_apart_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_apart_upLipsyncPoseOutput == null)
				{
					_lips_apart_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_apart_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_apart_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_apart_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_apart_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(298)] 
		[RED("lips_apart_dnLipsyncPoseOutput")] 
		public CFloat Lips_apart_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_apart_dnLipsyncPoseOutput == null)
				{
					_lips_apart_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_apart_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_apart_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_apart_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_apart_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(299)] 
		[RED("lips_l_lower_raiseLipsyncPoseOutput")] 
		public CFloat Lips_l_lower_raiseLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_lower_raiseLipsyncPoseOutput == null)
				{
					_lips_l_lower_raiseLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_lower_raiseLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_lower_raiseLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_lower_raiseLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_lower_raiseLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(300)] 
		[RED("lips_r_lower_raiseLipsyncPoseOutput")] 
		public CFloat Lips_r_lower_raiseLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_lower_raiseLipsyncPoseOutput == null)
				{
					_lips_r_lower_raiseLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_lower_raiseLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_lower_raiseLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_lower_raiseLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_lower_raiseLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(301)] 
		[RED("lips_l_corner_dnLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_dnLipsyncPoseOutput == null)
				{
					_lips_l_corner_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(302)] 
		[RED("lips_r_corner_dnLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_dnLipsyncPoseOutput == null)
				{
					_lips_r_corner_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(303)] 
		[RED("lips_chin_raiseLipsyncPoseOutput")] 
		public CFloat Lips_chin_raiseLipsyncPoseOutput
		{
			get
			{
				if (_lips_chin_raiseLipsyncPoseOutput == null)
				{
					_lips_chin_raiseLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_chin_raiseLipsyncPoseOutput", cr2w, this);
				}
				return _lips_chin_raiseLipsyncPoseOutput;
			}
			set
			{
				if (_lips_chin_raiseLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_chin_raiseLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(304)] 
		[RED("lips_together_upLipsyncPoseOutput")] 
		public CFloat Lips_together_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_together_upLipsyncPoseOutput == null)
				{
					_lips_together_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_together_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_together_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_together_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_together_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(305)] 
		[RED("lips_together_dnLipsyncPoseOutput")] 
		public CFloat Lips_together_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_together_dnLipsyncPoseOutput == null)
				{
					_lips_together_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_together_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_together_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_together_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_together_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(306)] 
		[RED("lips_l_purseLipsyncPoseOutput")] 
		public CFloat Lips_l_purseLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_purseLipsyncPoseOutput == null)
				{
					_lips_l_purseLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_purseLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_purseLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_purseLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_purseLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(307)] 
		[RED("lips_r_purseLipsyncPoseOutput")] 
		public CFloat Lips_r_purseLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_purseLipsyncPoseOutput == null)
				{
					_lips_r_purseLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_purseLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_purseLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_purseLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_purseLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(308)] 
		[RED("lips_l_funnelLipsyncPoseOutput")] 
		public CFloat Lips_l_funnelLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_funnelLipsyncPoseOutput == null)
				{
					_lips_l_funnelLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_funnelLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_funnelLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_funnelLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_funnelLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(309)] 
		[RED("lips_r_funnelLipsyncPoseOutput")] 
		public CFloat Lips_r_funnelLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_funnelLipsyncPoseOutput == null)
				{
					_lips_r_funnelLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_funnelLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_funnelLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_funnelLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_funnelLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(310)] 
		[RED("lips_tighten_upLipsyncPoseOutput")] 
		public CFloat Lips_tighten_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_tighten_upLipsyncPoseOutput == null)
				{
					_lips_tighten_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_tighten_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_tighten_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_tighten_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_tighten_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(311)] 
		[RED("lips_tighten_dnLipsyncPoseOutput")] 
		public CFloat Lips_tighten_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_tighten_dnLipsyncPoseOutput == null)
				{
					_lips_tighten_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_tighten_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_tighten_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_tighten_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_tighten_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(312)] 
		[RED("lips_mid_shift_lLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_lLipsyncPoseOutput
		{
			get
			{
				if (_lips_mid_shift_lLipsyncPoseOutput == null)
				{
					_lips_mid_shift_lLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_lLipsyncPoseOutput", cr2w, this);
				}
				return _lips_mid_shift_lLipsyncPoseOutput;
			}
			set
			{
				if (_lips_mid_shift_lLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_mid_shift_lLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(313)] 
		[RED("lips_mid_shift_rLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_rLipsyncPoseOutput
		{
			get
			{
				if (_lips_mid_shift_rLipsyncPoseOutput == null)
				{
					_lips_mid_shift_rLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_rLipsyncPoseOutput", cr2w, this);
				}
				return _lips_mid_shift_rLipsyncPoseOutput;
			}
			set
			{
				if (_lips_mid_shift_rLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_mid_shift_rLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(314)] 
		[RED("lips_mid_shift_upLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_upLipsyncPoseOutput
		{
			get
			{
				if (_lips_mid_shift_upLipsyncPoseOutput == null)
				{
					_lips_mid_shift_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_upLipsyncPoseOutput", cr2w, this);
				}
				return _lips_mid_shift_upLipsyncPoseOutput;
			}
			set
			{
				if (_lips_mid_shift_upLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_mid_shift_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(315)] 
		[RED("lips_mid_shift_dnLipsyncPoseOutput")] 
		public CFloat Lips_mid_shift_dnLipsyncPoseOutput
		{
			get
			{
				if (_lips_mid_shift_dnLipsyncPoseOutput == null)
				{
					_lips_mid_shift_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_mid_shift_dnLipsyncPoseOutput", cr2w, this);
				}
				return _lips_mid_shift_dnLipsyncPoseOutput;
			}
			set
			{
				if (_lips_mid_shift_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_mid_shift_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(316)] 
		[RED("lips_corner_stickyLipsyncPoseOutput")] 
		public CFloat Lips_corner_stickyLipsyncPoseOutput
		{
			get
			{
				if (_lips_corner_stickyLipsyncPoseOutput == null)
				{
					_lips_corner_stickyLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_corner_stickyLipsyncPoseOutput", cr2w, this);
				}
				return _lips_corner_stickyLipsyncPoseOutput;
			}
			set
			{
				if (_lips_corner_stickyLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_corner_stickyLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(317)] 
		[RED("lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_up_in_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(318)] 
		[RED("lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_dn_in_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(319)] 
		[RED("lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_up_out_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(320)] 
		[RED("lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_l_corner_dn_out_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(321)] 
		[RED("lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_up_in_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(322)] 
		[RED("lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_up_out_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(323)] 
		[RED("lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_dn_in_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(324)] 
		[RED("lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput")] 
		public CFloat Lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput
		{
			get
			{
				if (_lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput == null)
				{
					_lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput", cr2w, this);
				}
				return _lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput;
			}
			set
			{
				if (_lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput == value)
				{
					return;
				}
				_lips_r_corner_dn_out_sticky_cutSceneLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(325)] 
		[RED("cheek_l_suckLipsyncPoseOutput")] 
		public CFloat Cheek_l_suckLipsyncPoseOutput
		{
			get
			{
				if (_cheek_l_suckLipsyncPoseOutput == null)
				{
					_cheek_l_suckLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "cheek_l_suckLipsyncPoseOutput", cr2w, this);
				}
				return _cheek_l_suckLipsyncPoseOutput;
			}
			set
			{
				if (_cheek_l_suckLipsyncPoseOutput == value)
				{
					return;
				}
				_cheek_l_suckLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(326)] 
		[RED("cheek_r_suckLipsyncPoseOutput")] 
		public CFloat Cheek_r_suckLipsyncPoseOutput
		{
			get
			{
				if (_cheek_r_suckLipsyncPoseOutput == null)
				{
					_cheek_r_suckLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "cheek_r_suckLipsyncPoseOutput", cr2w, this);
				}
				return _cheek_r_suckLipsyncPoseOutput;
			}
			set
			{
				if (_cheek_r_suckLipsyncPoseOutput == value)
				{
					return;
				}
				_cheek_r_suckLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(327)] 
		[RED("cheek_l_puffLipsyncPoseOutput")] 
		public CFloat Cheek_l_puffLipsyncPoseOutput
		{
			get
			{
				if (_cheek_l_puffLipsyncPoseOutput == null)
				{
					_cheek_l_puffLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "cheek_l_puffLipsyncPoseOutput", cr2w, this);
				}
				return _cheek_l_puffLipsyncPoseOutput;
			}
			set
			{
				if (_cheek_l_puffLipsyncPoseOutput == value)
				{
					return;
				}
				_cheek_l_puffLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(328)] 
		[RED("cheek_r_puffLipsyncPoseOutput")] 
		public CFloat Cheek_r_puffLipsyncPoseOutput
		{
			get
			{
				if (_cheek_r_puffLipsyncPoseOutput == null)
				{
					_cheek_r_puffLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "cheek_r_puffLipsyncPoseOutput", cr2w, this);
				}
				return _cheek_r_puffLipsyncPoseOutput;
			}
			set
			{
				if (_cheek_r_puffLipsyncPoseOutput == value)
				{
					return;
				}
				_cheek_r_puffLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(329)] 
		[RED("jaw_mid_openLipsyncPoseOutput")] 
		public CFloat Jaw_mid_openLipsyncPoseOutput
		{
			get
			{
				if (_jaw_mid_openLipsyncPoseOutput == null)
				{
					_jaw_mid_openLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_openLipsyncPoseOutput", cr2w, this);
				}
				return _jaw_mid_openLipsyncPoseOutput;
			}
			set
			{
				if (_jaw_mid_openLipsyncPoseOutput == value)
				{
					return;
				}
				_jaw_mid_openLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(330)] 
		[RED("jaw_mid_closeLipsyncPoseOutput")] 
		public CFloat Jaw_mid_closeLipsyncPoseOutput
		{
			get
			{
				if (_jaw_mid_closeLipsyncPoseOutput == null)
				{
					_jaw_mid_closeLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_closeLipsyncPoseOutput", cr2w, this);
				}
				return _jaw_mid_closeLipsyncPoseOutput;
			}
			set
			{
				if (_jaw_mid_closeLipsyncPoseOutput == value)
				{
					return;
				}
				_jaw_mid_closeLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(331)] 
		[RED("jaw_mid_shift_lLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_lLipsyncPoseOutput
		{
			get
			{
				if (_jaw_mid_shift_lLipsyncPoseOutput == null)
				{
					_jaw_mid_shift_lLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_lLipsyncPoseOutput", cr2w, this);
				}
				return _jaw_mid_shift_lLipsyncPoseOutput;
			}
			set
			{
				if (_jaw_mid_shift_lLipsyncPoseOutput == value)
				{
					return;
				}
				_jaw_mid_shift_lLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(332)] 
		[RED("jaw_mid_shift_rLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_rLipsyncPoseOutput
		{
			get
			{
				if (_jaw_mid_shift_rLipsyncPoseOutput == null)
				{
					_jaw_mid_shift_rLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_rLipsyncPoseOutput", cr2w, this);
				}
				return _jaw_mid_shift_rLipsyncPoseOutput;
			}
			set
			{
				if (_jaw_mid_shift_rLipsyncPoseOutput == value)
				{
					return;
				}
				_jaw_mid_shift_rLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(333)] 
		[RED("jaw_mid_shift_fwdLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_fwdLipsyncPoseOutput
		{
			get
			{
				if (_jaw_mid_shift_fwdLipsyncPoseOutput == null)
				{
					_jaw_mid_shift_fwdLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_fwdLipsyncPoseOutput", cr2w, this);
				}
				return _jaw_mid_shift_fwdLipsyncPoseOutput;
			}
			set
			{
				if (_jaw_mid_shift_fwdLipsyncPoseOutput == value)
				{
					return;
				}
				_jaw_mid_shift_fwdLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(334)] 
		[RED("jaw_mid_shift_backLipsyncPoseOutput")] 
		public CFloat Jaw_mid_shift_backLipsyncPoseOutput
		{
			get
			{
				if (_jaw_mid_shift_backLipsyncPoseOutput == null)
				{
					_jaw_mid_shift_backLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_shift_backLipsyncPoseOutput", cr2w, this);
				}
				return _jaw_mid_shift_backLipsyncPoseOutput;
			}
			set
			{
				if (_jaw_mid_shift_backLipsyncPoseOutput == value)
				{
					return;
				}
				_jaw_mid_shift_backLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(335)] 
		[RED("jaw_mid_clenchLipsyncPoseOutput")] 
		public CFloat Jaw_mid_clenchLipsyncPoseOutput
		{
			get
			{
				if (_jaw_mid_clenchLipsyncPoseOutput == null)
				{
					_jaw_mid_clenchLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_clenchLipsyncPoseOutput", cr2w, this);
				}
				return _jaw_mid_clenchLipsyncPoseOutput;
			}
			set
			{
				if (_jaw_mid_clenchLipsyncPoseOutput == value)
				{
					return;
				}
				_jaw_mid_clenchLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(336)] 
		[RED("neck_l_stretchLipsyncPoseOutput")] 
		public CFloat Neck_l_stretchLipsyncPoseOutput
		{
			get
			{
				if (_neck_l_stretchLipsyncPoseOutput == null)
				{
					_neck_l_stretchLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_l_stretchLipsyncPoseOutput", cr2w, this);
				}
				return _neck_l_stretchLipsyncPoseOutput;
			}
			set
			{
				if (_neck_l_stretchLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_l_stretchLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(337)] 
		[RED("neck_r_stretchLipsyncPoseOutput")] 
		public CFloat Neck_r_stretchLipsyncPoseOutput
		{
			get
			{
				if (_neck_r_stretchLipsyncPoseOutput == null)
				{
					_neck_r_stretchLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_r_stretchLipsyncPoseOutput", cr2w, this);
				}
				return _neck_r_stretchLipsyncPoseOutput;
			}
			set
			{
				if (_neck_r_stretchLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_r_stretchLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(338)] 
		[RED("neck_tightenLipsyncPoseOutput")] 
		public CFloat Neck_tightenLipsyncPoseOutput
		{
			get
			{
				if (_neck_tightenLipsyncPoseOutput == null)
				{
					_neck_tightenLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_tightenLipsyncPoseOutput", cr2w, this);
				}
				return _neck_tightenLipsyncPoseOutput;
			}
			set
			{
				if (_neck_tightenLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_tightenLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(339)] 
		[RED("neck_l_sternocleidomastoid_flexLipsyncPoseOutput")] 
		public CFloat Neck_l_sternocleidomastoid_flexLipsyncPoseOutput
		{
			get
			{
				if (_neck_l_sternocleidomastoid_flexLipsyncPoseOutput == null)
				{
					_neck_l_sternocleidomastoid_flexLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_l_sternocleidomastoid_flexLipsyncPoseOutput", cr2w, this);
				}
				return _neck_l_sternocleidomastoid_flexLipsyncPoseOutput;
			}
			set
			{
				if (_neck_l_sternocleidomastoid_flexLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_l_sternocleidomastoid_flexLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(340)] 
		[RED("neck_r_sternocleidomastoid_flexLipsyncPoseOutput")] 
		public CFloat Neck_r_sternocleidomastoid_flexLipsyncPoseOutput
		{
			get
			{
				if (_neck_r_sternocleidomastoid_flexLipsyncPoseOutput == null)
				{
					_neck_r_sternocleidomastoid_flexLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_r_sternocleidomastoid_flexLipsyncPoseOutput", cr2w, this);
				}
				return _neck_r_sternocleidomastoid_flexLipsyncPoseOutput;
			}
			set
			{
				if (_neck_r_sternocleidomastoid_flexLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_r_sternocleidomastoid_flexLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(341)] 
		[RED("neck_l_platysma_flexLipsyncPoseOutput")] 
		public CFloat Neck_l_platysma_flexLipsyncPoseOutput
		{
			get
			{
				if (_neck_l_platysma_flexLipsyncPoseOutput == null)
				{
					_neck_l_platysma_flexLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_l_platysma_flexLipsyncPoseOutput", cr2w, this);
				}
				return _neck_l_platysma_flexLipsyncPoseOutput;
			}
			set
			{
				if (_neck_l_platysma_flexLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_l_platysma_flexLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(342)] 
		[RED("neck_r_platysma_flexLipsyncPoseOutput")] 
		public CFloat Neck_r_platysma_flexLipsyncPoseOutput
		{
			get
			{
				if (_neck_r_platysma_flexLipsyncPoseOutput == null)
				{
					_neck_r_platysma_flexLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_r_platysma_flexLipsyncPoseOutput", cr2w, this);
				}
				return _neck_r_platysma_flexLipsyncPoseOutput;
			}
			set
			{
				if (_neck_r_platysma_flexLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_r_platysma_flexLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(343)] 
		[RED("neck_throat_adamsApple_upLipsyncPoseOutput")] 
		public CFloat Neck_throat_adamsApple_upLipsyncPoseOutput
		{
			get
			{
				if (_neck_throat_adamsApple_upLipsyncPoseOutput == null)
				{
					_neck_throat_adamsApple_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_adamsApple_upLipsyncPoseOutput", cr2w, this);
				}
				return _neck_throat_adamsApple_upLipsyncPoseOutput;
			}
			set
			{
				if (_neck_throat_adamsApple_upLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_throat_adamsApple_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(344)] 
		[RED("neck_throat_adamsApple_dnLipsyncPoseOutput")] 
		public CFloat Neck_throat_adamsApple_dnLipsyncPoseOutput
		{
			get
			{
				if (_neck_throat_adamsApple_dnLipsyncPoseOutput == null)
				{
					_neck_throat_adamsApple_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_adamsApple_dnLipsyncPoseOutput", cr2w, this);
				}
				return _neck_throat_adamsApple_dnLipsyncPoseOutput;
			}
			set
			{
				if (_neck_throat_adamsApple_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_throat_adamsApple_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(345)] 
		[RED("neck_throat_compressLipsyncPoseOutput")] 
		public CFloat Neck_throat_compressLipsyncPoseOutput
		{
			get
			{
				if (_neck_throat_compressLipsyncPoseOutput == null)
				{
					_neck_throat_compressLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_compressLipsyncPoseOutput", cr2w, this);
				}
				return _neck_throat_compressLipsyncPoseOutput;
			}
			set
			{
				if (_neck_throat_compressLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_throat_compressLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(346)] 
		[RED("neck_throat_openLipsyncPoseOutput")] 
		public CFloat Neck_throat_openLipsyncPoseOutput
		{
			get
			{
				if (_neck_throat_openLipsyncPoseOutput == null)
				{
					_neck_throat_openLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_throat_openLipsyncPoseOutput", cr2w, this);
				}
				return _neck_throat_openLipsyncPoseOutput;
			}
			set
			{
				if (_neck_throat_openLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_throat_openLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(347)] 
		[RED("neck_l_turnLipsyncPoseOutput")] 
		public CFloat Neck_l_turnLipsyncPoseOutput
		{
			get
			{
				if (_neck_l_turnLipsyncPoseOutput == null)
				{
					_neck_l_turnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_l_turnLipsyncPoseOutput", cr2w, this);
				}
				return _neck_l_turnLipsyncPoseOutput;
			}
			set
			{
				if (_neck_l_turnLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_l_turnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(348)] 
		[RED("neck_r_turnLipsyncPoseOutput")] 
		public CFloat Neck_r_turnLipsyncPoseOutput
		{
			get
			{
				if (_neck_r_turnLipsyncPoseOutput == null)
				{
					_neck_r_turnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_r_turnLipsyncPoseOutput", cr2w, this);
				}
				return _neck_r_turnLipsyncPoseOutput;
			}
			set
			{
				if (_neck_r_turnLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_r_turnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(349)] 
		[RED("neck_up_turnLipsyncPoseOutput")] 
		public CFloat Neck_up_turnLipsyncPoseOutput
		{
			get
			{
				if (_neck_up_turnLipsyncPoseOutput == null)
				{
					_neck_up_turnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_up_turnLipsyncPoseOutput", cr2w, this);
				}
				return _neck_up_turnLipsyncPoseOutput;
			}
			set
			{
				if (_neck_up_turnLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_up_turnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(350)] 
		[RED("neck_dn_turnLipsyncPoseOutput")] 
		public CFloat Neck_dn_turnLipsyncPoseOutput
		{
			get
			{
				if (_neck_dn_turnLipsyncPoseOutput == null)
				{
					_neck_dn_turnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_dn_turnLipsyncPoseOutput", cr2w, this);
				}
				return _neck_dn_turnLipsyncPoseOutput;
			}
			set
			{
				if (_neck_dn_turnLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_dn_turnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(351)] 
		[RED("neck_l_tiltLipsyncPoseOutput")] 
		public CFloat Neck_l_tiltLipsyncPoseOutput
		{
			get
			{
				if (_neck_l_tiltLipsyncPoseOutput == null)
				{
					_neck_l_tiltLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_l_tiltLipsyncPoseOutput", cr2w, this);
				}
				return _neck_l_tiltLipsyncPoseOutput;
			}
			set
			{
				if (_neck_l_tiltLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_l_tiltLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(352)] 
		[RED("neck_r_tiltLipsyncPoseOutput")] 
		public CFloat Neck_r_tiltLipsyncPoseOutput
		{
			get
			{
				if (_neck_r_tiltLipsyncPoseOutput == null)
				{
					_neck_r_tiltLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "neck_r_tiltLipsyncPoseOutput", cr2w, this);
				}
				return _neck_r_tiltLipsyncPoseOutput;
			}
			set
			{
				if (_neck_r_tiltLipsyncPoseOutput == value)
				{
					return;
				}
				_neck_r_tiltLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(353)] 
		[RED("head_neck_up_turnLipsyncPoseOutput")] 
		public CFloat Head_neck_up_turnLipsyncPoseOutput
		{
			get
			{
				if (_head_neck_up_turnLipsyncPoseOutput == null)
				{
					_head_neck_up_turnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "head_neck_up_turnLipsyncPoseOutput", cr2w, this);
				}
				return _head_neck_up_turnLipsyncPoseOutput;
			}
			set
			{
				if (_head_neck_up_turnLipsyncPoseOutput == value)
				{
					return;
				}
				_head_neck_up_turnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(354)] 
		[RED("head_neck_dn_turnLipsyncPoseOutput")] 
		public CFloat Head_neck_dn_turnLipsyncPoseOutput
		{
			get
			{
				if (_head_neck_dn_turnLipsyncPoseOutput == null)
				{
					_head_neck_dn_turnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "head_neck_dn_turnLipsyncPoseOutput", cr2w, this);
				}
				return _head_neck_dn_turnLipsyncPoseOutput;
			}
			set
			{
				if (_head_neck_dn_turnLipsyncPoseOutput == value)
				{
					return;
				}
				_head_neck_dn_turnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(355)] 
		[RED("head_neck_l_tiltLipsyncPoseOutput")] 
		public CFloat Head_neck_l_tiltLipsyncPoseOutput
		{
			get
			{
				if (_head_neck_l_tiltLipsyncPoseOutput == null)
				{
					_head_neck_l_tiltLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "head_neck_l_tiltLipsyncPoseOutput", cr2w, this);
				}
				return _head_neck_l_tiltLipsyncPoseOutput;
			}
			set
			{
				if (_head_neck_l_tiltLipsyncPoseOutput == value)
				{
					return;
				}
				_head_neck_l_tiltLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(356)] 
		[RED("head_neck_r_tiltLipsyncPoseOutput")] 
		public CFloat Head_neck_r_tiltLipsyncPoseOutput
		{
			get
			{
				if (_head_neck_r_tiltLipsyncPoseOutput == null)
				{
					_head_neck_r_tiltLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "head_neck_r_tiltLipsyncPoseOutput", cr2w, this);
				}
				return _head_neck_r_tiltLipsyncPoseOutput;
			}
			set
			{
				if (_head_neck_r_tiltLipsyncPoseOutput == value)
				{
					return;
				}
				_head_neck_r_tiltLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(357)] 
		[RED("ear_l_shift_upLipsyncPoseOutput")] 
		public CFloat Ear_l_shift_upLipsyncPoseOutput
		{
			get
			{
				if (_ear_l_shift_upLipsyncPoseOutput == null)
				{
					_ear_l_shift_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "ear_l_shift_upLipsyncPoseOutput", cr2w, this);
				}
				return _ear_l_shift_upLipsyncPoseOutput;
			}
			set
			{
				if (_ear_l_shift_upLipsyncPoseOutput == value)
				{
					return;
				}
				_ear_l_shift_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(358)] 
		[RED("ear_r_shift_upLipsyncPoseOutput")] 
		public CFloat Ear_r_shift_upLipsyncPoseOutput
		{
			get
			{
				if (_ear_r_shift_upLipsyncPoseOutput == null)
				{
					_ear_r_shift_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "ear_r_shift_upLipsyncPoseOutput", cr2w, this);
				}
				return _ear_r_shift_upLipsyncPoseOutput;
			}
			set
			{
				if (_ear_r_shift_upLipsyncPoseOutput == value)
				{
					return;
				}
				_ear_r_shift_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(359)] 
		[RED("sculp_mid_slideLipsyncPoseOutput")] 
		public CFloat Sculp_mid_slideLipsyncPoseOutput
		{
			get
			{
				if (_sculp_mid_slideLipsyncPoseOutput == null)
				{
					_sculp_mid_slideLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "sculp_mid_slideLipsyncPoseOutput", cr2w, this);
				}
				return _sculp_mid_slideLipsyncPoseOutput;
			}
			set
			{
				if (_sculp_mid_slideLipsyncPoseOutput == value)
				{
					return;
				}
				_sculp_mid_slideLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(360)] 
		[RED("face_gravity_fwdLipsyncPoseOutput")] 
		public CFloat Face_gravity_fwdLipsyncPoseOutput
		{
			get
			{
				if (_face_gravity_fwdLipsyncPoseOutput == null)
				{
					_face_gravity_fwdLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_fwdLipsyncPoseOutput", cr2w, this);
				}
				return _face_gravity_fwdLipsyncPoseOutput;
			}
			set
			{
				if (_face_gravity_fwdLipsyncPoseOutput == value)
				{
					return;
				}
				_face_gravity_fwdLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(361)] 
		[RED("face_gravity_backLipsyncPoseOutput")] 
		public CFloat Face_gravity_backLipsyncPoseOutput
		{
			get
			{
				if (_face_gravity_backLipsyncPoseOutput == null)
				{
					_face_gravity_backLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_backLipsyncPoseOutput", cr2w, this);
				}
				return _face_gravity_backLipsyncPoseOutput;
			}
			set
			{
				if (_face_gravity_backLipsyncPoseOutput == value)
				{
					return;
				}
				_face_gravity_backLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(362)] 
		[RED("face_gravity_lLipsyncPoseOutput")] 
		public CFloat Face_gravity_lLipsyncPoseOutput
		{
			get
			{
				if (_face_gravity_lLipsyncPoseOutput == null)
				{
					_face_gravity_lLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_lLipsyncPoseOutput", cr2w, this);
				}
				return _face_gravity_lLipsyncPoseOutput;
			}
			set
			{
				if (_face_gravity_lLipsyncPoseOutput == value)
				{
					return;
				}
				_face_gravity_lLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(363)] 
		[RED("face_gravity_rLipsyncPoseOutput")] 
		public CFloat Face_gravity_rLipsyncPoseOutput
		{
			get
			{
				if (_face_gravity_rLipsyncPoseOutput == null)
				{
					_face_gravity_rLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "face_gravity_rLipsyncPoseOutput", cr2w, this);
				}
				return _face_gravity_rLipsyncPoseOutput;
			}
			set
			{
				if (_face_gravity_rLipsyncPoseOutput == value)
				{
					return;
				}
				_face_gravity_rLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(364)] 
		[RED("tongue_mid_base_lLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_lLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_base_lLipsyncPoseOutput == null)
				{
					_tongue_mid_base_lLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_lLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_base_lLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_base_lLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_base_lLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(365)] 
		[RED("tongue_mid_base_rLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_rLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_base_rLipsyncPoseOutput == null)
				{
					_tongue_mid_base_rLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_rLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_base_rLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_base_rLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_base_rLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(366)] 
		[RED("tongue_mid_base_dnLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_dnLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_base_dnLipsyncPoseOutput == null)
				{
					_tongue_mid_base_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_dnLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_base_dnLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_base_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_base_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(367)] 
		[RED("tongue_mid_base_upLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_upLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_base_upLipsyncPoseOutput == null)
				{
					_tongue_mid_base_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_upLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_base_upLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_base_upLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_base_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(368)] 
		[RED("tongue_mid_base_fwdLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_fwdLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_base_fwdLipsyncPoseOutput == null)
				{
					_tongue_mid_base_fwdLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_fwdLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_base_fwdLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_base_fwdLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_base_fwdLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(369)] 
		[RED("tongue_mid_base_frontLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_frontLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_base_frontLipsyncPoseOutput == null)
				{
					_tongue_mid_base_frontLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_frontLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_base_frontLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_base_frontLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_base_frontLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(370)] 
		[RED("tongue_mid_base_backLipsyncPoseOutput")] 
		public CFloat Tongue_mid_base_backLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_base_backLipsyncPoseOutput == null)
				{
					_tongue_mid_base_backLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_base_backLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_base_backLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_base_backLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_base_backLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(371)] 
		[RED("tongue_mid_fwdLipsyncPoseOutput")] 
		public CFloat Tongue_mid_fwdLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_fwdLipsyncPoseOutput == null)
				{
					_tongue_mid_fwdLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_fwdLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_fwdLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_fwdLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_fwdLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(372)] 
		[RED("tongue_mid_liftLipsyncPoseOutput")] 
		public CFloat Tongue_mid_liftLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_liftLipsyncPoseOutput == null)
				{
					_tongue_mid_liftLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_liftLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_liftLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_liftLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_liftLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(373)] 
		[RED("tongue_mid_tip_lLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_lLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_tip_lLipsyncPoseOutput == null)
				{
					_tongue_mid_tip_lLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_lLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_tip_lLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_tip_lLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_tip_lLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(374)] 
		[RED("tongue_mid_tip_rLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_rLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_tip_rLipsyncPoseOutput == null)
				{
					_tongue_mid_tip_rLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_rLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_tip_rLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_tip_rLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_tip_rLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(375)] 
		[RED("tongue_mid_tip_dnLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_dnLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_tip_dnLipsyncPoseOutput == null)
				{
					_tongue_mid_tip_dnLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_dnLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_tip_dnLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_tip_dnLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_tip_dnLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(376)] 
		[RED("tongue_mid_tip_upLipsyncPoseOutput")] 
		public CFloat Tongue_mid_tip_upLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_tip_upLipsyncPoseOutput == null)
				{
					_tongue_mid_tip_upLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_tip_upLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_tip_upLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_tip_upLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_tip_upLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(377)] 
		[RED("tongue_mid_twist_lLipsyncPoseOutput")] 
		public CFloat Tongue_mid_twist_lLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_twist_lLipsyncPoseOutput == null)
				{
					_tongue_mid_twist_lLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_twist_lLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_twist_lLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_twist_lLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_twist_lLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(378)] 
		[RED("tongue_mid_twist_rLipsyncPoseOutput")] 
		public CFloat Tongue_mid_twist_rLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_twist_rLipsyncPoseOutput == null)
				{
					_tongue_mid_twist_rLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_twist_rLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_twist_rLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_twist_rLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_twist_rLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(379)] 
		[RED("tongue_mid_thickLipsyncPoseOutput")] 
		public CFloat Tongue_mid_thickLipsyncPoseOutput
		{
			get
			{
				if (_tongue_mid_thickLipsyncPoseOutput == null)
				{
					_tongue_mid_thickLipsyncPoseOutput = (CFloat) CR2WTypeManager.Create("Float", "tongue_mid_thickLipsyncPoseOutput", cr2w, this);
				}
				return _tongue_mid_thickLipsyncPoseOutput;
			}
			set
			{
				if (_tongue_mid_thickLipsyncPoseOutput == value)
				{
					return;
				}
				_tongue_mid_thickLipsyncPoseOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(380)] 
		[RED("eye_l_oculi_squint_outer_lowerWrnkl")] 
		public CFloat Eye_l_oculi_squint_outer_lowerWrnkl
		{
			get
			{
				if (_eye_l_oculi_squint_outer_lowerWrnkl == null)
				{
					_eye_l_oculi_squint_outer_lowerWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_outer_lowerWrnkl", cr2w, this);
				}
				return _eye_l_oculi_squint_outer_lowerWrnkl;
			}
			set
			{
				if (_eye_l_oculi_squint_outer_lowerWrnkl == value)
				{
					return;
				}
				_eye_l_oculi_squint_outer_lowerWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(381)] 
		[RED("eye_r_oculi_squint_outer_lowerWrnkl")] 
		public CFloat Eye_r_oculi_squint_outer_lowerWrnkl
		{
			get
			{
				if (_eye_r_oculi_squint_outer_lowerWrnkl == null)
				{
					_eye_r_oculi_squint_outer_lowerWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_outer_lowerWrnkl", cr2w, this);
				}
				return _eye_r_oculi_squint_outer_lowerWrnkl;
			}
			set
			{
				if (_eye_r_oculi_squint_outer_lowerWrnkl == value)
				{
					return;
				}
				_eye_r_oculi_squint_outer_lowerWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(382)] 
		[RED("eye_l_oculi_squint_outer_upperWrnkl")] 
		public CFloat Eye_l_oculi_squint_outer_upperWrnkl
		{
			get
			{
				if (_eye_l_oculi_squint_outer_upperWrnkl == null)
				{
					_eye_l_oculi_squint_outer_upperWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_l_oculi_squint_outer_upperWrnkl", cr2w, this);
				}
				return _eye_l_oculi_squint_outer_upperWrnkl;
			}
			set
			{
				if (_eye_l_oculi_squint_outer_upperWrnkl == value)
				{
					return;
				}
				_eye_l_oculi_squint_outer_upperWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(383)] 
		[RED("eye_r_oculi_squint_outer_upperWrnkl")] 
		public CFloat Eye_r_oculi_squint_outer_upperWrnkl
		{
			get
			{
				if (_eye_r_oculi_squint_outer_upperWrnkl == null)
				{
					_eye_r_oculi_squint_outer_upperWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_r_oculi_squint_outer_upperWrnkl", cr2w, this);
				}
				return _eye_r_oculi_squint_outer_upperWrnkl;
			}
			set
			{
				if (_eye_r_oculi_squint_outer_upperWrnkl == value)
				{
					return;
				}
				_eye_r_oculi_squint_outer_upperWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(384)] 
		[RED("eye_l_brows_raise_inWrnkl")] 
		public CFloat Eye_l_brows_raise_inWrnkl
		{
			get
			{
				if (_eye_l_brows_raise_inWrnkl == null)
				{
					_eye_l_brows_raise_inWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_raise_inWrnkl", cr2w, this);
				}
				return _eye_l_brows_raise_inWrnkl;
			}
			set
			{
				if (_eye_l_brows_raise_inWrnkl == value)
				{
					return;
				}
				_eye_l_brows_raise_inWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(385)] 
		[RED("eye_r_brows_raise_inWrnkl")] 
		public CFloat Eye_r_brows_raise_inWrnkl
		{
			get
			{
				if (_eye_r_brows_raise_inWrnkl == null)
				{
					_eye_r_brows_raise_inWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_raise_inWrnkl", cr2w, this);
				}
				return _eye_r_brows_raise_inWrnkl;
			}
			set
			{
				if (_eye_r_brows_raise_inWrnkl == value)
				{
					return;
				}
				_eye_r_brows_raise_inWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(386)] 
		[RED("eye_l_brows_raise_outWrnkl")] 
		public CFloat Eye_l_brows_raise_outWrnkl
		{
			get
			{
				if (_eye_l_brows_raise_outWrnkl == null)
				{
					_eye_l_brows_raise_outWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_raise_outWrnkl", cr2w, this);
				}
				return _eye_l_brows_raise_outWrnkl;
			}
			set
			{
				if (_eye_l_brows_raise_outWrnkl == value)
				{
					return;
				}
				_eye_l_brows_raise_outWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(387)] 
		[RED("eye_r_brows_raise_outWrnkl")] 
		public CFloat Eye_r_brows_raise_outWrnkl
		{
			get
			{
				if (_eye_r_brows_raise_outWrnkl == null)
				{
					_eye_r_brows_raise_outWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_raise_outWrnkl", cr2w, this);
				}
				return _eye_r_brows_raise_outWrnkl;
			}
			set
			{
				if (_eye_r_brows_raise_outWrnkl == value)
				{
					return;
				}
				_eye_r_brows_raise_outWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(388)] 
		[RED("eye_l_brows_lowerWrnkl")] 
		public CFloat Eye_l_brows_lowerWrnkl
		{
			get
			{
				if (_eye_l_brows_lowerWrnkl == null)
				{
					_eye_l_brows_lowerWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_lowerWrnkl", cr2w, this);
				}
				return _eye_l_brows_lowerWrnkl;
			}
			set
			{
				if (_eye_l_brows_lowerWrnkl == value)
				{
					return;
				}
				_eye_l_brows_lowerWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(389)] 
		[RED("eye_r_brows_lowerWrnkl")] 
		public CFloat Eye_r_brows_lowerWrnkl
		{
			get
			{
				if (_eye_r_brows_lowerWrnkl == null)
				{
					_eye_r_brows_lowerWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_lowerWrnkl", cr2w, this);
				}
				return _eye_r_brows_lowerWrnkl;
			}
			set
			{
				if (_eye_r_brows_lowerWrnkl == value)
				{
					return;
				}
				_eye_r_brows_lowerWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(390)] 
		[RED("eye_l_brows_lateralWrnkl")] 
		public CFloat Eye_l_brows_lateralWrnkl
		{
			get
			{
				if (_eye_l_brows_lateralWrnkl == null)
				{
					_eye_l_brows_lateralWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_l_brows_lateralWrnkl", cr2w, this);
				}
				return _eye_l_brows_lateralWrnkl;
			}
			set
			{
				if (_eye_l_brows_lateralWrnkl == value)
				{
					return;
				}
				_eye_l_brows_lateralWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(391)] 
		[RED("eye_r_brows_lateralWrnkl")] 
		public CFloat Eye_r_brows_lateralWrnkl
		{
			get
			{
				if (_eye_r_brows_lateralWrnkl == null)
				{
					_eye_r_brows_lateralWrnkl = (CFloat) CR2WTypeManager.Create("Float", "eye_r_brows_lateralWrnkl", cr2w, this);
				}
				return _eye_r_brows_lateralWrnkl;
			}
			set
			{
				if (_eye_r_brows_lateralWrnkl == value)
				{
					return;
				}
				_eye_r_brows_lateralWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(392)] 
		[RED("nose_l_snearWrnkl")] 
		public CFloat Nose_l_snearWrnkl
		{
			get
			{
				if (_nose_l_snearWrnkl == null)
				{
					_nose_l_snearWrnkl = (CFloat) CR2WTypeManager.Create("Float", "nose_l_snearWrnkl", cr2w, this);
				}
				return _nose_l_snearWrnkl;
			}
			set
			{
				if (_nose_l_snearWrnkl == value)
				{
					return;
				}
				_nose_l_snearWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(393)] 
		[RED("nose_r_snearWrnkl")] 
		public CFloat Nose_r_snearWrnkl
		{
			get
			{
				if (_nose_r_snearWrnkl == null)
				{
					_nose_r_snearWrnkl = (CFloat) CR2WTypeManager.Create("Float", "nose_r_snearWrnkl", cr2w, this);
				}
				return _nose_r_snearWrnkl;
			}
			set
			{
				if (_nose_r_snearWrnkl == value)
				{
					return;
				}
				_nose_r_snearWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(394)] 
		[RED("lips_l_upper_raiseWrnkl")] 
		public CFloat Lips_l_upper_raiseWrnkl
		{
			get
			{
				if (_lips_l_upper_raiseWrnkl == null)
				{
					_lips_l_upper_raiseWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_l_upper_raiseWrnkl", cr2w, this);
				}
				return _lips_l_upper_raiseWrnkl;
			}
			set
			{
				if (_lips_l_upper_raiseWrnkl == value)
				{
					return;
				}
				_lips_l_upper_raiseWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(395)] 
		[RED("lips_r_upper_raiseWrnkl")] 
		public CFloat Lips_r_upper_raiseWrnkl
		{
			get
			{
				if (_lips_r_upper_raiseWrnkl == null)
				{
					_lips_r_upper_raiseWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_r_upper_raiseWrnkl", cr2w, this);
				}
				return _lips_r_upper_raiseWrnkl;
			}
			set
			{
				if (_lips_r_upper_raiseWrnkl == value)
				{
					return;
				}
				_lips_r_upper_raiseWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(396)] 
		[RED("lips_l_corner_upWrnkl")] 
		public CFloat Lips_l_corner_upWrnkl
		{
			get
			{
				if (_lips_l_corner_upWrnkl == null)
				{
					_lips_l_corner_upWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_upWrnkl", cr2w, this);
				}
				return _lips_l_corner_upWrnkl;
			}
			set
			{
				if (_lips_l_corner_upWrnkl == value)
				{
					return;
				}
				_lips_l_corner_upWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(397)] 
		[RED("lips_r_corner_upWrnkl")] 
		public CFloat Lips_r_corner_upWrnkl
		{
			get
			{
				if (_lips_r_corner_upWrnkl == null)
				{
					_lips_r_corner_upWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_upWrnkl", cr2w, this);
				}
				return _lips_r_corner_upWrnkl;
			}
			set
			{
				if (_lips_r_corner_upWrnkl == value)
				{
					return;
				}
				_lips_r_corner_upWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(398)] 
		[RED("lips_l_corner_wideWrnkl")] 
		public CFloat Lips_l_corner_wideWrnkl
		{
			get
			{
				if (_lips_l_corner_wideWrnkl == null)
				{
					_lips_l_corner_wideWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_wideWrnkl", cr2w, this);
				}
				return _lips_l_corner_wideWrnkl;
			}
			set
			{
				if (_lips_l_corner_wideWrnkl == value)
				{
					return;
				}
				_lips_l_corner_wideWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(399)] 
		[RED("lips_r_corner_wideWrnkl")] 
		public CFloat Lips_r_corner_wideWrnkl
		{
			get
			{
				if (_lips_r_corner_wideWrnkl == null)
				{
					_lips_r_corner_wideWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_wideWrnkl", cr2w, this);
				}
				return _lips_r_corner_wideWrnkl;
			}
			set
			{
				if (_lips_r_corner_wideWrnkl == value)
				{
					return;
				}
				_lips_r_corner_wideWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(400)] 
		[RED("lips_l_corner_stretchWrnkl")] 
		public CFloat Lips_l_corner_stretchWrnkl
		{
			get
			{
				if (_lips_l_corner_stretchWrnkl == null)
				{
					_lips_l_corner_stretchWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_l_corner_stretchWrnkl", cr2w, this);
				}
				return _lips_l_corner_stretchWrnkl;
			}
			set
			{
				if (_lips_l_corner_stretchWrnkl == value)
				{
					return;
				}
				_lips_l_corner_stretchWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(401)] 
		[RED("lips_r_corner_stretchWrnkl")] 
		public CFloat Lips_r_corner_stretchWrnkl
		{
			get
			{
				if (_lips_r_corner_stretchWrnkl == null)
				{
					_lips_r_corner_stretchWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_r_corner_stretchWrnkl", cr2w, this);
				}
				return _lips_r_corner_stretchWrnkl;
			}
			set
			{
				if (_lips_r_corner_stretchWrnkl == value)
				{
					return;
				}
				_lips_r_corner_stretchWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(402)] 
		[RED("lips_l_lower_raiseWrnkl")] 
		public CFloat Lips_l_lower_raiseWrnkl
		{
			get
			{
				if (_lips_l_lower_raiseWrnkl == null)
				{
					_lips_l_lower_raiseWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_l_lower_raiseWrnkl", cr2w, this);
				}
				return _lips_l_lower_raiseWrnkl;
			}
			set
			{
				if (_lips_l_lower_raiseWrnkl == value)
				{
					return;
				}
				_lips_l_lower_raiseWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(403)] 
		[RED("lips_r_lower_raiseWrnkl")] 
		public CFloat Lips_r_lower_raiseWrnkl
		{
			get
			{
				if (_lips_r_lower_raiseWrnkl == null)
				{
					_lips_r_lower_raiseWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_r_lower_raiseWrnkl", cr2w, this);
				}
				return _lips_r_lower_raiseWrnkl;
			}
			set
			{
				if (_lips_r_lower_raiseWrnkl == value)
				{
					return;
				}
				_lips_r_lower_raiseWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(404)] 
		[RED("lips_chin_raiseWrnkl")] 
		public CFloat Lips_chin_raiseWrnkl
		{
			get
			{
				if (_lips_chin_raiseWrnkl == null)
				{
					_lips_chin_raiseWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_chin_raiseWrnkl", cr2w, this);
				}
				return _lips_chin_raiseWrnkl;
			}
			set
			{
				if (_lips_chin_raiseWrnkl == value)
				{
					return;
				}
				_lips_chin_raiseWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(405)] 
		[RED("lips_l_purseWrnkl")] 
		public CFloat Lips_l_purseWrnkl
		{
			get
			{
				if (_lips_l_purseWrnkl == null)
				{
					_lips_l_purseWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_l_purseWrnkl", cr2w, this);
				}
				return _lips_l_purseWrnkl;
			}
			set
			{
				if (_lips_l_purseWrnkl == value)
				{
					return;
				}
				_lips_l_purseWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(406)] 
		[RED("lips_r_purseWrnkl")] 
		public CFloat Lips_r_purseWrnkl
		{
			get
			{
				if (_lips_r_purseWrnkl == null)
				{
					_lips_r_purseWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_r_purseWrnkl", cr2w, this);
				}
				return _lips_r_purseWrnkl;
			}
			set
			{
				if (_lips_r_purseWrnkl == value)
				{
					return;
				}
				_lips_r_purseWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(407)] 
		[RED("lips_l_funnelWrnkl")] 
		public CFloat Lips_l_funnelWrnkl
		{
			get
			{
				if (_lips_l_funnelWrnkl == null)
				{
					_lips_l_funnelWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_l_funnelWrnkl", cr2w, this);
				}
				return _lips_l_funnelWrnkl;
			}
			set
			{
				if (_lips_l_funnelWrnkl == value)
				{
					return;
				}
				_lips_l_funnelWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(408)] 
		[RED("lips_r_funnelWrnkl")] 
		public CFloat Lips_r_funnelWrnkl
		{
			get
			{
				if (_lips_r_funnelWrnkl == null)
				{
					_lips_r_funnelWrnkl = (CFloat) CR2WTypeManager.Create("Float", "lips_r_funnelWrnkl", cr2w, this);
				}
				return _lips_r_funnelWrnkl;
			}
			set
			{
				if (_lips_r_funnelWrnkl == value)
				{
					return;
				}
				_lips_r_funnelWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(409)] 
		[RED("jaw_mid_openWrnkl")] 
		public CFloat Jaw_mid_openWrnkl
		{
			get
			{
				if (_jaw_mid_openWrnkl == null)
				{
					_jaw_mid_openWrnkl = (CFloat) CR2WTypeManager.Create("Float", "jaw_mid_openWrnkl", cr2w, this);
				}
				return _jaw_mid_openWrnkl;
			}
			set
			{
				if (_jaw_mid_openWrnkl == value)
				{
					return;
				}
				_jaw_mid_openWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(410)] 
		[RED("neck_l_stretchWrnkl")] 
		public CFloat Neck_l_stretchWrnkl
		{
			get
			{
				if (_neck_l_stretchWrnkl == null)
				{
					_neck_l_stretchWrnkl = (CFloat) CR2WTypeManager.Create("Float", "neck_l_stretchWrnkl", cr2w, this);
				}
				return _neck_l_stretchWrnkl;
			}
			set
			{
				if (_neck_l_stretchWrnkl == value)
				{
					return;
				}
				_neck_l_stretchWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(411)] 
		[RED("neck_r_stretchWrnkl")] 
		public CFloat Neck_r_stretchWrnkl
		{
			get
			{
				if (_neck_r_stretchWrnkl == null)
				{
					_neck_r_stretchWrnkl = (CFloat) CR2WTypeManager.Create("Float", "neck_r_stretchWrnkl", cr2w, this);
				}
				return _neck_r_stretchWrnkl;
			}
			set
			{
				if (_neck_r_stretchWrnkl == value)
				{
					return;
				}
				_neck_r_stretchWrnkl = value;
				PropertySet(this);
			}
		}

		[Ordinal(412)] 
		[RED("head_neck_dn_turnWrnkl")] 
		public CFloat Head_neck_dn_turnWrnkl
		{
			get
			{
				if (_head_neck_dn_turnWrnkl == null)
				{
					_head_neck_dn_turnWrnkl = (CFloat) CR2WTypeManager.Create("Float", "head_neck_dn_turnWrnkl", cr2w, this);
				}
				return _head_neck_dn_turnWrnkl;
			}
			set
			{
				if (_head_neck_dn_turnWrnkl == value)
				{
					return;
				}
				_head_neck_dn_turnWrnkl = value;
				PropertySet(this);
			}
		}

		public animSermoTestController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
