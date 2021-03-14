using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animIKTargetRequest : CVariable
	{
		private CFloat _weightPosition;
		private CFloat _weightOrientation;
		private CFloat _transitionIn;
		private CFloat _transitionOut;
		private CInt32 _priority;

		[Ordinal(0)] 
		[RED("weightPosition")] 
		public CFloat WeightPosition
		{
			get
			{
				if (_weightPosition == null)
				{
					_weightPosition = (CFloat) CR2WTypeManager.Create("Float", "weightPosition", cr2w, this);
				}
				return _weightPosition;
			}
			set
			{
				if (_weightPosition == value)
				{
					return;
				}
				_weightPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weightOrientation")] 
		public CFloat WeightOrientation
		{
			get
			{
				if (_weightOrientation == null)
				{
					_weightOrientation = (CFloat) CR2WTypeManager.Create("Float", "weightOrientation", cr2w, this);
				}
				return _weightOrientation;
			}
			set
			{
				if (_weightOrientation == value)
				{
					return;
				}
				_weightOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transitionIn")] 
		public CFloat TransitionIn
		{
			get
			{
				if (_transitionIn == null)
				{
					_transitionIn = (CFloat) CR2WTypeManager.Create("Float", "transitionIn", cr2w, this);
				}
				return _transitionIn;
			}
			set
			{
				if (_transitionIn == value)
				{
					return;
				}
				_transitionIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitionOut")] 
		public CFloat TransitionOut
		{
			get
			{
				if (_transitionOut == null)
				{
					_transitionOut = (CFloat) CR2WTypeManager.Create("Float", "transitionOut", cr2w, this);
				}
				return _transitionOut;
			}
			set
			{
				if (_transitionOut == value)
				{
					return;
				}
				_transitionOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		public animIKTargetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
