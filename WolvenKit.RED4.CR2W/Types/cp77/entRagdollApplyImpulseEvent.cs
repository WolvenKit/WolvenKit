using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollApplyImpulseEvent : redEvent
	{
		private Vector4 _worldImpulsePos;
		private Vector4 _worldImpulseValue;
		private CFloat _influenceRadius;

		[Ordinal(0)] 
		[RED("worldImpulsePos")] 
		public Vector4 WorldImpulsePos
		{
			get
			{
				if (_worldImpulsePos == null)
				{
					_worldImpulsePos = (Vector4) CR2WTypeManager.Create("Vector4", "worldImpulsePos", cr2w, this);
				}
				return _worldImpulsePos;
			}
			set
			{
				if (_worldImpulsePos == value)
				{
					return;
				}
				_worldImpulsePos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("worldImpulseValue")] 
		public Vector4 WorldImpulseValue
		{
			get
			{
				if (_worldImpulseValue == null)
				{
					_worldImpulseValue = (Vector4) CR2WTypeManager.Create("Vector4", "worldImpulseValue", cr2w, this);
				}
				return _worldImpulseValue;
			}
			set
			{
				if (_worldImpulseValue == value)
				{
					return;
				}
				_worldImpulseValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("influenceRadius")] 
		public CFloat InfluenceRadius
		{
			get
			{
				if (_influenceRadius == null)
				{
					_influenceRadius = (CFloat) CR2WTypeManager.Create("Float", "influenceRadius", cr2w, this);
				}
				return _influenceRadius;
			}
			set
			{
				if (_influenceRadius == value)
				{
					return;
				}
				_influenceRadius = value;
				PropertySet(this);
			}
		}

		public entRagdollApplyImpulseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
