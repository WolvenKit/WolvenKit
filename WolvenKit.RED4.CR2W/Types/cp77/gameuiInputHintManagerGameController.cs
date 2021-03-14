using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintManagerGameController : gameuiWidgetGameController
	{
		private CName _hintContainerId;
		private inkCompoundWidgetReference _baseGroupContainer;
		private inkCompoundWidgetReference _groupsContainer;
		private inkWidgetLibraryReference _hintLibRef;
		private inkWidgetLibraryReference _groupLibRef;

		[Ordinal(2)] 
		[RED("hintContainerId")] 
		public CName HintContainerId
		{
			get
			{
				if (_hintContainerId == null)
				{
					_hintContainerId = (CName) CR2WTypeManager.Create("CName", "hintContainerId", cr2w, this);
				}
				return _hintContainerId;
			}
			set
			{
				if (_hintContainerId == value)
				{
					return;
				}
				_hintContainerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("baseGroupContainer")] 
		public inkCompoundWidgetReference BaseGroupContainer
		{
			get
			{
				if (_baseGroupContainer == null)
				{
					_baseGroupContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "baseGroupContainer", cr2w, this);
				}
				return _baseGroupContainer;
			}
			set
			{
				if (_baseGroupContainer == value)
				{
					return;
				}
				_baseGroupContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("groupsContainer")] 
		public inkCompoundWidgetReference GroupsContainer
		{
			get
			{
				if (_groupsContainer == null)
				{
					_groupsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "groupsContainer", cr2w, this);
				}
				return _groupsContainer;
			}
			set
			{
				if (_groupsContainer == value)
				{
					return;
				}
				_groupsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hintLibRef")] 
		public inkWidgetLibraryReference HintLibRef
		{
			get
			{
				if (_hintLibRef == null)
				{
					_hintLibRef = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "hintLibRef", cr2w, this);
				}
				return _hintLibRef;
			}
			set
			{
				if (_hintLibRef == value)
				{
					return;
				}
				_hintLibRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("groupLibRef")] 
		public inkWidgetLibraryReference GroupLibRef
		{
			get
			{
				if (_groupLibRef == null)
				{
					_groupLibRef = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "groupLibRef", cr2w, this);
				}
				return _groupLibRef;
			}
			set
			{
				if (_groupLibRef == value)
				{
					return;
				}
				_groupLibRef = value;
				PropertySet(this);
			}
		}

		public gameuiInputHintManagerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
