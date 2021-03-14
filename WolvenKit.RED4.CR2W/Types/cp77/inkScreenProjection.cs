using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScreenProjection : IScriptable
	{
		private CFloat _distanceToCamera;
		private Vector2 _previousPosition;
		private Vector2 _currentPosition;
		private Vector2 _uvPosition;

		[Ordinal(0)] 
		[RED("distanceToCamera")] 
		public CFloat DistanceToCamera
		{
			get
			{
				if (_distanceToCamera == null)
				{
					_distanceToCamera = (CFloat) CR2WTypeManager.Create("Float", "distanceToCamera", cr2w, this);
				}
				return _distanceToCamera;
			}
			set
			{
				if (_distanceToCamera == value)
				{
					return;
				}
				_distanceToCamera = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("previousPosition")] 
		public Vector2 PreviousPosition
		{
			get
			{
				if (_previousPosition == null)
				{
					_previousPosition = (Vector2) CR2WTypeManager.Create("Vector2", "previousPosition", cr2w, this);
				}
				return _previousPosition;
			}
			set
			{
				if (_previousPosition == value)
				{
					return;
				}
				_previousPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentPosition")] 
		public Vector2 CurrentPosition
		{
			get
			{
				if (_currentPosition == null)
				{
					_currentPosition = (Vector2) CR2WTypeManager.Create("Vector2", "currentPosition", cr2w, this);
				}
				return _currentPosition;
			}
			set
			{
				if (_currentPosition == value)
				{
					return;
				}
				_currentPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("uvPosition")] 
		public Vector2 UvPosition
		{
			get
			{
				if (_uvPosition == null)
				{
					_uvPosition = (Vector2) CR2WTypeManager.Create("Vector2", "uvPosition", cr2w, this);
				}
				return _uvPosition;
			}
			set
			{
				if (_uvPosition == value)
				{
					return;
				}
				_uvPosition = value;
				PropertySet(this);
			}
		}

		public inkScreenProjection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
