using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_HitReactions : animAnimFeature
	{
		private Vector4 _hitDirection;
		private CFloat _hitIntensity;
		private CInt32 _hitType;
		private CInt32 _hitBodyPart;

		[Ordinal(0)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get
			{
				if (_hitDirection == null)
				{
					_hitDirection = (Vector4) CR2WTypeManager.Create("Vector4", "hitDirection", cr2w, this);
				}
				return _hitDirection;
			}
			set
			{
				if (_hitDirection == value)
				{
					return;
				}
				_hitDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitIntensity")] 
		public CFloat HitIntensity
		{
			get
			{
				if (_hitIntensity == null)
				{
					_hitIntensity = (CFloat) CR2WTypeManager.Create("Float", "hitIntensity", cr2w, this);
				}
				return _hitIntensity;
			}
			set
			{
				if (_hitIntensity == value)
				{
					return;
				}
				_hitIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitType")] 
		public CInt32 HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CInt32) CR2WTypeManager.Create("Int32", "hitType", cr2w, this);
				}
				return _hitType;
			}
			set
			{
				if (_hitType == value)
				{
					return;
				}
				_hitType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get
			{
				if (_hitBodyPart == null)
				{
					_hitBodyPart = (CInt32) CR2WTypeManager.Create("Int32", "hitBodyPart", cr2w, this);
				}
				return _hitBodyPart;
			}
			set
			{
				if (_hitBodyPart == value)
				{
					return;
				}
				_hitBodyPart = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_HitReactions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
