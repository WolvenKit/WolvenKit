using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIsquadsOrder : CVariable
	{
		private CName _squadAction;
		private CUInt32 _state;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("squadAction")] 
		public CName SquadAction
		{
			get
			{
				if (_squadAction == null)
				{
					_squadAction = (CName) CR2WTypeManager.Create("CName", "squadAction", cr2w, this);
				}
				return _squadAction;
			}
			set
			{
				if (_squadAction == value)
				{
					return;
				}
				_squadAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CUInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CUInt32) CR2WTypeManager.Create("Uint32", "state", cr2w, this);
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

		[Ordinal(2)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public AIsquadsOrder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
