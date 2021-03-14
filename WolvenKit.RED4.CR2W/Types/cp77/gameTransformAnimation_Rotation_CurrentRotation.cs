using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Rotation_CurrentRotation : gameTransformAnimation_Rotation
	{
		private Quaternion _offset;

		[Ordinal(0)] 
		[RED("offset")] 
		public Quaternion Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Quaternion) CR2WTypeManager.Create("Quaternion", "offset", cr2w, this);
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

		public gameTransformAnimation_Rotation_CurrentRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
