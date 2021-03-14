using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAnimationEventsOverrideClearNode : questIAudioNodeType
	{
		private CBool _resetGlobalOverride;
		private CBool _resetActorsOverride;

		[Ordinal(0)] 
		[RED("resetGlobalOverride")] 
		public CBool ResetGlobalOverride
		{
			get
			{
				if (_resetGlobalOverride == null)
				{
					_resetGlobalOverride = (CBool) CR2WTypeManager.Create("Bool", "resetGlobalOverride", cr2w, this);
				}
				return _resetGlobalOverride;
			}
			set
			{
				if (_resetGlobalOverride == value)
				{
					return;
				}
				_resetGlobalOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("resetActorsOverride")] 
		public CBool ResetActorsOverride
		{
			get
			{
				if (_resetActorsOverride == null)
				{
					_resetActorsOverride = (CBool) CR2WTypeManager.Create("Bool", "resetActorsOverride", cr2w, this);
				}
				return _resetActorsOverride;
			}
			set
			{
				if (_resetActorsOverride == value)
				{
					return;
				}
				_resetActorsOverride = value;
				PropertySet(this);
			}
		}

		public questAnimationEventsOverrideClearNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
