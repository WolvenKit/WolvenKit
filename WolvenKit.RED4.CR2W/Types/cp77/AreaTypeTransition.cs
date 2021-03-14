using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaTypeTransition : CVariable
	{
		private CEnum<ESecurityAreaType> _transitionTo;
		private CInt32 _transitionHour;
		private CEnum<ETransitionMode> _transitionMode;
		private CUInt32 _listenerID;

		[Ordinal(0)] 
		[RED("transitionTo")] 
		public CEnum<ESecurityAreaType> TransitionTo
		{
			get
			{
				if (_transitionTo == null)
				{
					_transitionTo = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "transitionTo", cr2w, this);
				}
				return _transitionTo;
			}
			set
			{
				if (_transitionTo == value)
				{
					return;
				}
				_transitionTo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transitionHour")] 
		public CInt32 TransitionHour
		{
			get
			{
				if (_transitionHour == null)
				{
					_transitionHour = (CInt32) CR2WTypeManager.Create("Int32", "transitionHour", cr2w, this);
				}
				return _transitionHour;
			}
			set
			{
				if (_transitionHour == value)
				{
					return;
				}
				_transitionHour = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transitionMode")] 
		public CEnum<ETransitionMode> TransitionMode
		{
			get
			{
				if (_transitionMode == null)
				{
					_transitionMode = (CEnum<ETransitionMode>) CR2WTypeManager.Create("ETransitionMode", "transitionMode", cr2w, this);
				}
				return _transitionMode;
			}
			set
			{
				if (_transitionMode == value)
				{
					return;
				}
				_transitionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get
			{
				if (_listenerID == null)
				{
					_listenerID = (CUInt32) CR2WTypeManager.Create("Uint32", "listenerID", cr2w, this);
				}
				return _listenerID;
			}
			set
			{
				if (_listenerID == value)
				{
					return;
				}
				_listenerID = value;
				PropertySet(this);
			}
		}

		public AreaTypeTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
