using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaceMineEvent : redEvent
	{
		private Vector4 _position;
		private Vector4 _normal;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector4 Normal
		{
			get
			{
				if (_normal == null)
				{
					_normal = (Vector4) CR2WTypeManager.Create("Vector4", "normal", cr2w, this);
				}
				return _normal;
			}
			set
			{
				if (_normal == value)
				{
					return;
				}
				_normal = value;
				PropertySet(this);
			}
		}

		public PlaceMineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
