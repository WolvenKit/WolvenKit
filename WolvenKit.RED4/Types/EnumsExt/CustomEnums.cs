// ReSharper disable InconsistentNaming

namespace WolvenKit.RED4.Types
{
    public static partial class Enums
    {
        // flags

        public enum EInterpolationType
        {
            Constant,
            Linear,
            BezierQuadratic,
            BezierCubic,
            Hermite
        }

        public enum ESegmentsLinkType
        {
            ESLT_Normal,
            ESLT_Smooth,
            ESLT_SmoothSymmetric
        };

        public enum EChannelLinkType
        {
            Normal,
            Smooth,
            SmoothSymmertric
        }

        public enum toolsSocketDirection
        {
            Invalid,
            Output,
        }

        public enum toolsSocketPlacement
        {
            Invalid,
            Bottom,
            Right,
        }

        public enum toolsAudioPlaybackDirectionSupport
        {
            Forward,
            Backward
        }

        public enum toolsAudioFastForwardSupport
        {
            MuteDuringFastForward,
            DontMuteDuringFastForward
        }

        public enum scnbPerformerAcquisitionPlanType
        {
            Invalid,
            Community,
            SpawnSet
        }
    }
}
