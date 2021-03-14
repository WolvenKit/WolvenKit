using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Ladder : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _transitionType;
		private CFloat _distanceFromTop;
		private CBool _entryFromRight;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transitionType")] 
		public CInt32 TransitionType
		{
			get
			{
				if (_transitionType == null)
				{
					_transitionType = (CInt32) CR2WTypeManager.Create("Int32", "transitionType", cr2w, this);
				}
				return _transitionType;
			}
			set
			{
				if (_transitionType == value)
				{
					return;
				}
				_transitionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distanceFromTop")] 
		public CFloat DistanceFromTop
		{
			get
			{
				if (_distanceFromTop == null)
				{
					_distanceFromTop = (CFloat) CR2WTypeManager.Create("Float", "distanceFromTop", cr2w, this);
				}
				return _distanceFromTop;
			}
			set
			{
				if (_distanceFromTop == value)
				{
					return;
				}
				_distanceFromTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entryFromRight")] 
		public CBool EntryFromRight
		{
			get
			{
				if (_entryFromRight == null)
				{
					_entryFromRight = (CBool) CR2WTypeManager.Create("Bool", "entryFromRight", cr2w, this);
				}
				return _entryFromRight;
			}
			set
			{
				if (_entryFromRight == value)
				{
					return;
				}
				_entryFromRight = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Ladder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
