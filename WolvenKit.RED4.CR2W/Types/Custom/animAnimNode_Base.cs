using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_Base : animAnimNode_Base_
    {
        private CName _debugName;
        private CBool _visPrePose;
        private CColor _visPrePoseColor;
        private CBool _visPostPose;
        private CColor _visPostPoseColor;
        private CName _visRigPartMask;
        private CBool _visAxes;
        private CBool _visNames;
        private CArray<animTransformIndex> _visMask;
        private animPoseInfoLogger _poseInfoLogger;
        private CBool _visWhenActive;

        [Ordinal(1)]
        [RED("debugName")]
        public CName DebugName
        {
            get => GetProperty(ref _debugName);
            set => SetProperty(ref _debugName, value);
        }

        [Ordinal(2)]
        [RED("visPrePose")]
        public CBool VisPrePose
        {
            get => GetProperty(ref _visPrePose);
            set => SetProperty(ref _visPrePose, value);
        }

        [Ordinal(3)]
        [RED("visPrePoseColor")]
        public CColor VisPrePoseColor
        {
            get => GetProperty(ref _visPrePoseColor);
            set => SetProperty(ref _visPrePoseColor, value);
        }

        [Ordinal(4)]
        [RED("visPostPose")]
        public CBool VisPostPose
        {
            get => GetProperty(ref _visPostPose);
            set => SetProperty(ref _visPostPose, value);
        }

        [Ordinal(5)]
        [RED("visPostPoseColor")]
        public CColor VisPostPoseColor
        {
            get => GetProperty(ref _visPostPoseColor);
            set => SetProperty(ref _visPostPoseColor, value);
        }

        [Ordinal(6)]
        [RED("visRigPartMask")]
        public CName VisRigPartMask
        {
            get => GetProperty(ref _visRigPartMask);
            set => SetProperty(ref _visRigPartMask, value);
        }

        [Ordinal(7)]
        [RED("visAxes")]
        public CBool VisAxes
        {
            get => GetProperty(ref _visAxes);
            set => SetProperty(ref _visAxes, value);
        }

        [Ordinal(8)]
        [RED("visNames")]
        public CBool VisNames
        {
            get => GetProperty(ref _visNames);
            set => SetProperty(ref _visNames, value);
        }

        [Ordinal(9)]
        [RED("visMask")]
        public CArray<animTransformIndex> VisMask
        {
            get => GetProperty(ref _visMask);
            set => SetProperty(ref _visMask, value);
        }

        [Ordinal(10)]
        [RED("poseInfoLogger")]
        public animPoseInfoLogger PoseInfoLogger
        {
            get => GetProperty(ref _poseInfoLogger);
            set => SetProperty(ref _poseInfoLogger, value);
        }

        [Ordinal(1000)]
        [RED("visWhenActive")]
        public CBool VisWhenActive
        {
            get => GetProperty(ref _visWhenActive);
            set => SetProperty(ref _visWhenActive, value);
        }
        //[Ordinal(1001)] [RED("debug")] public CBool Debug { get; set; }
        //[Ordinal(1002)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }

        public animAnimNode_Base(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
