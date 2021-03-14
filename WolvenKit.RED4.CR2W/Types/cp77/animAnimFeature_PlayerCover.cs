using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerCover : animAnimFeature
	{
		private Vector4 _cameraPositionMS;
		private CInt32 _coverState;
		private CFloat _leanAmount;
		private CFloat _cameraOffsetAmount;
		private CBool _autoCoverActivationFrame;

		[Ordinal(0)] 
		[RED("cameraPositionMS")] 
		public Vector4 CameraPositionMS
		{
			get
			{
				if (_cameraPositionMS == null)
				{
					_cameraPositionMS = (Vector4) CR2WTypeManager.Create("Vector4", "cameraPositionMS", cr2w, this);
				}
				return _cameraPositionMS;
			}
			set
			{
				if (_cameraPositionMS == value)
				{
					return;
				}
				_cameraPositionMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get
			{
				if (_coverState == null)
				{
					_coverState = (CInt32) CR2WTypeManager.Create("Int32", "coverState", cr2w, this);
				}
				return _coverState;
			}
			set
			{
				if (_coverState == value)
				{
					return;
				}
				_coverState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("leanAmount")] 
		public CFloat LeanAmount
		{
			get
			{
				if (_leanAmount == null)
				{
					_leanAmount = (CFloat) CR2WTypeManager.Create("Float", "leanAmount", cr2w, this);
				}
				return _leanAmount;
			}
			set
			{
				if (_leanAmount == value)
				{
					return;
				}
				_leanAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cameraOffsetAmount")] 
		public CFloat CameraOffsetAmount
		{
			get
			{
				if (_cameraOffsetAmount == null)
				{
					_cameraOffsetAmount = (CFloat) CR2WTypeManager.Create("Float", "cameraOffsetAmount", cr2w, this);
				}
				return _cameraOffsetAmount;
			}
			set
			{
				if (_cameraOffsetAmount == value)
				{
					return;
				}
				_cameraOffsetAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("autoCoverActivationFrame")] 
		public CBool AutoCoverActivationFrame
		{
			get
			{
				if (_autoCoverActivationFrame == null)
				{
					_autoCoverActivationFrame = (CBool) CR2WTypeManager.Create("Bool", "autoCoverActivationFrame", cr2w, this);
				}
				return _autoCoverActivationFrame;
			}
			set
			{
				if (_autoCoverActivationFrame == value)
				{
					return;
				}
				_autoCoverActivationFrame = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_PlayerCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
