using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyBoundingBoxSyncParams : CVariable
	{
		private CEnum<worldProxyBBoxSyncOptions> _positiveAxis;
		private CEnum<worldProxyBBoxSyncOptions> _negativeAxis;
		private CFloat _pullRange;
		private CBool _makeStackable;
		private Vector3 _stackOffset;

		[Ordinal(0)] 
		[RED("positiveAxis")] 
		public CEnum<worldProxyBBoxSyncOptions> PositiveAxis
		{
			get
			{
				if (_positiveAxis == null)
				{
					_positiveAxis = (CEnum<worldProxyBBoxSyncOptions>) CR2WTypeManager.Create("worldProxyBBoxSyncOptions", "positiveAxis", cr2w, this);
				}
				return _positiveAxis;
			}
			set
			{
				if (_positiveAxis == value)
				{
					return;
				}
				_positiveAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("negativeAxis")] 
		public CEnum<worldProxyBBoxSyncOptions> NegativeAxis
		{
			get
			{
				if (_negativeAxis == null)
				{
					_negativeAxis = (CEnum<worldProxyBBoxSyncOptions>) CR2WTypeManager.Create("worldProxyBBoxSyncOptions", "negativeAxis", cr2w, this);
				}
				return _negativeAxis;
			}
			set
			{
				if (_negativeAxis == value)
				{
					return;
				}
				_negativeAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pullRange")] 
		public CFloat PullRange
		{
			get
			{
				if (_pullRange == null)
				{
					_pullRange = (CFloat) CR2WTypeManager.Create("Float", "pullRange", cr2w, this);
				}
				return _pullRange;
			}
			set
			{
				if (_pullRange == value)
				{
					return;
				}
				_pullRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("makeStackable")] 
		public CBool MakeStackable
		{
			get
			{
				if (_makeStackable == null)
				{
					_makeStackable = (CBool) CR2WTypeManager.Create("Bool", "makeStackable", cr2w, this);
				}
				return _makeStackable;
			}
			set
			{
				if (_makeStackable == value)
				{
					return;
				}
				_makeStackable = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stackOffset")] 
		public Vector3 StackOffset
		{
			get
			{
				if (_stackOffset == null)
				{
					_stackOffset = (Vector3) CR2WTypeManager.Create("Vector3", "stackOffset", cr2w, this);
				}
				return _stackOffset;
			}
			set
			{
				if (_stackOffset == value)
				{
					return;
				}
				_stackOffset = value;
				PropertySet(this);
			}
		}

		public worldProxyBoundingBoxSyncParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
