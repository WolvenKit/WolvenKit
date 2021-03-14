using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicalJointPin : ISerializable
	{
		private CHandle<physicsISystemObject> _object;
		private CInt32 _featureIndex;
		private Vector3 _localPosition;
		private Quaternion _localRotation;

		[Ordinal(0)] 
		[RED("object")] 
		public CHandle<physicsISystemObject> Object
		{
			get
			{
				if (_object == null)
				{
					_object = (CHandle<physicsISystemObject>) CR2WTypeManager.Create("handle:physicsISystemObject", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("featureIndex")] 
		public CInt32 FeatureIndex
		{
			get
			{
				if (_featureIndex == null)
				{
					_featureIndex = (CInt32) CR2WTypeManager.Create("Int32", "featureIndex", cr2w, this);
				}
				return _featureIndex;
			}
			set
			{
				if (_featureIndex == value)
				{
					return;
				}
				_featureIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localPosition")] 
		public Vector3 LocalPosition
		{
			get
			{
				if (_localPosition == null)
				{
					_localPosition = (Vector3) CR2WTypeManager.Create("Vector3", "localPosition", cr2w, this);
				}
				return _localPosition;
			}
			set
			{
				if (_localPosition == value)
				{
					return;
				}
				_localPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("localRotation")] 
		public Quaternion LocalRotation
		{
			get
			{
				if (_localRotation == null)
				{
					_localRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "localRotation", cr2w, this);
				}
				return _localRotation;
			}
			set
			{
				if (_localRotation == value)
				{
					return;
				}
				_localRotation = value;
				PropertySet(this);
			}
		}

		public physicsPhysicalJointPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
