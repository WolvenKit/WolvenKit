using System.Collections.Generic;

namespace WolvenKit.Wwise.WEM
{
    public class WwiseSound
    {
        public List<int> EffectIds;
        public int EffectsMask;
        public bool HasUserAuxSends;
        public int OutputBus;
        public bool OverrideParentEffects;
        public bool OverrideParentGameAuxSends;
        public bool OverrideParentPlaybackPriority;
        public bool OverridePositioningSection;
        public bool OverridePriorityAdjustement;
        public Dictionary<int, float> Parameters;
        public int ParentId;
        public int Unknown1;
        public bool UnknownPlaybackLimit;
        public bool UseGameAuxSends;
        public List<int> UserAuxBusIds;
    }
}