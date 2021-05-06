using System;
using System.Collections.Generic;
using System.Text;
using WolvenKit.RED4.CR2W.Reflection;
// ReSharper disable InconsistentNaming

namespace WolvenKit.RED4.CR2W.Types
{
    public static partial class Enums
    {
        // flags

        public enum EInterPolationType
        {
            Constant,
            Linear,
            BezierQuadratic,
            BezierCubic,
            Hermite
        }

        public enum EChannelLinkType
        {
            Normal,
            Smooth,
            SmoothSymmertric
        }

        public enum toolsSocketDirection
        {
            Output,
        }

        public enum toolsSocketPlacement
        {
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
            Community,
            SpawnSet
        }
    }
}
