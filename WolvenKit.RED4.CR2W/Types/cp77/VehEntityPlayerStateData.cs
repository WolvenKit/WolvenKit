using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehEntityPlayerStateData : CVariable
	{
		private entEntityID _entID;
		private CInt32 _state;

		[Ordinal(0)] 
		[RED("entID")] 
		public entEntityID EntID
		{
			get
			{
				if (_entID == null)
				{
					_entID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entID", cr2w, this);
				}
				return _entID;
			}
			set
			{
				if (_entID == value)
				{
					return;
				}
				_entID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public VehEntityPlayerStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
