using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBodyTriggerDestructionComponent : entIComponent
	{
		private CName _colliderComponentName;
		private CHandle<physicsFilterData> _filterData;
		private CFloat _impulseForce;
		private CFloat _impulseRadius;

		[Ordinal(3)] 
		[RED("colliderComponentName")] 
		public CName ColliderComponentName
		{
			get
			{
				if (_colliderComponentName == null)
				{
					_colliderComponentName = (CName) CR2WTypeManager.Create("CName", "colliderComponentName", cr2w, this);
				}
				return _colliderComponentName;
			}
			set
			{
				if (_colliderComponentName == value)
				{
					return;
				}
				_colliderComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("impulseForce")] 
		public CFloat ImpulseForce
		{
			get
			{
				if (_impulseForce == null)
				{
					_impulseForce = (CFloat) CR2WTypeManager.Create("Float", "impulseForce", cr2w, this);
				}
				return _impulseForce;
			}
			set
			{
				if (_impulseForce == value)
				{
					return;
				}
				_impulseForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		public gameBodyTriggerDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
