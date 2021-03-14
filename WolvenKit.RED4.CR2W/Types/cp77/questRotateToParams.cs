using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRotateToParams : questAICommandParams
	{
		private CHandle<questUniversalRef> _facingTargetRef;
		private CFloat _angleOffset;
		private CFloat _speed;

		[Ordinal(0)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get
			{
				if (_facingTargetRef == null)
				{
					_facingTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "facingTargetRef", cr2w, this);
				}
				return _facingTargetRef;
			}
			set
			{
				if (_facingTargetRef == value)
				{
					return;
				}
				_facingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get
			{
				if (_angleOffset == null)
				{
					_angleOffset = (CFloat) CR2WTypeManager.Create("Float", "angleOffset", cr2w, this);
				}
				return _angleOffset;
			}
			set
			{
				if (_angleOffset == value)
				{
					return;
				}
				_angleOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		public questRotateToParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
