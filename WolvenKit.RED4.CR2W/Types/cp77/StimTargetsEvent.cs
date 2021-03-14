using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimTargetsEvent : redEvent
	{
		private CArray<StimTargetData> _targets;
		private CBool _restore;

		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<StimTargetData> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<StimTargetData>) CR2WTypeManager.Create("array:StimTargetData", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("restore")] 
		public CBool Restore
		{
			get
			{
				if (_restore == null)
				{
					_restore = (CBool) CR2WTypeManager.Create("Bool", "restore", cr2w, this);
				}
				return _restore;
			}
			set
			{
				if (_restore == value)
				{
					return;
				}
				_restore = value;
				PropertySet(this);
			}
		}

		public StimTargetsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
