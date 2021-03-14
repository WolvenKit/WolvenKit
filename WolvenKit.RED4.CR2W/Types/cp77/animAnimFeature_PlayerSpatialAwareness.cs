using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerSpatialAwareness : animAnimFeature
	{
		private Vector4 _leftClosestVector;
		private Vector4 _rightClosestVector;
		private Vector4 _upHitPosition;
		private CFloat _forwardDistance;

		[Ordinal(0)] 
		[RED("leftClosestVector")] 
		public Vector4 LeftClosestVector
		{
			get
			{
				if (_leftClosestVector == null)
				{
					_leftClosestVector = (Vector4) CR2WTypeManager.Create("Vector4", "leftClosestVector", cr2w, this);
				}
				return _leftClosestVector;
			}
			set
			{
				if (_leftClosestVector == value)
				{
					return;
				}
				_leftClosestVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rightClosestVector")] 
		public Vector4 RightClosestVector
		{
			get
			{
				if (_rightClosestVector == null)
				{
					_rightClosestVector = (Vector4) CR2WTypeManager.Create("Vector4", "rightClosestVector", cr2w, this);
				}
				return _rightClosestVector;
			}
			set
			{
				if (_rightClosestVector == value)
				{
					return;
				}
				_rightClosestVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("upHitPosition")] 
		public Vector4 UpHitPosition
		{
			get
			{
				if (_upHitPosition == null)
				{
					_upHitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "upHitPosition", cr2w, this);
				}
				return _upHitPosition;
			}
			set
			{
				if (_upHitPosition == value)
				{
					return;
				}
				_upHitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("forwardDistance")] 
		public CFloat ForwardDistance
		{
			get
			{
				if (_forwardDistance == null)
				{
					_forwardDistance = (CFloat) CR2WTypeManager.Create("Float", "forwardDistance", cr2w, this);
				}
				return _forwardDistance;
			}
			set
			{
				if (_forwardDistance == value)
				{
					return;
				}
				_forwardDistance = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_PlayerSpatialAwareness(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
