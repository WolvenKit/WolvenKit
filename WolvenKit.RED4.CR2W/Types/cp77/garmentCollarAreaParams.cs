using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentCollarAreaParams : CVariable
	{
		private CBool _enable;
		private CFloat _radiusInCM;
		private CFloat _radiusForTriangleRemovalInCM;
		private CFloat _offsetFromSkinInCM;
		private Vector3 _offset;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("radiusInCM")] 
		public CFloat RadiusInCM
		{
			get
			{
				if (_radiusInCM == null)
				{
					_radiusInCM = (CFloat) CR2WTypeManager.Create("Float", "radiusInCM", cr2w, this);
				}
				return _radiusInCM;
			}
			set
			{
				if (_radiusInCM == value)
				{
					return;
				}
				_radiusInCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("radiusForTriangleRemovalInCM")] 
		public CFloat RadiusForTriangleRemovalInCM
		{
			get
			{
				if (_radiusForTriangleRemovalInCM == null)
				{
					_radiusForTriangleRemovalInCM = (CFloat) CR2WTypeManager.Create("Float", "radiusForTriangleRemovalInCM", cr2w, this);
				}
				return _radiusForTriangleRemovalInCM;
			}
			set
			{
				if (_radiusForTriangleRemovalInCM == value)
				{
					return;
				}
				_radiusForTriangleRemovalInCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offsetFromSkinInCM")] 
		public CFloat OffsetFromSkinInCM
		{
			get
			{
				if (_offsetFromSkinInCM == null)
				{
					_offsetFromSkinInCM = (CFloat) CR2WTypeManager.Create("Float", "offsetFromSkinInCM", cr2w, this);
				}
				return _offsetFromSkinInCM;
			}
			set
			{
				if (_offsetFromSkinInCM == value)
				{
					return;
				}
				_offsetFromSkinInCM = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public garmentCollarAreaParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
