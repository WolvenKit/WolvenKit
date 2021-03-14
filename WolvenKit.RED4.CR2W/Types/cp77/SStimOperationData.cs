using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SStimOperationData : CVariable
	{
		private CEnum<DeviceStimType> _stimType;
		private CFloat _lifeTime;
		private CFloat _radius;
		private CEnum<EEffectOperationType> _operationType;
		private NodeRef _nodeRef;

		[Ordinal(0)] 
		[RED("stimType")] 
		public CEnum<DeviceStimType> StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (CEnum<DeviceStimType>) CR2WTypeManager.Create("DeviceStimType", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get
			{
				if (_lifeTime == null)
				{
					_lifeTime = (CFloat) CR2WTypeManager.Create("Float", "lifeTime", cr2w, this);
				}
				return _lifeTime;
			}
			set
			{
				if (_lifeTime == value)
				{
					return;
				}
				_lifeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EEffectOperationType>) CR2WTypeManager.Create("EEffectOperationType", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		public SStimOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
