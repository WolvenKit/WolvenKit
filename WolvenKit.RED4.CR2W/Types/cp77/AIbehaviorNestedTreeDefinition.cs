using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNestedTreeDefinition : AIbehaviorTreeNodeDefinition
	{
		private CBool _lateInitialization;
		private CArray<CName> _initializeOnEvent;

		[Ordinal(0)] 
		[RED("lateInitialization")] 
		public CBool LateInitialization
		{
			get
			{
				if (_lateInitialization == null)
				{
					_lateInitialization = (CBool) CR2WTypeManager.Create("Bool", "lateInitialization", cr2w, this);
				}
				return _lateInitialization;
			}
			set
			{
				if (_lateInitialization == value)
				{
					return;
				}
				_lateInitialization = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("initializeOnEvent")] 
		public CArray<CName> InitializeOnEvent
		{
			get
			{
				if (_initializeOnEvent == null)
				{
					_initializeOnEvent = (CArray<CName>) CR2WTypeManager.Create("array:CName", "initializeOnEvent", cr2w, this);
				}
				return _initializeOnEvent;
			}
			set
			{
				if (_initializeOnEvent == value)
				{
					return;
				}
				_initializeOnEvent = value;
				PropertySet(this);
			}
		}

		public AIbehaviorNestedTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
