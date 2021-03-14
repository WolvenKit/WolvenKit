using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitNPC : CVariable
	{
		private entEntityID _entityID;
		private CInt32 _calls;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("calls")] 
		public CInt32 Calls
		{
			get
			{
				if (_calls == null)
				{
					_calls = (CInt32) CR2WTypeManager.Create("Int32", "calls", cr2w, this);
				}
				return _calls;
			}
			set
			{
				if (_calls == value)
				{
					return;
				}
				_calls = value;
				PropertySet(this);
			}
		}

		public SHitNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
