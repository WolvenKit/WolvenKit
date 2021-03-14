using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDbgOverlapBox : CVariable
	{
		private Box _box;
		private Transform _transform;
		private CUInt32 _level;
		private CBool _isHit;

		[Ordinal(0)] 
		[RED("box")] 
		public Box Box
		{
			get
			{
				if (_box == null)
				{
					_box = (Box) CR2WTypeManager.Create("Box", "box", cr2w, this);
				}
				return _box;
			}
			set
			{
				if (_box == value)
				{
					return;
				}
				_box = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (Transform) CR2WTypeManager.Create("Transform", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CUInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CUInt32) CR2WTypeManager.Create("Uint32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isHit")] 
		public CBool IsHit
		{
			get
			{
				if (_isHit == null)
				{
					_isHit = (CBool) CR2WTypeManager.Create("Bool", "isHit", cr2w, this);
				}
				return _isHit;
			}
			set
			{
				if (_isHit == value)
				{
					return;
				}
				_isHit = value;
				PropertySet(this);
			}
		}

		public worldDbgOverlapBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
