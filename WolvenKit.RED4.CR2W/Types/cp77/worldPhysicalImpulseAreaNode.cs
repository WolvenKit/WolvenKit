using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalImpulseAreaNode : worldPhysicalTriggerAreaNode
	{
		private Vector3 _impulse;
		private CFloat _impulseRadius;

		[Ordinal(7)] 
		[RED("impulse")] 
		public Vector3 Impulse
		{
			get
			{
				if (_impulse == null)
				{
					_impulse = (Vector3) CR2WTypeManager.Create("Vector3", "impulse", cr2w, this);
				}
				return _impulse;
			}
			set
			{
				if (_impulse == value)
				{
					return;
				}
				_impulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("impulseRadius")] 
		public CFloat ImpulseRadius
		{
			get
			{
				if (_impulseRadius == null)
				{
					_impulseRadius = (CFloat) CR2WTypeManager.Create("Float", "impulseRadius", cr2w, this);
				}
				return _impulseRadius;
			}
			set
			{
				if (_impulseRadius == value)
				{
					return;
				}
				_impulseRadius = value;
				PropertySet(this);
			}
		}

		public worldPhysicalImpulseAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
