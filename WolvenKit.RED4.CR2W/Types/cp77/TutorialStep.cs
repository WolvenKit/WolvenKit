using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TutorialStep : CVariable
	{
		private CString _description;
		private CBool _showPointer;
		private CFloat _pointerRotation;
		private CFloat _pointerXPos;
		private CFloat _pointerYPos;
		private CArray<CName> _allowedActions;

		[Ordinal(0)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("showPointer")] 
		public CBool ShowPointer
		{
			get
			{
				if (_showPointer == null)
				{
					_showPointer = (CBool) CR2WTypeManager.Create("Bool", "showPointer", cr2w, this);
				}
				return _showPointer;
			}
			set
			{
				if (_showPointer == value)
				{
					return;
				}
				_showPointer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pointerRotation")] 
		public CFloat PointerRotation
		{
			get
			{
				if (_pointerRotation == null)
				{
					_pointerRotation = (CFloat) CR2WTypeManager.Create("Float", "pointerRotation", cr2w, this);
				}
				return _pointerRotation;
			}
			set
			{
				if (_pointerRotation == value)
				{
					return;
				}
				_pointerRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pointerXPos")] 
		public CFloat PointerXPos
		{
			get
			{
				if (_pointerXPos == null)
				{
					_pointerXPos = (CFloat) CR2WTypeManager.Create("Float", "pointerXPos", cr2w, this);
				}
				return _pointerXPos;
			}
			set
			{
				if (_pointerXPos == value)
				{
					return;
				}
				_pointerXPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pointerYPos")] 
		public CFloat PointerYPos
		{
			get
			{
				if (_pointerYPos == null)
				{
					_pointerYPos = (CFloat) CR2WTypeManager.Create("Float", "pointerYPos", cr2w, this);
				}
				return _pointerYPos;
			}
			set
			{
				if (_pointerYPos == value)
				{
					return;
				}
				_pointerYPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("allowedActions")] 
		public CArray<CName> AllowedActions
		{
			get
			{
				if (_allowedActions == null)
				{
					_allowedActions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "allowedActions", cr2w, this);
				}
				return _allowedActions;
			}
			set
			{
				if (_allowedActions == value)
				{
					return;
				}
				_allowedActions = value;
				PropertySet(this);
			}
		}

		public TutorialStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
