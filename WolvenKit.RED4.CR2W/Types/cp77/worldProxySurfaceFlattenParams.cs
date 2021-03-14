using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxySurfaceFlattenParams : CVariable
	{
		private CBool _flatten;
		private CEnum<worldProxyNormalAngleStepSize> _groupingStepAngle;
		private CEnum<worldProxySyncNormalSource> _syncNormalSource;
		private CFloat _coreAxisRotationOffset;
		private CBool _postFlattenReduce;

		[Ordinal(0)] 
		[RED("flatten")] 
		public CBool Flatten
		{
			get
			{
				if (_flatten == null)
				{
					_flatten = (CBool) CR2WTypeManager.Create("Bool", "flatten", cr2w, this);
				}
				return _flatten;
			}
			set
			{
				if (_flatten == value)
				{
					return;
				}
				_flatten = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("groupingStepAngle")] 
		public CEnum<worldProxyNormalAngleStepSize> GroupingStepAngle
		{
			get
			{
				if (_groupingStepAngle == null)
				{
					_groupingStepAngle = (CEnum<worldProxyNormalAngleStepSize>) CR2WTypeManager.Create("worldProxyNormalAngleStepSize", "groupingStepAngle", cr2w, this);
				}
				return _groupingStepAngle;
			}
			set
			{
				if (_groupingStepAngle == value)
				{
					return;
				}
				_groupingStepAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("syncNormalSource")] 
		public CEnum<worldProxySyncNormalSource> SyncNormalSource
		{
			get
			{
				if (_syncNormalSource == null)
				{
					_syncNormalSource = (CEnum<worldProxySyncNormalSource>) CR2WTypeManager.Create("worldProxySyncNormalSource", "syncNormalSource", cr2w, this);
				}
				return _syncNormalSource;
			}
			set
			{
				if (_syncNormalSource == value)
				{
					return;
				}
				_syncNormalSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("coreAxisRotationOffset")] 
		public CFloat CoreAxisRotationOffset
		{
			get
			{
				if (_coreAxisRotationOffset == null)
				{
					_coreAxisRotationOffset = (CFloat) CR2WTypeManager.Create("Float", "coreAxisRotationOffset", cr2w, this);
				}
				return _coreAxisRotationOffset;
			}
			set
			{
				if (_coreAxisRotationOffset == value)
				{
					return;
				}
				_coreAxisRotationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("postFlattenReduce")] 
		public CBool PostFlattenReduce
		{
			get
			{
				if (_postFlattenReduce == null)
				{
					_postFlattenReduce = (CBool) CR2WTypeManager.Create("Bool", "postFlattenReduce", cr2w, this);
				}
				return _postFlattenReduce;
			}
			set
			{
				if (_postFlattenReduce == value)
				{
					return;
				}
				_postFlattenReduce = value;
				PropertySet(this);
			}
		}

		public worldProxySurfaceFlattenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
