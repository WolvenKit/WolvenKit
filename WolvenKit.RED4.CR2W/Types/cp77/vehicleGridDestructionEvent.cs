using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGridDestructionEvent : redEvent
	{
		private CArrayFixedSize<CFloat> _state;
		private CArrayFixedSize<CFloat> _rawChange;
		private CArrayFixedSize<CFloat> _desiredChange;

		[Ordinal(0)] 
		[RED("state", 16)] 
		public CArrayFixedSize<CFloat> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[16]Float", "state", cr2w, this);
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
		[RED("rawChange", 16)] 
		public CArrayFixedSize<CFloat> RawChange
		{
			get
			{
				if (_rawChange == null)
				{
					_rawChange = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[16]Float", "rawChange", cr2w, this);
				}
				return _rawChange;
			}
			set
			{
				if (_rawChange == value)
				{
					return;
				}
				_rawChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("desiredChange", 16)] 
		public CArrayFixedSize<CFloat> DesiredChange
		{
			get
			{
				if (_desiredChange == null)
				{
					_desiredChange = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[16]Float", "desiredChange", cr2w, this);
				}
				return _desiredChange;
			}
			set
			{
				if (_desiredChange == value)
				{
					return;
				}
				_desiredChange = value;
				PropertySet(this);
			}
		}

		public vehicleGridDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
