using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAnimationOverrideMetadata : audioAudioMetadata
	{
		private CHandle<audioAnimationOverrideDictionary> _animationOverrides;

		[Ordinal(1)] 
		[RED("animationOverrides")] 
		public CHandle<audioAnimationOverrideDictionary> AnimationOverrides
		{
			get
			{
				if (_animationOverrides == null)
				{
					_animationOverrides = (CHandle<audioAnimationOverrideDictionary>) CR2WTypeManager.Create("handle:audioAnimationOverrideDictionary", "animationOverrides", cr2w, this);
				}
				return _animationOverrides;
			}
			set
			{
				if (_animationOverrides == value)
				{
					return;
				}
				_animationOverrides = value;
				PropertySet(this);
			}
		}

		public audioAnimationOverrideMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
