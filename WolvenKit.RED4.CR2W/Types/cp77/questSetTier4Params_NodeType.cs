using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTier4Params_NodeType : questISceneManagerNodeType
	{
		private NodeRef _objectRef;
		private CFloat _adjustTime;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get
			{
				if (_adjustTime == null)
				{
					_adjustTime = (CFloat) CR2WTypeManager.Create("Float", "adjustTime", cr2w, this);
				}
				return _adjustTime;
			}
			set
			{
				if (_adjustTime == value)
				{
					return;
				}
				_adjustTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get
			{
				if (_usePlayerWorkspot == null)
				{
					_usePlayerWorkspot = (CBool) CR2WTypeManager.Create("Bool", "usePlayerWorkspot", cr2w, this);
				}
				return _usePlayerWorkspot;
			}
			set
			{
				if (_usePlayerWorkspot == value)
				{
					return;
				}
				_usePlayerWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get
			{
				if (_useEnterAnim == null)
				{
					_useEnterAnim = (CBool) CR2WTypeManager.Create("Bool", "useEnterAnim", cr2w, this);
				}
				return _useEnterAnim;
			}
			set
			{
				if (_useEnterAnim == value)
				{
					return;
				}
				_useEnterAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get
			{
				if (_useExitAnim == null)
				{
					_useExitAnim = (CBool) CR2WTypeManager.Create("Bool", "useExitAnim", cr2w, this);
				}
				return _useExitAnim;
			}
			set
			{
				if (_useExitAnim == value)
				{
					return;
				}
				_useExitAnim = value;
				PropertySet(this);
			}
		}

		public questSetTier4Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
