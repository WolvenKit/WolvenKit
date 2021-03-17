using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldExtractedNodeSocket : CVariable
	{
		private CName _name;
		private CName _displayName;
		private Vector3 _position;
		private Quaternion _rotation;
		private Vector3 _direction;
		private CEnum<worldNodeSocketType> _type;
		private CBool _isSnapped;
		private CColor _color;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(3)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(4)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<worldNodeSocketType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(6)] 
		[RED("isSnapped")] 
		public CBool IsSnapped
		{
			get => GetProperty(ref _isSnapped);
			set => SetProperty(ref _isSnapped, value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		public worldExtractedNodeSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
