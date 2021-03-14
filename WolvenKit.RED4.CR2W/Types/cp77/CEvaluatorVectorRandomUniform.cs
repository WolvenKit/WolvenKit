using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorRandomUniform : IEvaluatorVector
	{
		private Vector4 _min;
		private Vector4 _max;
		private CBool _lockX;
		private CBool _lockY;
		private CBool _lockZ;
		private CBool _lockW;

		[Ordinal(2)] 
		[RED("min")] 
		public Vector4 Min
		{
			get
			{
				if (_min == null)
				{
					_min = (Vector4) CR2WTypeManager.Create("Vector4", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("max")] 
		public Vector4 Max
		{
			get
			{
				if (_max == null)
				{
					_max = (Vector4) CR2WTypeManager.Create("Vector4", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lockX")] 
		public CBool LockX
		{
			get
			{
				if (_lockX == null)
				{
					_lockX = (CBool) CR2WTypeManager.Create("Bool", "lockX", cr2w, this);
				}
				return _lockX;
			}
			set
			{
				if (_lockX == value)
				{
					return;
				}
				_lockX = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lockY")] 
		public CBool LockY
		{
			get
			{
				if (_lockY == null)
				{
					_lockY = (CBool) CR2WTypeManager.Create("Bool", "lockY", cr2w, this);
				}
				return _lockY;
			}
			set
			{
				if (_lockY == value)
				{
					return;
				}
				_lockY = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lockZ")] 
		public CBool LockZ
		{
			get
			{
				if (_lockZ == null)
				{
					_lockZ = (CBool) CR2WTypeManager.Create("Bool", "lockZ", cr2w, this);
				}
				return _lockZ;
			}
			set
			{
				if (_lockZ == value)
				{
					return;
				}
				_lockZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lockW")] 
		public CBool LockW
		{
			get
			{
				if (_lockW == null)
				{
					_lockW = (CBool) CR2WTypeManager.Create("Bool", "lockW", cr2w, this);
				}
				return _lockW;
			}
			set
			{
				if (_lockW == value)
				{
					return;
				}
				_lockW = value;
				PropertySet(this);
			}
		}

		public CEvaluatorVectorRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
