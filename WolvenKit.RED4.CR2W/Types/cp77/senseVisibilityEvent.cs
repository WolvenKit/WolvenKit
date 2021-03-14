using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibilityEvent : redEvent
	{
		private wCHandle<gameObject> _target;
		private CBool _isVisible;
		private CName _description;
		private TweakDBID _shapeId;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("description")] 
		public CName Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CName) CR2WTypeManager.Create("CName", "description", cr2w, this);
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

		[Ordinal(3)] 
		[RED("shapeId")] 
		public TweakDBID ShapeId
		{
			get
			{
				if (_shapeId == null)
				{
					_shapeId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "shapeId", cr2w, this);
				}
				return _shapeId;
			}
			set
			{
				if (_shapeId == value)
				{
					return;
				}
				_shapeId = value;
				PropertySet(this);
			}
		}

		public senseVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
