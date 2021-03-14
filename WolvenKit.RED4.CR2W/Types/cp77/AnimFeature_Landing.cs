using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Landing : animAnimFeature
	{
		private CInt32 _type;
		private CFloat _impactSpeed;

		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CInt32) CR2WTypeManager.Create("Int32", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("impactSpeed")] 
		public CFloat ImpactSpeed
		{
			get
			{
				if (_impactSpeed == null)
				{
					_impactSpeed = (CFloat) CR2WTypeManager.Create("Float", "impactSpeed", cr2w, this);
				}
				return _impactSpeed;
			}
			set
			{
				if (_impactSpeed == value)
				{
					return;
				}
				_impactSpeed = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Landing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
