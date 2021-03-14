using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHoverResizeController : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimDefinition> _animToNew;
		private CHandle<inkanimDefinition> _animToOld;
		private Vector2 _vectorNewSize;
		private Vector2 _vectorOldSize;
		private CFloat _animationDuration;

		[Ordinal(1)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animToNew")] 
		public CHandle<inkanimDefinition> AnimToNew
		{
			get
			{
				if (_animToNew == null)
				{
					_animToNew = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animToNew", cr2w, this);
				}
				return _animToNew;
			}
			set
			{
				if (_animToNew == value)
				{
					return;
				}
				_animToNew = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animToOld")] 
		public CHandle<inkanimDefinition> AnimToOld
		{
			get
			{
				if (_animToOld == null)
				{
					_animToOld = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animToOld", cr2w, this);
				}
				return _animToOld;
			}
			set
			{
				if (_animToOld == value)
				{
					return;
				}
				_animToOld = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vectorNewSize")] 
		public Vector2 VectorNewSize
		{
			get
			{
				if (_vectorNewSize == null)
				{
					_vectorNewSize = (Vector2) CR2WTypeManager.Create("Vector2", "vectorNewSize", cr2w, this);
				}
				return _vectorNewSize;
			}
			set
			{
				if (_vectorNewSize == value)
				{
					return;
				}
				_vectorNewSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vectorOldSize")] 
		public Vector2 VectorOldSize
		{
			get
			{
				if (_vectorOldSize == null)
				{
					_vectorOldSize = (Vector2) CR2WTypeManager.Create("Vector2", "vectorOldSize", cr2w, this);
				}
				return _vectorOldSize;
			}
			set
			{
				if (_vectorOldSize == value)
				{
					return;
				}
				_vectorOldSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("animationDuration")] 
		public CFloat AnimationDuration
		{
			get
			{
				if (_animationDuration == null)
				{
					_animationDuration = (CFloat) CR2WTypeManager.Create("Float", "animationDuration", cr2w, this);
				}
				return _animationDuration;
			}
			set
			{
				if (_animationDuration == value)
				{
					return;
				}
				_animationDuration = value;
				PropertySet(this);
			}
		}

		public inkHoverResizeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
