using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_WallRun : animAnimFeature
	{
		private CBool _wallOnRightSide;
		private Vector4 _wallPosition;
		private Vector4 _wallNormal;

		[Ordinal(0)] 
		[RED("wallOnRightSide")] 
		public CBool WallOnRightSide
		{
			get
			{
				if (_wallOnRightSide == null)
				{
					_wallOnRightSide = (CBool) CR2WTypeManager.Create("Bool", "wallOnRightSide", cr2w, this);
				}
				return _wallOnRightSide;
			}
			set
			{
				if (_wallOnRightSide == value)
				{
					return;
				}
				_wallOnRightSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wallPosition")] 
		public Vector4 WallPosition
		{
			get
			{
				if (_wallPosition == null)
				{
					_wallPosition = (Vector4) CR2WTypeManager.Create("Vector4", "wallPosition", cr2w, this);
				}
				return _wallPosition;
			}
			set
			{
				if (_wallPosition == value)
				{
					return;
				}
				_wallPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("wallNormal")] 
		public Vector4 WallNormal
		{
			get
			{
				if (_wallNormal == null)
				{
					_wallNormal = (Vector4) CR2WTypeManager.Create("Vector4", "wallNormal", cr2w, this);
				}
				return _wallNormal;
			}
			set
			{
				if (_wallNormal == value)
				{
					return;
				}
				_wallNormal = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_WallRun(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
