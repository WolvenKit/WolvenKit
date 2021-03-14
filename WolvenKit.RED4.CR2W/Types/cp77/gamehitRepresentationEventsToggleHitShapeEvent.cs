using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsToggleHitShapeEvent : redEvent
	{
		private CBool _enable;
		private CName _hitShapeName;
		private CBool _hierarchical;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitShapeName")] 
		public CName HitShapeName
		{
			get
			{
				if (_hitShapeName == null)
				{
					_hitShapeName = (CName) CR2WTypeManager.Create("CName", "hitShapeName", cr2w, this);
				}
				return _hitShapeName;
			}
			set
			{
				if (_hitShapeName == value)
				{
					return;
				}
				_hitShapeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hierarchical")] 
		public CBool Hierarchical
		{
			get
			{
				if (_hierarchical == null)
				{
					_hierarchical = (CBool) CR2WTypeManager.Create("Bool", "hierarchical", cr2w, this);
				}
				return _hierarchical;
			}
			set
			{
				if (_hierarchical == value)
				{
					return;
				}
				_hierarchical = value;
				PropertySet(this);
			}
		}

		public gamehitRepresentationEventsToggleHitShapeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
