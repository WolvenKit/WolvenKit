using System.Collections.Generic;

namespace WwiseSoundLib
{
  public class WwiseSound
  {
    private int ParentId;
    private int OutputBus;
    private bool OverrideParentEffects;
    private bool OverrideParentPlaybackPriority;
    private bool OverridePriorityAdjustement;
    private bool OverridePositioningSection;
    private bool OverrideParentGameAuxSends;
    private bool UseGameAuxSends;
    private bool HasUserAuxSends;
    private bool UnknownPlaybackLimit;
    private List<int> UserAuxBusIds;
    private Dictionary<int, float> Parameters;
    private int Unknown1;
    private int EffectsMask;
    private List<int> EffectIds;
  }
}
