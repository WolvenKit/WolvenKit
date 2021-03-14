using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseSlotWithDurationAnim : animAnimNode_SkPhaseWithDurationAnim
	{
		private CName _animFeatureName;
		private rRef<animActionAnimDatabase> _actionAnimDatabaseRef;

		[Ordinal(32)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get
			{
				if (_animFeatureName == null)
				{
					_animFeatureName = (CName) CR2WTypeManager.Create("CName", "animFeatureName", cr2w, this);
				}
				return _animFeatureName;
			}
			set
			{
				if (_animFeatureName == value)
				{
					return;
				}
				_animFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("actionAnimDatabaseRef")] 
		public rRef<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get
			{
				if (_actionAnimDatabaseRef == null)
				{
					_actionAnimDatabaseRef = (rRef<animActionAnimDatabase>) CR2WTypeManager.Create("rRef:animActionAnimDatabase", "actionAnimDatabaseRef", cr2w, this);
				}
				return _actionAnimDatabaseRef;
			}
			set
			{
				if (_actionAnimDatabaseRef == value)
				{
					return;
				}
				_actionAnimDatabaseRef = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkPhaseSlotWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
