using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FacialMixerSlot : animAnimNode_OnePoseInput
	{
		private CArray<animLookAtAnimationDefinition> _lookAtDefinitions;

		[Ordinal(12)] 
		[RED("lookAtDefinitions")] 
		public CArray<animLookAtAnimationDefinition> LookAtDefinitions
		{
			get
			{
				if (_lookAtDefinitions == null)
				{
					_lookAtDefinitions = (CArray<animLookAtAnimationDefinition>) CR2WTypeManager.Create("array:animLookAtAnimationDefinition", "lookAtDefinitions", cr2w, this);
				}
				return _lookAtDefinitions;
			}
			set
			{
				if (_lookAtDefinitions == value)
				{
					return;
				}
				_lookAtDefinitions = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FacialMixerSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
