using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Position_InitialPosition : gameTransformAnimation_Position
	{
		private Vector3 _offset;
		private CBool _offsetInWorldSpace;

		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offsetInWorldSpace")] 
		public CBool OffsetInWorldSpace
		{
			get
			{
				if (_offsetInWorldSpace == null)
				{
					_offsetInWorldSpace = (CBool) CR2WTypeManager.Create("Bool", "offsetInWorldSpace", cr2w, this);
				}
				return _offsetInWorldSpace;
			}
			set
			{
				if (_offsetInWorldSpace == value)
				{
					return;
				}
				_offsetInWorldSpace = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_Position_InitialPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
