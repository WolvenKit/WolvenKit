using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.SRT
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class CWind
	{
		#region Properties
		public SParams Params { get; set; }
		public bool[] m_abOptions { get; set; } = new bool[(int)EOptions.NUM_WIND_OPTIONS];
		public float[] m_afBranchWindAnchor { get; set; } = new float[3];
		public float m_fMaxBranchLevel1Length { get; set; }
		#endregion










		// wind simulation components that oscillate
		public enum EOscillationComponents
		{
			OSC_GLOBAL,
			OSC_BRANCH_1,
			OSC_BRANCH_2,
			OSC_LEAF_1_RIPPLE,
			OSC_LEAF_1_TUMBLE,
			OSC_LEAF_1_TWITCH,
			OSC_LEAF_2_RIPPLE,
			OSC_LEAF_2_TUMBLE,
			OSC_LEAF_2_TWITCH,
			OSC_FROND_RIPPLE,
			NUM_OSC_COMPONENTS
		};

		// shader state that are set at compile time
		public enum EOptions
		{
			GLOBAL_WIND,
			GLOBAL_PRESERVE_SHAPE,

			BRANCH_SIMPLE_1,
			BRANCH_DIRECTIONAL_1,
			BRANCH_DIRECTIONAL_FROND_1,
			BRANCH_TURBULENCE_1,
			BRANCH_WHIP_1,
			BRANCH_OSC_COMPLEX_1,

			BRANCH_SIMPLE_2,
			BRANCH_DIRECTIONAL_2,
			BRANCH_DIRECTIONAL_FROND_2,
			BRANCH_TURBULENCE_2,
			BRANCH_WHIP_2,
			BRANCH_OSC_COMPLEX_2,

			LEAF_RIPPLE_VERTEX_NORMAL_1,
			LEAF_RIPPLE_COMPUTED_1,
			LEAF_TUMBLE_1,
			LEAF_TWITCH_1,
			LEAF_OCCLUSION_1,

			LEAF_RIPPLE_VERTEX_NORMAL_2,
			LEAF_RIPPLE_COMPUTED_2,
			LEAF_TUMBLE_2,
			LEAF_TWITCH_2,
			LEAF_OCCLUSION_2,

			FROND_RIPPLE_ONE_SIDED,
			FROND_RIPPLE_TWO_SIDED,
			FROND_RIPPLE_ADJUST_LIGHTING,

			ROLLING,

			NUM_WIND_OPTIONS
		};


		///////////////////////////////////////////////////////////////////////  
		// Constants

		const int c_nNumWindPointsInCurves = 10;

		// adjusting these constants is not enough to add more levels or groups (need more shaders, different data uploaded, CWind modifications, etc.)
		const int c_nNumBranchLevels = 2;
		const int c_nNumLeafGroups = 2;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public struct SParams
		{
			// settings
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fStrengthResponse { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fDirectionResponse { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fAnchorOffset { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fAnchorDistanceScale { get; set; }

            // oscillation components
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)EOscillationComponents.NUM_OSC_COMPONENTS * c_nNumWindPointsInCurves)]
            private float[,] afFrequencies;
			public float[,] AfFrequencies { get => afFrequencies; set => afFrequencies = value; }

			// global motion
			/*[MarshalAs(UnmanagedType.R4)]*/
			public float m_fGlobalHeight { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGlobalHeightExponent { get; set; }

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
			private float[] m_afGlobalDistance;
			public float[] AfGlobalDistance { get => m_afGlobalDistance; set => m_afGlobalDistance = value; }
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afGlobalDirectionAdherence;
			public float[] AfGlobalDirectionAdherence { get => afGlobalDirectionAdherence; set => afGlobalDirectionAdherence = value; }

            // branch motion
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumBranchLevels)]
            private SBranchWindLevel[] asBranch;
			public SBranchWindLevel[] AsBranch { get => asBranch; set => asBranch = value; }

			// leaf motion
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumLeafGroups)]
            private SWindGroup[] asLeaf;
			public SWindGroup[] AsLeaf { get => asLeaf; set => asLeaf = value; }

			// frond ripple
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afFrondRippleDistance;
			public float[] AfFrondRippleDistance { get => afFrondRippleDistance; set => afFrondRippleDistance = value; }

			/*[MarshalAs(UnmanagedType.R4)]*/
			public float m_fFrondRippleTile { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fFrondRippleLightingScalar { get; set; }

			// rolling
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingNoiseSize { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingNoiseTwist { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingNoiseTurbulence { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingNoisePeriod { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingNoiseSpeed { get; set; }

			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingBranchFieldMin { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingBranchLightingAdjust { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingBranchVerticalOffset { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingLeafRippleMin { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollingLeafTumbleMin { get; set; }

			// gusting
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGustFrequency { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGustStrengthMin { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGustStrengthMax { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGustDurationMin { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGustDurationMax { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGustRiseScalar { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fGustFallScalar { get; set; }
            
        }

		
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public struct SWindGroup
		{
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afRippleDistance;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afTumbleFlip;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afTumbleTwist;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afTumbleDirectionAdherence;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afTwitchThrow;

            /*[MarshalAs(UnmanagedType.R4)]*/ public float m_fTwitchSharpness { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollMaxScale { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollMinScale { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollSpeed { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fRollSeparation { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fLeewardScalar { get; set; }

            public float[] AfRippleDistance { get => afRippleDistance; set => afRippleDistance = value; }
            public float[] AfTumbleFlip { get => afTumbleFlip; set => afTumbleFlip = value; }
            public float[] AfTumbleTwist { get => afTumbleTwist; set => afTumbleTwist = value; }
            public float[] AfTumbleDirectionAdherence { get => afTumbleDirectionAdherence; set => afTumbleDirectionAdherence = value; }
            public float[] AfTwitchThrow { get => afTwitchThrow; set => afTwitchThrow = value; }
        }

		[TypeConverter(typeof(ExpandableObjectConverter))]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct SBranchWindLevel
		{
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afDistance;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afDirectionAdherence;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = c_nNumWindPointsInCurves, ArraySubType = UnmanagedType.R4)]
            private float[] afWhip;

            /*[MarshalAs(UnmanagedType.R4)]*/ public float m_fTurbulence { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fTwitch { get; set; }
			/*[MarshalAs(UnmanagedType.R4)]*/ public float m_fTwitchFreqScale { get; set; }
            public float[] AfDistance { get => afDistance; set => afDistance = value; }
            public float[] AfDirectionAdherence { get => afDirectionAdherence; set => afDirectionAdherence = value; }
            public float[] AfWhip { get => afWhip; set => afWhip = value; }
        }
    }
}
